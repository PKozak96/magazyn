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
    public partial class Wypozyczenia : Form
    {
        public Wypozyczenia()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");
        private void fillcombo()
        {
            Con.Open();
            string query = "select IdAuta from CarTb1 where Dostępność='"+"Tak"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdAuta", typeof(string));
            dt.Load(rdr);
            IdAutaCb.ValueMember = "IdAuta";
            IdAutaCb.DataSource = dt;
            Con.Close();
        }
        private void fillCustomer()
        {
            Con.Open();
            string query = "select IdKlienta from KlienciTb1";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdKlienta", typeof(int));
            dt.Load(rdr);
            CustCb.ValueMember = "IdKlienta";
            CustCb.DataSource = dt;
            Con.Close();
        }
        private void fetchNazwaKlienta()
        {
            Con.Open();
            string query = "select * from KlienciTb1 where IdKlienta=" + CustCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NazwaTb.Text = dr["NazwaKlienta"].ToString();
            }
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from WypozyczeniaTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void UpdateonRent()
        {
            Con.Open();
            string query = "update CarTb1 set Dostępność ='" + "Nie" + "',Cena ='" + "' where IdAuta='" + IdAutaCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Klient zmodyfikowany");
            Con.Close();

        }
        private void UpdateonRentDelete()
        {
            Con.Open();
            string query = "update CarTb1 set Dostępność ='" + "Tak" + "',Cena ='" + "' where IdAuta='" + IdAutaCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Klient zmodyfikowany");
            Con.Close();
        }
            private void Wypozyczenia_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void IdAutaCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchNazwaKlienta();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NazwaTb.Text == "" || KwotaTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into WypozyczeniaTb1 values('" + IdTb.Text + "','" + IdAutaCb.SelectedValue.ToString() + "','" + NazwaTb.Text + "','" + RentDate.Value.ToString("yyyy-MM-dd") + "', '" + ReturnDate.Value.ToString("yyyy-MM-dd") + "','" + KwotaTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Auto zostalo wypozyczone");
                    Con.Close();
                    UpdateonRent();
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

        private void RentDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace informacje!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from WypozyczeniaTb1 where Idwypozyczenia =" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Wypożyczenie usunięte!");
                    Con.Close();
                    UpdateonRentDelete();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            IdAutaCb.SelectedValue = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            NazwaTb.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
            KwotaTb.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
