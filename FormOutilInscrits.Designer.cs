
namespace Lebonfrancais.service
{
    partial class FormOutilInscrits
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
            this.labelAr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjoutModif = new System.Windows.Forms.Button();
            this.cbArrondissement = new System.Windows.Forms.ComboBox();
            this.cbDepartement = new System.Windows.Forms.ComboBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dtpNaiss = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConfMdp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAr
            // 
            this.labelAr.AutoSize = true;
            this.labelAr.Location = new System.Drawing.Point(114, 533);
            this.labelAr.Name = "labelAr";
            this.labelAr.Size = new System.Drawing.Size(79, 13);
            this.labelAr.TabIndex = 29;
            this.labelAr.Text = "Arrondissement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Departement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "nom";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(336, 595);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 23;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(216, 595);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnAjoutModif
            // 
            this.btnAjoutModif.Location = new System.Drawing.Point(92, 595);
            this.btnAjoutModif.Name = "btnAjoutModif";
            this.btnAjoutModif.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutModif.TabIndex = 21;
            this.btnAjoutModif.UseVisualStyleBackColor = true;
            this.btnAjoutModif.Click += new System.EventHandler(this.BtnAjoutModif_Click);
            // 
            // cbArrondissement
            // 
            this.cbArrondissement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrondissement.FormattingEnabled = true;
            this.cbArrondissement.Location = new System.Drawing.Point(228, 525);
            this.cbArrondissement.Name = "cbArrondissement";
            this.cbArrondissement.Size = new System.Drawing.Size(121, 21);
            this.cbArrondissement.TabIndex = 20;
            // 
            // cbDepartement
            // 
            this.cbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartement.FormattingEnabled = true;
            this.cbDepartement.Location = new System.Drawing.Point(228, 477);
            this.cbDepartement.Name = "cbDepartement";
            this.cbDepartement.Size = new System.Drawing.Size(121, 21);
            this.cbDepartement.TabIndex = 19;
            this.cbDepartement.SelectedIndexChanged += new System.EventHandler(this.CbDepartement_SelectedIndexChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(239, 145);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 16;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(239, 83);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 15;
            // 
            // dtpNaiss
            // 
            this.dtpNaiss.Location = new System.Drawing.Point(239, 203);
            this.dtpNaiss.Name = "dtpNaiss";
            this.dtpNaiss.Size = new System.Drawing.Size(200, 20);
            this.dtpNaiss.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(239, 243);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 20);
            this.tbMail.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tel";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(239, 285);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 20);
            this.tbTel.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mdp";
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(239, 334);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(100, 20);
            this.tbMdp.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Confirmer mdp";
            // 
            // tbConfMdp
            // 
            this.tbConfMdp.Location = new System.Drawing.Point(239, 374);
            this.tbConfMdp.Name = "tbConfMdp";
            this.tbConfMdp.Size = new System.Drawing.Size(100, 20);
            this.tbConfMdp.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Crédit";
            // 
            // tbCredit
            // 
            this.tbCredit.Location = new System.Drawing.Point(239, 425);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(100, 20);
            this.tbCredit.TabIndex = 40;
            // 
            // FormOutilInscrits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 691);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCredit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbConfMdp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNaiss);
            this.Controls.Add(this.labelAr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjoutModif);
            this.Controls.Add(this.cbArrondissement);
            this.Controls.Add(this.cbDepartement);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Name = "FormOutilInscrits";
            this.Text = "FormOutilInscrits";
            this.Load += new System.EventHandler(this.FormOutilInscrits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjoutModif;
        private System.Windows.Forms.ComboBox cbArrondissement;
        private System.Windows.Forms.ComboBox cbDepartement;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DateTimePicker dtpNaiss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConfMdp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCredit;
    }
}