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
    public partial class FormOutilInscrits : Form
    {
        private int id = -1;
        public FormOutilInscrits(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormOutilInscrits_Load(object sender, EventArgs e)
        {
            Controleur.initService();
            Controleur.initInscrit();
            
            Controleur.VmodeleSe.charger_Departement();
            chargerComboBoxDepartement();

        }

        private void chargerComboBoxDepartement()
        {
            cbDepartement.Items.Clear();
            if (Controleur.VmodeleC.DT[5].Rows.Count == 0)
            {
                cbDepartement.Items.Add("Pas de departement en base");
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[5].Rows.Count; i++)
                {
                    cbDepartement.Items.Add(Controleur.VmodeleC.DT[5].Rows[i]["NOM"].ToString());
                }
            }
        }

        private void CbDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArrondissement.Visible = true;
            labelAr.Visible = true;
            cbArrondissement.Items.Clear();
            int idDepartement = Convert.ToInt32(cbDepartement.SelectedIndex);
            Controleur.VmodeleSe.charger_ArrondissementSelonDepartement(idDepartement);
            if (cbDepartement.SelectedIndex != -1)
            {
                if (Controleur.VmodeleC.DT[2].Rows.Count == 0)
                {
                    //
                }
                else
                {
                    // 
                    for (int i = 0; i < Controleur.VmodeleC.DT[2].Rows.Count; i++)
                    {
                        cbArrondissement.Items.Add(Controleur.VmodeleC.DT[2].Rows[i]["A.NOM"].ToString());
                    }
                }

            }
        }

        private void BtnAjoutModif_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                // condition pour ajouter un service
                if (tbNom.Text != "" && tbPrenom.Text != "" && tbMdp.Text != "" && tbMail.Text != "")
                {
                    //si les mots de passes sont identiques
                    if (tbMdp.Text == tbConfMdp.Text)
                    {
                        //hash du mot de passe
                        string password = tbMdp.Text;
                        string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
                        password = BCrypt.Net.BCrypt.HashPassword(password, mySalt);

                        //recup de l'id du département choisi.
                        string nomDe = Convert.ToString(cbDepartement.SelectedIndex);
                        Controleur.VmodeleSe.chargerIdDe_selonNom(nomDe);
                        int idDe = Convert.ToInt32(Controleur.VmodeleC.DT[3].Rows[0]);

                        //recup de l'id du département choisi.
                        string nomAr = Convert.ToString(cbArrondissement.SelectedIndex);
                        Controleur.VmodeleSe.chargerIdAr_selonNom(nomAr);
                        int idAr = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0]);

                        string statut = "actif";

                        // méthode d'ajout de service.
                        if (Controleur.VmodeleI.AjoutInscrit(tbNom.Text, tbPrenom.Text, dtpNaiss.Value, tbMail.Text, Convert.ToInt32(tbTel.Text), password, Convert.ToInt32(tbCredit.Text), statut, idDe, idAr))
                        {
                            //on récupère le nom de l'utilisateur ajouté dans la bdd
                            string NomUser = tbNom.Text;

                            //sur le ok du messageBox, on refresh le form
                            DialogResult dialogResult = MessageBox.Show("Inscrit " + NomUser + " ajouté.", "INFORMATIONS", MessageBoxButtons.OK);
                            if (dialogResult == DialogResult.OK)
                            {
                                BtnAnnuler_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERREUR D'INSERTION DANS LA BDD");
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez saisir les mêmes mot de passe");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez saisir toutes les informations");
                }



            }
            else //on remplit les composants pour pouvoir les changer.
            {
                // condition pour ajouter un service
                if (tbNom.Text != "" && tbPrenom.Text != "" && tbMdp.Text != "" && tbMail.Text != "")
                {
                    //si les mots de passes sont identiques
                    if (tbMdp.Text == tbConfMdp.Text)
                    {
                        //hash du mot de passe
                        string password = tbMdp.Text;
                        string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
                        password = BCrypt.Net.BCrypt.HashPassword(password, mySalt);

                        //recup de l'id du département choisi.
                        string nomDe = Convert.ToString(cbDepartement.SelectedIndex);
                        Controleur.VmodeleSe.chargerIdDe_selonNom(nomDe);
                        int idDe = Convert.ToInt32(Controleur.VmodeleC.DT[3].Rows[0]);

                        //recup de l'id du département choisi.
                        string nomAr = Convert.ToString(cbArrondissement.SelectedIndex);
                        Controleur.VmodeleSe.chargerIdAr_selonNom(nomAr);
                        int idAr = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0]);

                        string statut = "actif";

                        // méthode d'ajout de service.
                        if (Controleur.VmodeleI.modificationInscrit(tbNom.Text, tbPrenom.Text, dtpNaiss.Value, tbMail.Text, Convert.ToInt32(tbTel.Text), password, Convert.ToInt32(tbCredit.Text), statut, idDe, idAr))
                        {
                            //on récupère le nom de l'utilisateur ajouté dans la bdd
                            string NomUser = tbNom.Text;

                            //sur le ok du messageBox, on refresh le form
                            DialogResult dialogResult = MessageBox.Show("Inscrit " + NomUser + " Modifier.", "INFORMATIONS", MessageBoxButtons.OK);
                            if (dialogResult == DialogResult.OK)
                            {
                                BtnAnnuler_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERREUR D'INSERTION DANS LA BDD");
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez saisir les mêmes mot de passe");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez saisir toutes les informations");
                }
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
