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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Controleur.VmodeleSe.ValiderService(Convert.ToInt32(dgvServices.CurrentRow.Cells[0].Value)))
            {
                DialogResult dialogResult = MessageBox.Show("Le commentaire n'est donc pas validé.", "INFORMATION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FormServices_Load(sender, e);
                }
            }
        }


        private void FormServices_Load(object sender, EventArgs e)
        {

        }

        private void btnPasValider_Click(object sender, EventArgs e)
        {
            if (Controleur.VmodeleSe.PasValiderService(Convert.ToInt32(dgvServices.CurrentRow.Cells[0].Value)))
            {
                DialogResult dialogResult = MessageBox.Show("Le commentaire est bien validé.", "INFORMATION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FormServices_Load(sender, e);
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            FormOutilServices formOutilServices = new FormOutilServices(-1);
            formOutilServices.Show();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            FormOutilServices formOutilServices = new FormOutilServices(1);
            formOutilServices.Show();
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer cette Formation?", "AVERTISSEMENT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //appel de la methode dans le modeleFormation qui supprime en cascade toutes les infos liées à l'id selectionné.
                if (Controleur.VmodeleSe.supprimerService(Convert.ToInt32(dgvServices.CurrentRow.Cells[0].Value)))
                {
                    FormServices_Load(sender, e);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                FormServices_Load(sender, e);
            }
        }
    }
}
