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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");
        private void populate()
        {
            Con.Open();
            string query = "select * from CarTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
           
        }
        private void fillAvaiable()
        {
            Con.Open();
            string query = "select Dostępność from CarTb1";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Dostępność", typeof(string));
            dt.Load(rdr);
            Szukaj.ValueMember = "Dostępność";
            Szukaj.DataSource = dt;
            Con.Close();
        }
        private void Car_Load(object sender, EventArgs e)
        {
            populate();
            //fillAvaiable();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace pola!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTb1 values ('" + RegNumTb.Text + "','" + BrandTb.Text + "','" + ModelTb.Text + "', '" + AvaiableCb.SelectedItem.ToString() + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano auto!");
                    Con.Close();
                    populate();
                }


                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace informacje!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTb1 where IdAuta ='" + RegNumTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usunięto samochód!");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNumTb.Text = CarsDGV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AvaiableCb.Text = CarsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CarsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace pola!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CarTb1 set Marka='" + BrandTb.Text + "',Model='" + ModelTb.Text + "', Dostępność = '" + AvaiableCb.SelectedItem.ToString() + "',Cena= " + PriceTb.Text + " where IdAuta='" + RegNumTb.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Zaktualizowano dane samochodu!");
                    Con.Close();
                    populate();
                }


                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Glowne main = new Menu_Glowne();
            main.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Szukaj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if(Szukaj.SelectedItem.ToString() == "Dostępny")
            {
                flag = "Tak";
            }
            else
            {
                flag = "Nie";
            }
            Con.Open();
            string query = "select * from CarTb1 where Dostępność = '"+flag+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
