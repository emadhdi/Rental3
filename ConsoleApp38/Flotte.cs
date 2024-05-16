using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace ConsoleApp38
{
    public partial class FlotteForm : Form
    {

        private static string req = "Data Source=DESKTOP-PAMPD92\\SQLEXPRESS;Initial Catalog=Location_DataBase;Integrated security=true";

        private static DataContext Dbo = new DataContext(req);

        private static Table<voiture> voiture = Dbo.GetTable<voiture>();    

        public FlotteForm()
        {
            InitializeComponent();
        }

        private void FlotteForm_Load(object sender, EventArgs e)
        {
            var req = (from v in voiture orderby Convert.ToInt32(v.id_voiture.Substring(1)) descending select v).FirstOrDefault();
            int Idnumber = Convert.ToInt32(req.id_voiture.Substring(1));
            Idnumber++;
            IdTxt.Text = "V"+Idnumber.ToString();
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            voiture voit = new voiture
            {
                id_voiture = IdTxt.Text.ToString(),
                marque = MarqueTxt.Text.ToString(),
                modele = ModeleTxt.Text.ToString(),
                matricule = MatriculeTxt.Text.ToString(),
                annee_acquisition = Convert.ToInt32(AAcquisTxt.Text),
                prix = Convert.ToInt32(PrixTxt.Text), 
            };

            voiture.InsertOnSubmit(voit);
            Dbo.SubmitChanges();

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            var req = (from v in voiture where v.id_voiture==IdTxt.Text select v).FirstOrDefault();

            req.marque = MarqueTxt.Text.ToString();
            req.modele = ModeleTxt.Text.ToString();
            req.matricule = MatriculeTxt.Text.ToString();
            req.annee_acquisition = Convert.ToInt32(AAcquisTxt.Text);
            req.prix= Convert.ToInt32(PrixTxt.Text);
            Dbo.SubmitChanges();
        }

        private void RecherBtn_Click(object sender, EventArgs e)
        {
            var req = (from v in voiture where v.id_voiture == IdTxt.Text select v).FirstOrDefault();

            MarqueTxt.Text = req.marque;
            ModeleTxt.Text = req.modele;
            MatriculeTxt.Text= req.matricule;
            AAcquisTxt.Text = req.annee_acquisition.ToString();
            PrixTxt.Text = req.prix.ToString();

        }

        private void ViderBtn_Click(object sender, EventArgs e)
        {
            MarqueTxt.Clear();
            MatriculeTxt.Clear();
            ModeleTxt.Clear();
            MatriculeTxt.Clear();
            AAcquisTxt.Clear();
            PrixTxt.Clear();

        }

        private void SupprBtn_Click(object sender, EventArgs e)
        {
            var req = (from v in voiture where v.id_voiture == IdTxt.Text select v).FirstOrDefault();

            voiture.InsertOnSubmit(req);
            Dbo.SubmitChanges();
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
            ClientForm Client1 = new ClientForm();
            this.Hide();
            Client1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintenanceForm Maintenance1 = new MaintenanceForm();
            this.Hide();
            Maintenance1.ShowDialog();
        }
    }
}
