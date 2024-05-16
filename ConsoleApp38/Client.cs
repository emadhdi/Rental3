using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp38
{
    public partial class ClientForm : Form
    {

        private static string req = "Data Source=DESKTOP-PAMPD92\\SQLEXPRESS;Initial Catalog=Location_DataBase;Integrated security=true";
        private static DataContext Dbo = new DataContext(req);

        private static Table<client> client = Dbo.GetTable<client>();




        public ClientForm()
        {
            InitializeComponent();
           
        }

     

        private void ClientForm_Load(object sender, EventArgs e)
        {
            var req = (from c in client orderby Convert.ToInt32(c.id_client.Substring(1)) descending select c).FirstOrDefault();
            int Idnumber = Convert.ToInt32(req.id_client.Substring(1));
            Idnumber++;
            IdTxt.Text = "C" + Idnumber.ToString();
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            var req = (from c in client where CinTxt.Text.ToString() == c.cin select c).FirstOrDefault();

            
            client clt = new client
            {
                id_client = IdTxt.Text.ToString(),
                nom = NomTxt.Text.ToString(),
                prenom = PreTxt.Text.ToString(),
                cin = CinTxt.Text.ToString(),
                tel = Convert.ToInt32(TelTxt.Text),
            };
            
            if (req == null) { 
                client.InsertOnSubmit(clt);
                Dbo.SubmitChanges();
                Reservation.instance.AjouterClient.Text = "Modifier Client";
                Reservation.instance.ClientLabel.Text = CinTxt.Text.ToString();
            }
            else
            {
                Reservation.instance.AjouterClient.Text = "Modifier Client";
                Reservation.instance.ClientLabel.Text = CinTxt.Text.ToString();
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            var req = (from c in client where c.id_client == IdTxt.Text select c).FirstOrDefault();


            req.nom = NomTxt.ToString();
            req.prenom = PreTxt.ToString();
            req.cin = CinTxt.ToString();
            req.tel = Convert.ToInt32(TelTxt);
            Dbo.SubmitChanges();
            MessageBox.Show("La modification a été effectuée avec succés");
        }

        private void RechBtn_Click(object sender, EventArgs e)
        {
            var req = (from c in client where c.id_client == IdTxt.Text select c).FirstOrDefault();           

            NomTxt.Text=req.nom;
            PreTxt.Text=req.prenom;
            CinTxt.Text=req.cin;
            TelTxt.Text = req.tel.ToString();
        }

        private void SuppBtn_Click(object sender, EventArgs e)
        {
            var req = (from c in client where c.id_client == IdTxt.Text select c).FirstOrDefault();

            client.DeleteOnSubmit(req);
            Dbo.SubmitChanges();
        }

        private void ViderBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Clear();
            NomTxt.Clear();
            PreTxt.Clear();
            CinTxt.Clear();
            TelTxt.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReserverBtn_Click(object sender, EventArgs e)
        {
            Reservation Reservation1 = new Reservation();
            this.Hide();
            Reservation1.ShowDialog();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {

        }

        private void FlotteBtn_Click(object sender, EventArgs e)
        {
            FlotteForm flotteForm1 = new FlotteForm();
            this.Hide();
            flotteForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintenanceForm Maintenance1 = new MaintenanceForm();
            this.Hide();
            Maintenance1.ShowDialog();
        }
    }
}
