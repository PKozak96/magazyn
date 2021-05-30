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
    public partial class Zwroty : Form
    {
        public Zwroty()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");
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
        private void populateZwroty()
        {
            Con.Open();
            string query = "select * from ZwrotyTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ZwrotyDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void DeleteOnZwroty()
        {
            int rentId;
            rentId = Convert.ToInt32 (RentDGV.SelectedRows[0].Cells[0].Value.ToString());
            Con.Open();
            string query = "delete from WypozyczeniaTb1 where Idwypozyczenia =" + rentId + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Wypożyczenie usunięte!");
            Con.Close();
            //UpdateonRentDelete();
            populate();
        }

        private void Zwroty_Load(object sender, EventArgs e)
        {
            populate();
            populateZwroty();
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarIdTb.Text = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            NazwaTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            ReturnDate.Text = RentDGV.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = ReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);
            if (NrOfDays <= 0)
            {
                DelayTb.Text = "Bez opóźnienia!";
                KwotaTb.Text = "0";
            } else
            {
                DelayTb.Text = "" + NrOfDays;
                KwotaTb.Text = "" + (NrOfDays * 250);
            }
                    }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Glowne main = new Menu_Glowne();
            main.Show();
        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NazwaTb.Text == "" || KwotaTb.Text == "" || DelayTb.Text=="" || CarIdTb.Text =="")
            {
                MessageBox.Show("Uzupełnij brakujące informacje");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ZwrotyTb1 values('" + IdTb.Text + "','" + CarIdTb.Text + "','" + NazwaTb.Text + "','" + ReturnDate.Value.ToString("yyyy-MM-dd") + "','"+DelayTb.Text+"','" + KwotaTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Auto zostalo zwrócone");
                    Con.Close();
                    //UpdateonRent();
                    populateZwroty();
                    DeleteOnZwroty();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void ZwrotyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
