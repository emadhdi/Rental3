using Microsoft.AnalysisServices;
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
    public partial class Facture : Form
    {

        private static string req = "Data Source=DESKTOP-PAMPD92\\SQLEXPRESS;Initial Catalog=Location_DataBase;Integrated security=true";
        private static DataContext Dbo = new DataContext(req);

        private static Table<voiture> voiture = Dbo.GetTable<voiture>();

        private static Table<reservation> reservation = Dbo.GetTable<reservation>();

        private static Table<maintenance> maintenance = Dbo.GetTable<maintenance>();

        private static Table<client> client = Dbo.GetTable<client>();
        public Facture()
        {
            InitializeComponent();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            //ReportParameterCollection parameters = new ReportParameterCollection();
            //parameters.Add(new ReportParameter("Montant", Reservation.instance.Montant.Text));
            //parameters.Add(new ReportParameter("Avance", Reservation.instance.Avance.Text));
            //parameters.Add(new ReportParameter("Reste", Reservation.instance.Reste.Text));
            //IEnumerable<ReportParameter> parameterEnumerable = parameters.Cast<ReportParameter>();

            //reportViewer1.LocalReport.SetParameters((IEnumerable<Microsoft.Reporting.WinForms.ReportParameter>)parameterEnumerable);
            //this.reportViewer1.RefreshReport();

            client cl = (from c in client where c.cin == Reservation.instance.ClientLabel.Text.ToString() select c).FirstOrDefault();

            int rowIndex = Reservation.instance.DataGridView1.SelectedRows[0].Index;

            string idVoiture = (string)Reservation.instance.DataGridView1.Rows[rowIndex].Cells["id_voiture"].Value;

            List<Microsoft.Reporting.WinForms.ReportParameter> parameterList = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            voiture req2 = (from v in voiture where v.id_voiture == idVoiture select v).FirstOrDefault();



            // Ajouter vos paramètres à la liste
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Montant", Reservation.instance.Montant.Text));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Avance", Reservation.instance.Avance.Text));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Reste", Reservation.instance.Reste.Text));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Nom", cl.nom));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Prenom", cl.prenom));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("CIN", cl.cin));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Marque", req2.marque));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Modele", req2.modele));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Matricule", req2.matricule));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Date_Fin", Reservation.instance.Date_Fin1.Value.Date.ToString()));




            // Utiliser la liste de paramètres pour le rapport
            reportViewer1.LocalReport.SetParameters(parameterList);
            this.reportViewer1.RefreshReport();


        }
    }
}
