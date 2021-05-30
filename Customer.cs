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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");
        private void populate()
        {
            Con.Open();
            string query = "select * from KlienciTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];
            Con.Close();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NazwaTb.Text == "" || AdresTb.Text == "" || TelefonTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into KlienciTb1 values('" + IdTb.Text + "','" + NazwaTb.Text + "','" + AdresTb.Text + "','" + TelefonTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Klient dodany!");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from KlienciTb1 where IdKlienta=" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Klient usuniety");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = CustomersDGV.SelectedRows[0].Cells[0].Value.ToString();
            NazwaTb.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            AdresTb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            TelefonTb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NazwaTb.Text == "" || AdresTb.Text == "" || TelefonTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update KlienciTb1 set NazwaKlienta='" + NazwaTb.Text + "',AdresKlienta='" + AdresTb.Text + "',Telefon ='" + TelefonTb.Text + "' where IdKlienta =" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Klient zmodyfikowany");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
