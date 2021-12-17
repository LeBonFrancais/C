using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebonfrancais.service
{
    public partial class FormPrincipale : Form
    {
        private string admin;
        public FormPrincipale(string admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.Text = "LeBonFrancais : " + admin;
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            if (deconnexionToolStripMenuItem.Enabled == false)
            {
                gestionDesFormationsToolStripMenuItem.Enabled = false;
            }
            else
            {
                gestionDesFormationsToolStripMenuItem.Enabled = true;
            }

            reconnecterToolStripMenuItem.Enabled = false;
            if (deconnexionToolStripMenuItem.Enabled == false)
            {
                reconnecterToolStripMenuItem.Enabled = true;
            }
            tbAdmin.Text = admin;
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez Vous vraiment quitter l'application", "AVERTISSEMENTS", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controleur.VmodeleC.sedeconnecter();
            MessageBox.Show("Vous êtes déconnecté de la base de données");
            gestionDesFormationsToolStripMenuItem.Enabled = false;
            deconnexionToolStripMenuItem.Enabled = false;
            FormPrincipale_Load(sender, e);
        }

        private void reconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform);            
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform()
        {
            Application.Run(new FormConnexion());
        }

        private void outilInscritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOutilInscrits formOutilInscrits = new FormOutilInscrits();
            formOutilInscrits.Show();
        }

        private void outilServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOutilServices formOutilServices = new FormOutilServices();
            formOutilServices.Show();
        }

        private void afficherLesInscritsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscrits formInscrits = new FormInscrits();
            formInscrits.Show();
        }

        private void afficherLesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServices formServices = new FormServices();
            formServices.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContact formContact = new FormContact();
            formContact.Show();
        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistique formStatistique = new FormStatistique();
            formStatistique.Show();
        }
    }
}
