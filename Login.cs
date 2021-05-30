using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WypozyczalniaAut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");

        private void Label8_Click(object sender, EventArgs e)
        {
            Uimie.Text = "";
            UpassTb.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from UserTb1 where Uimie='" + Uimie.Text + "' and Upass='" + UpassTb.Text + "'";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu_Glowne mainform = new Menu_Glowne();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zły login lub hasło!");
            }
                
            

            Con.Close();
        }
    }
}
