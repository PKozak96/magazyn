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
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP - 23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (IdAuta.Text == "" || Marka.Text == "" || Model.Text == "" || Cena.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace pola!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTb1 value ('" + IdAuta.Text + "','" + Marka.Text + "','" + Model.Text + "', '" + Dostępność.SelectedItem.ToString()"'," + Cena.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano auto");
                    Con.Close();
                }


                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void Car_load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
