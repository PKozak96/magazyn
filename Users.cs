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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent(); 
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP - 23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Uid.Text == "" || Uimie.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace pola!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTb1 value(" + Uid.Text + ",'" + Uimie.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano użytkownika");
                    Con.Close();
                }


                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }

        }
    }
}
