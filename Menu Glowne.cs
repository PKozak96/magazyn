using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczalniaAut
{
    public partial class Menu_Glowne : Form
    {
        public Menu_Glowne()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia rent = new Wypozyczenia();
            rent.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zwroty zwroty = new Zwroty();
            zwroty.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard board = new DashBoard();
            board.Show();
        }
    }
}
