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
            Controleur.initServices();
            if (id == -1)
            {
                btnAjoutModif.Text = "Modifier";
            }
            else
                btnAjoutModif.Text = "Ajout";
        }

        private void btnAjoutModif_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                // vérifier que le libellé et le lien video sont renseignés au minimum
                if (tbLibelle.Text != "" && tbDescription.Text != "")
                {
                    int IdAuteur = Convert.ToInt32(Controleur.VmodeleC.DT[9].Rows[0][0]);
                    // enregistrement de la question en lien avec le thème et niveau
                    if (Controleur.VmodeleSe.AjoutService(tbLibelle.Text, tbDescription.Text, checkBoxRecherche.Checked, cbVisible.Checked, dtpDateV.Value, textBoxImage.Text, IdAuteur))
                    {
                        // recupérer l'IDFORMATION 
                        // récupération de la dernière formation ajoutée pour avoir son id
                        Controleur.VmodeleSe.charger_Service();
                        Controleur.VmodeleSe.chargerService_selonI();
                        string idS = Convert.ToString(Controleur.VmodeleC.DT[8].Rows[0]);
                        int idI = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[Controleur.VmodeleC.DT[1].Rows.Count - 1]["IDSERVICE"]);
                        MessageBox.Show("Formation ajoutée n° " + idS + " par " + idI);

                        
                    }
                }
                else
                {
                    MessageBox.Show("ERREUR : Vous devez saisir au moins un libellé et un identifiant Video", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // vérifier que le libellé et le lien video sont renseignés au minimum
                if (tbLibelle.Text != "" && tbVideo.Text != "")
                {
                    int IdAuteur = Convert.ToInt32(Controleur.VmodeleC.DT[9].Rows[0][0]);
                    int idF = id;
                    // enregistrement de la question en lien avec le thème et niveau
                    if (Controleur.VmodeleSe.modificationService(tbLibelle.Text, tbDescription.Text, tbVideo.Text, cbVisible.Checked, dtpDateV.Value, textBoxImage.Text, IdAuteur, idF))
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
    }
}
