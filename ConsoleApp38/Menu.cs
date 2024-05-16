using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp38
{
    public partial class Session_Agent : Form
    {
        public Session_Agent()
        {
            InitializeComponent();
        }

        private void FlotteBtn_Click(object sender, EventArgs e)
        {
            FlotteForm flotteForm1 = new FlotteForm();
            this.Hide();
            flotteForm1.Show();
        }

        private void ReserverBtn_Click(object sender, EventArgs e)
        {
            Reservation Reservation1 = new Reservation();
            this.Hide();
            Reservation1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintenanceForm Maintenance1 = new MaintenanceForm();
            this.Hide();
            Maintenance1.Show();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm1 Client1 = new ClientForm1();
            this.Hide();
            Client1.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
