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
    public partial class FormOutilServices : Form
    {
        private int id = -1; // -1 = ajout
        public FormOutilServices(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormOutilServices_Load(object sender, EventArgs e)
        {
            Controleur.initService();
            Controleur.initInscrit();
            Controleur.VmodeleI.chargerInscrit();
            Controleur.VmodeleSe.charger_Departement();

            if (id == -1)
            {
                btnAjoutModif.Text = "Ajout";
            }
            else
                btnAjoutModif.Text = "Modifier";


            cbArrondissement.Visible = false;
            labelAr.Visible = false;
            chargerComboBoxInscrits();
            chargerComboBoxDepartement();
        }

        private void btnAjoutModif_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                // condition pour ajouter un service
                if (tbLibelle.Text != "" && tbDescription.Text != "")
                {
                    bool visible = true;

                    //recup de l'id de l'inscrit choisi.
                    string nomI = Convert.ToString(cbInscrit.SelectedItem);
                    Controleur.VmodeleI.chargerIdInscrit_selonNom(nomI);
                    int idInscrit = Convert.ToInt32(Controleur.VmodeleC.DT[22].Rows[0][0]);

                    //recup de l'id du département choisi.
                    string nomDe = Convert.ToString(cbDepartement.SelectedItem);
                    Controleur.VmodeleSe.chargerIdDe_selonNom(nomDe);
                    int idDe = Convert.ToInt32(Controleur.VmodeleC.DT[3].Rows[0][0]);

                    //recup de l'id du département choisi.
                    string nomAr = Convert.ToString(cbArrondissement.SelectedItem);
                    Controleur.VmodeleSe.chargerIdAr_selonNom(nomAr);
                    int idAr = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0][0]);

                    bool recherche = checkBoxRecherche.Checked;
                    // méthode d'ajout de service.
                    if (Controleur.VmodeleSe.AjoutService(tbLibelle.Text, tbDescription.Text, recherche, visible, idInscrit, idDe, idAr))
                    {
                        // recupérer l'IDFORMATION 
                        // récupération de la dernière formation ajoutée pour avoir son id
                        Controleur.VmodeleSe.charger_Service();
                        Controleur.VmodeleI.chargerInscrit_selonSe();

                        string idI = Convert.ToString(Controleur.VmodeleC.DT[21].Rows[0]);
                        int idS = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[Controleur.VmodeleC.DT[1].Rows.Count - 1]["IDSERVICE"]);
                        MessageBox.Show("Service ajoutée n° " + idS + " Inscrit lié : " + idI);


                    }
                }
                else
                {
                    MessageBox.Show("ERREUR : Vous devez saisir au moins un libellé et un identifiant Video", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //on remplit les composants pour pouvoir les changer.
            {
                // vérifier que le libellé et le lien video sont renseignés au minimum
                if (tbLibelle.Text != "" && tbDescription.Text != "")
                {
                    bool visible = true;

                    //recup de l'id de l'inscrit choisi.
                    string nomI = Convert.ToString(cbInscrit.SelectedItem);
                    Controleur.VmodeleI.chargerIdInscrit_selonNom(nomI);
                    int idInscrit = Convert.ToInt32(Controleur.VmodeleC.DT[22].Rows[0][0]);

                    //recup de l'id du département choisi.
                    string nomDe = Convert.ToString(cbDepartement.SelectedItem);
                    Controleur.VmodeleSe.chargerIdDe_selonNom(nomDe);
                    int idDe = Convert.ToInt32(Controleur.VmodeleC.DT[3].Rows[0][0]);

                    //recup de l'id du département choisi.
                    string nomAr = Convert.ToString(cbArrondissement.SelectedItem);
                    Controleur.VmodeleSe.chargerIdAr_selonNom(nomAr);
                    int idAr = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0][0]);

                    // enregistrement de la question en lien avec le thème et niveau
                    if (Controleur.VmodeleSe.modificationService(tbLibelle.Text, tbDescription.Text, checkBoxRecherche.Checked, visible, idInscrit, idDe, idAr))
                    {
                        DialogResult dialogResult = MessageBox.Show("La formation à bien été modifié", "INFORMATIONS", MessageBoxButtons.OK);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbLibelle.Clear();
            tbDescription.Clear();
            checkBoxRecherche.Checked = false;
            tbLibelle.Focus();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chargerComboBoxInscrits()
        {
            cbInscrit.Items.Clear();
            if (Controleur.VmodeleC.DT[20].Rows.Count == 0)
            {
                cbInscrit.Items.Add("Pas d'inscrits en base");
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[20].Rows.Count; i++)
                {
                    cbInscrit.Items.Add(Controleur.VmodeleC.DT[20].Rows[i]["NOM"].ToString());
                }
            }
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
            // recup du libelle selectionné
            string idDe = Convert.ToString(cbDepartement.SelectedItem);
            // chargement de l'id en fonction du nom
            Controleur.VmodeleSe.chargerIdDe_selonNom(idDe);
            // recup de l'id
            int idDepartement = Convert.ToInt32(Controleur.VmodeleC.DT[3].Rows[0][0]);
            //chargement des arrondissement en fonction de l'id departement
            Controleur.VmodeleSe.charger_ArrondissementSelonDepartement(idDepartement);
            if (cbDepartement.SelectedIndex != -1)
            {
                if (Controleur.VmodeleC.DT[2].Rows.Count == 0)
                {
                    cbArrondissement.Items.Add("il n'y a rien en base");
                }
                else
                {
                    // 
                    for (int i = 0; i < Controleur.VmodeleC.DT[2].Rows.Count; i++)
                    {
                        cbArrondissement.Items.Add(Controleur.VmodeleC.DT[2].Rows[i]["NOM"].ToString());
                    }
                }

            }
        }
    }
}