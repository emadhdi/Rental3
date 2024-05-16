
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApp38
{
    public partial class Reservation : Form
    {
        public static Reservation instance;

        public Button AjouterClient;

        public Label ClientLabel;

        public TextBox Montant;

        public TextBox Avance;

        public TextBox Reste;

        public DataGridView DataGridView1;

        public DateTimePicker Date_Fin1;

        private static string req = "Data Source=DESKTOP-PAMPD92\\SQLEXPRESS;Initial Catalog=Location_DataBase;Integrated security=true";
        private static DataContext Dbo = new DataContext(req);

        private static Table<voiture> voiture = Dbo.GetTable<voiture>();

        private static Table<reservation> reservation = Dbo.GetTable<reservation>();

        private static Table<maintenance> maintenance = Dbo.GetTable<maintenance>();

        private static Table<client> client = Dbo.GetTable<client>();

        public Reservation()
        {
            InitializeComponent();

            instance = this;

            AjouterClient = AjouterClientBtn;

            ClientLabel = ClientActLabel;

            Montant = PrixTxt;

            Avance = AvanceTxt;

            Reste = ResteTxt;

            DataGridView1 = DataGrid1;

            Date_Fin1 = DateFin;
        }

        

        private void ConsulterBtn_Click(object sender, EventArgs e)
        {


        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            var Req = from v in voiture select v.modele;

            //ModeleCombo.DataSource = Req;

            AjouterClientBtn.Text = "Ajouter";

        }

        private void ConsulterBtn_Click_1(object sender, EventArgs e)
        {
            DateTime Date_Debut = DateDebut.Value.Date;
            DateTime Date_Fin = DateFin.Value.Date;
            var req = from v in voiture
                      where !(
                          from v2 in voiture
                          join r in reservation on v2.id_voiture equals r.id_voiture into joinedRes
                          from j in joinedRes.DefaultIfEmpty()
                          join m in maintenance on v2.id_voiture equals m.id_voiture into joinedMain
                          from i in joinedMain.DefaultIfEmpty()
                          where (j != null && (Date_Debut.CompareTo(j.date_fin) <= 0 && Date_Fin.CompareTo(j.date_debut) >= 0))
                             || (i != null && (Date_Debut.CompareTo(i.date_fin) <= 0 && Date_Fin.CompareTo(i.date_debut) >= 0))
                          select v2.id_voiture
                      ).Contains(v.id_voiture)
                      select new { v.id_voiture, v.marque, v.modele };

            DataGrid1.DataSource = req;

        }

        private void DataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGrid1.SelectedRows.Count > 0)
            {
                // Récupérer l'index de la ligne sélectionnée
                int rowIndex = DataGrid1.SelectedRows[0].Index;

                // Récupérer la valeur de la colonne contenant l'ID de la voiture
                string idVoiture = (string)DataGrid1.Rows[rowIndex].Cells["id_voiture"].Value;

                voiture Req = (voiture)(from v in voiture where v.id_voiture == idVoiture select v).FirstOrDefault();

                MarqueTxt.Text = Req.marque.ToString();
                ModeleTxt.Text = Req.modele.ToString();
                PrixTxt.Text = Req.prix.ToString();

            }
        }

        private void AvanceTxt_TextChanged(object sender, EventArgs e)
        {


            int prix = Convert.ToInt32(PrixTxt.Text);
            int avance;
            int reste;

            if (int.TryParse(AvanceTxt.Text, out avance))
            {
                reste = prix - avance;
                
                if(reste >= 0) 
                {
                    ResteTxt.Text = reste.ToString();
                }

                else
                {
                    MessageBox.Show("Le montant de l'avance est invalide (supérieure au prix d'avance)");
                }
            }

            else
            {
                MessageBox.Show("Le format du montant de l'avance est invalide (veuillez taper des chiffres)");
            }

        }

        private void AjouterClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm ClientForm1 = new ClientForm();

            ClientForm1.ShowDialog();
        }

        private void ReserverDataGrid_Click(object sender, EventArgs e)
        {
            client cl = (from c in client where c.cin == ClientActLabel.Text.ToString() select c).FirstOrDefault();

            var req = (from r in reservation orderby Convert.ToInt32(r.id_reservation.Substring(1)) descending select r).FirstOrDefault();
            int Idnumber = Convert.ToInt32(req.id_reservation.Substring(1));
            Idnumber++;
            string ResId = "R" + Idnumber.ToString();

            // Récupérer l'index de la ligne sélectionnée
            int rowIndex = DataGrid1.SelectedRows[0].Index;

            // Récupérer la valeur de la colonne contenant l'ID de la voiture
            string idVoiture = (string)DataGrid1.Rows[rowIndex].Cells["id_voiture"].Value;

            voiture req2 = (from v in voiture where v.id_voiture == idVoiture select v).FirstOrDefault();

            DateTime Date_Debut = DateDebut.Value.Date;
            DateTime Date_Fin = DateFin.Value.Date;

            reservation res = new reservation
            {
                id_reservation = ResId,
                id_voiture = req2.id_voiture,
                id_client = cl.id_client,
                date_debut = Date_Debut,
                date_fin = Date_Fin,
                montant = Convert.ToInt32(PrixTxt.Text),
                avance = Convert.ToInt32(AvanceTxt.Text),
                reste = Convert.ToInt32(ResteTxt.Text)
            };

            reservation.InsertOnSubmit(res);
            Dbo.SubmitChanges();

            Facture facture = new Facture();

            facture.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReserverBtn_Click(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            MaintenanceForm Maintenance1 = new MaintenanceForm();
            this.Hide();
            Maintenance1.ShowDialog();

        }
    }
}
