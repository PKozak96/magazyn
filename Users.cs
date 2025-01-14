﻿using System;
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
        SqlConnection Con = new SqlConnection(@"Data Source = DESKTOP-23VTF8R\KONRADSQL; Initial Catalog = WypozyczalniaAutdb; Integrated Security = True");

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];
            Con.Close();
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
                    string query = "insert into UserTb1 values("+Uid.Text+",'"+Uimie.Text+"','"+Upass.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano użytkownika");
                    Con.Close();
                    populate();
                }


                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }

        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace informacje!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTb1 where Uid =" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usunięto użytkownika!");
                    Con.Close();
                    populate();
                }catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uid.Text = UsersDGV.SelectedRows[0].Cells[0].Value.ToString();
            Uimie.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uimie.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujace pola!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTb1 set Uimie='" + Uimie.Text + "',Upass='" + Upass.Text + "'where Uid=" + Uid.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Zedytowano użytkownika");
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
    }
}
