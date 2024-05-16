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
    public partial class Login : Form
    {
        private static string req = "Data Source=DESKTOP-PAMPD92\\SQLEXPRESS;Initial Catalog=Location_DataBase;Integrated security=true";
        
        private static DataContext SqlDb = new DataContext(req);

        private static Table<connexion> con = SqlDb.GetTable<connexion>();

    


        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordText.UseSystemPasswordChar = true;

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void keypress_changed(object sender, KeyPressEventArgs e)
        {
        }

        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            var connex = from c in con where c.username == Convert.ToString(UserText.Text) && c.password == PasswordText.Text.ToString() select c;

            if (connex.Any())
                {
                    Session_Agent session_Agent = new Session_Agent();
                    this.Hide();
                    session_Agent.Show();
                    
                    
                }
            else
                {
                    MessageBox.Show("le nom d'utilisateur ou le mot de passe est invalide, veuillez réessayer de nouveau!");
                }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
