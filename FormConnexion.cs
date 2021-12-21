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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            Controleur.initConnexion();
            Controleur.VmodeleC.seconnecter();
            
            if (Controleur.VmodeleC.Connopen == false)
            {
                MessageBox.Show("erreur dans la connexion");
                Application.Exit();
            }
            else
            {
                tbLogin.Focus();
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // si la BD est connectée et si les champs login et mdp sont saisis
            if (Controleur.VmodeleC.Connopen && tbLogin.Text != "" && tbMdp.Text != "")
            {
                // on recherche l'utilisateur connecté avec le login
                Controleur.VmodeleC.charger_Administrateur(tbLogin.Text);

                // s'il existe bien un utilisateur avec ce login
                if (Controleur.VmodeleC.Chargement)
                {
                    if (Controleur.VmodeleC.DT[0].Rows.Count != 0)
                    {
                        // on compare le mot de passe saisi avec le mot de passe crypté de la BD lié à ce login     
                        if (BCrypt.Net.BCrypt.Verify(tbMdp.Text, Controleur.VmodeleC.DT[0].Rows[0]["MOTDEPASSE"].ToString()))
                        {
                            MessageBox.Show("Connecté en tant qu'utilisateur '" + Controleur.VmodeleC.DT[0].Rows[0]["PSEUDO"].ToString() + "'");

                            // on ouvre la vue principale de l'application en passant en paramètre le nom de l'utilisateur
                            FormPrincipale FC = new FormPrincipale(Controleur.VmodeleC.DT[0].Rows[0]["PSEUDO"].ToString());
                            FC.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("ERREUR : Mot de passe incorrects");
                    }
                    else
                    {
                        MessageBox.Show("ERREUR : Nom incorrect");
                        tbMdp.Clear();
                        tbLogin.Focus();
                    }
                }

            }
            else 
                MessageBox.Show("ERREUR : Saisir un nom et un mot de passe");

        }
    }
}
