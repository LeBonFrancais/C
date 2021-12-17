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
    public partial class FormInscrits : Form
    {
        public FormInscrits()
        {
            InitializeComponent();
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            FormOutilInscrits formOutilInscrits = new FormOutilInscrits(1);
            formOutilInscrits.Show();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormInscrits_Load(object sender, EventArgs e)
        {

        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            FormOutilInscrits formOutilInscrits = new FormOutilInscrits(-1);
            formOutilInscrits.Show();
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer cet inscrit?", "AVERTISSEMENT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //appel de la methode dans le modeleFormation qui supprime en cascade toutes les infos liées à l'id selectionné.
                if (Controleur.VmodeleI.supprimerFormation(Convert.ToInt32(dgvServices.CurrentRow.Cells[0].Value)))
                {
                    FormInscrits_Load(sender, e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                FormInscrits_Load(sender, e);
            }
        }
    }
}
