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
    public partial class MaintenanceForm : Form
    {

        private static string req = "Data Source=DESKTOP-PAMPD92\\SQLEXPRESS;Initial Catalog=Location_DataBase;Integrated security=true";

        private static DataContext Dbo = new DataContext(req);

        private static Table<maintenance> maintenance = Dbo.GetTable<maintenance>();

        private static Table<voiture> voiture = Dbo.GetTable<voiture>();

        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var req = (from m in maintenance orderby Convert.ToInt32(m.id_maintenance.Substring(1)) descending select m).FirstOrDefault();
            int Idnumber = Convert.ToInt32(req.id_maintenance.Substring(1));
            Idnumber++;
            IdTxt.Text = "M" + Idnumber.ToString();

            var req1 = from v in voiture select v.modele;

            ModeleCombo.DataSource = req1;

            

            TypeMaintCombo.Items.Add("visite_technique");
            TypeMaintCombo.Items.Add("panne");

        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {

            string req = (string)(from v in voiture where v.modele == ModeleCombo.SelectedItem.ToString()
                      select v.id_voiture).FirstOrDefault();

            maintenance maint = new maintenance
            {
                id_maintenance = IdTxt.Text.ToString(),
                type = TypeMaintCombo.SelectedItem.ToString(),
                id_voiture = req,
                date_debut = datedebutM.Value.Date,
                date_fin = datefinM.Value.Date,
            };

            maintenance.InsertOnSubmit(maint);
            Dbo.SubmitChanges();
            MessageBox.Show("L'insertion a été effectuée avec succés");

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            var req = (from m in maintenance where m.id_maintenance == IdTxt.Text select m).FirstOrDefault();

            string idvoiture = (string)(from v in voiture
                                  where v.modele == ModeleCombo.SelectedItem.ToString()
                                  select v.id_voiture).FirstOrDefault();

            req.type = TypeMaintCombo.SelectedItem.ToString();
            req.id_voiture = idvoiture;
            req.date_debut = datedebutM.Value.Date;
            req.date_fin = datefinM.Value.Date;
            Dbo.SubmitChanges();
            MessageBox.Show("La modification a été effectuée avec succés");
        }

        private void RecherBtn_Click(object sender, EventArgs e)
        {
            var req = (from m in maintenance where m.id_maintenance == IdTxt.Text select m).FirstOrDefault();
            string modele = (string)(from v in voiture
                                        where v.id_voiture == req.id_voiture
                                        select v.modele).FirstOrDefault();

            TypeMaintCombo.SelectedItem = req.type;
            ModeleCombo.SelectedItem = modele;
            datedebutM.Value = (DateTime)req.date_debut;
            datefinM.Value = (DateTime)(req.date_fin);
           
        }

        private void SupprBtn_Click(object sender, EventArgs e)
        {
            var req = (from m in maintenance where m.id_maintenance == IdTxt.Text select m).FirstOrDefault();

            maintenance.InsertOnSubmit(req);
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

        private void FlotteBtn_Click(object sender, EventArgs e)
        {
            FlotteForm flotteForm1 = new FlotteForm();
            this.Hide();
            flotteForm1.ShowDialog();
        }
    }
    
}
