
namespace Lebonfrancais.service
{
    partial class FormOutilServices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.checkBoxRecherche = new System.Windows.Forms.CheckBox();
            this.cbInscrit = new System.Windows.Forms.ComboBox();
            this.cbDepartement = new System.Windows.Forms.ComboBox();
            this.cbArrondissement = new System.Windows.Forms.ComboBox();
            this.btnAjoutModif = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(191, 140);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(100, 20);
            this.tbLibelle.TabIndex = 0;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(191, 202);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 1;
            // 
            // checkBoxRecherche
            // 
            this.checkBoxRecherche.AutoSize = true;
            this.checkBoxRecherche.Location = new System.Drawing.Point(276, 259);
            this.checkBoxRecherche.Name = "checkBoxRecherche";
            this.checkBoxRecherche.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRecherche.TabIndex = 2;
            this.checkBoxRecherche.UseVisualStyleBackColor = true;
            // 
            // cbInscrit
            // 
            this.cbInscrit.FormattingEnabled = true;
            this.cbInscrit.Location = new System.Drawing.Point(170, 335);
            this.cbInscrit.Name = "cbInscrit";
            this.cbInscrit.Size = new System.Drawing.Size(121, 21);
            this.cbInscrit.TabIndex = 3;
            // 
            // cbDepartement
            // 
            this.cbDepartement.FormattingEnabled = true;
            this.cbDepartement.Location = new System.Drawing.Point(170, 387);
            this.cbDepartement.Name = "cbDepartement";
            this.cbDepartement.Size = new System.Drawing.Size(121, 21);
            this.cbDepartement.TabIndex = 4;
            // 
            // cbArrondissement
            // 
            this.cbArrondissement.FormattingEnabled = true;
            this.cbArrondissement.Location = new System.Drawing.Point(170, 435);
            this.cbArrondissement.Name = "cbArrondissement";
            this.cbArrondissement.Size = new System.Drawing.Size(121, 21);
            this.cbArrondissement.TabIndex = 5;
            // 
            // btnAjoutModif
            // 
            this.btnAjoutModif.Location = new System.Drawing.Point(46, 503);
            this.btnAjoutModif.Name = "btnAjoutModif";
            this.btnAjoutModif.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutModif.TabIndex = 6;
            this.btnAjoutModif.UseVisualStyleBackColor = true;
            this.btnAjoutModif.Click += new System.EventHandler(this.btnAjoutModif_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(170, 503);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(290, 503);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormOutilServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 579);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjoutModif);
            this.Controls.Add(this.cbArrondissement);
            this.Controls.Add(this.cbDepartement);
            this.Controls.Add(this.cbInscrit);
            this.Controls.Add(this.checkBoxRecherche);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbLibelle);
            this.Name = "FormOutilServices";
            this.Text = "FormOutilServices";
            this.Load += new System.EventHandler(this.FormOutilServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.CheckBox checkBoxRecherche;
        private System.Windows.Forms.ComboBox cbInscrit;
        private System.Windows.Forms.ComboBox cbDepartement;
        private System.Windows.Forms.ComboBox cbArrondissement;
        private System.Windows.Forms.Button btnAjoutModif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
    }
}