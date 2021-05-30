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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            string querycar = "select Count(*) from CarTb1";
            SqlDataAdapter sda = new SqlDataAdapter(querycar, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CarsLb1.Text = dt.Rows[0][0].ToString();
            string querycust = "select Count(*) from KlienciTb1";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CustLb1.Text = dt1.Rows[0][0].ToString();
            string queryuser = "select Count(*) from UserTb1";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryuser, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UsersLb1.Text = dt2.Rows[0][0].ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Glowne main = new Menu_Glowne();
            main.Show();

        }
    }
}
