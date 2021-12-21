
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

            this.label6 = new System.Windows.Forms.Label();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConfMdp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.dtpNaiss = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // labelAr
            // 
            this.labelAr.AutoSize = true;

            this.labelAr.Location = new System.Drawing.Point(83, 545);
            this.labelAr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAr.Name = "labelAr";
            this.labelAr.Size = new System.Drawing.Size(107, 17);

            this.labelAr.TabIndex = 29;
            this.labelAr.Text = "Arrondissement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;

            this.label5.Location = new System.Drawing.Point(97, 486);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);

            this.label5.TabIndex = 28;
            this.label5.Text = "Departement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(111, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);


            this.label2.TabIndex = 25;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(111, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);

            this.label1.TabIndex = 24;
            this.label1.Text = "nom";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(395, 619);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 28);

            this.btnFermer.TabIndex = 23;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 

            this.btnAnnuler.Location = new System.Drawing.Point(235, 619);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjoutModif
            // 
            this.btnAjoutModif.Location = new System.Drawing.Point(69, 619);
            this.btnAjoutModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjoutModif.Name = "btnAjoutModif";
            this.btnAjoutModif.Size = new System.Drawing.Size(100, 28);
            this.btnAjoutModif.TabIndex = 9;
            this.btnAjoutModif.UseVisualStyleBackColor = true;
            this.btnAjoutModif.Click += new System.EventHandler(this.btnAjoutModif_Click_1);

            // 
            // cbArrondissement
            // 
            this.cbArrondissement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrondissement.FormattingEnabled = true;

            this.cbArrondissement.Location = new System.Drawing.Point(235, 535);
            this.cbArrondissement.Margin = new System.Windows.Forms.Padding(4);
            this.cbArrondissement.Name = "cbArrondissement";
            this.cbArrondissement.Size = new System.Drawing.Size(160, 24);
            this.cbArrondissement.TabIndex = 61;
            

            // 
            // cbDepartement
            // 
            this.cbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartement.FormattingEnabled = true;

            this.cbDepartement.Location = new System.Drawing.Point(235, 476);
            this.cbDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartement.Name = "cbDepartement";
            this.cbDepartement.Size = new System.Drawing.Size(160, 24);
            this.cbDepartement.TabIndex = 8;
            this.cbDepartement.SelectedIndexChanged += new System.EventHandler(this.cbDepartement_SelectedIndexChanged_1);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(263, 135);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(132, 22);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(263, 58);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(132, 22);
            this.tbNom.TabIndex = 0;

            // 
            // label6
            // 
            this.label6.AutoSize = true;

            this.label6.Location = new System.Drawing.Point(93, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "credit";
            // 
            // tbCredit
            // 
            this.tbCredit.Location = new System.Drawing.Point(245, 430);
            this.tbCredit.Margin = new System.Windows.Forms.Padding(4);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(132, 22);
            this.tbCredit.TabIndex = 7;

            // 
            // label7
            // 
            this.label7.AutoSize = true;

            this.label7.Location = new System.Drawing.Point(37, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "confirmation mot de passe";
            // 
            // tbConfMdp
            // 
            this.tbConfMdp.Location = new System.Drawing.Point(263, 360);
            this.tbConfMdp.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfMdp.Name = "tbConfMdp";
            this.tbConfMdp.Size = new System.Drawing.Size(132, 22);
            this.tbConfMdp.TabIndex = 6;
            this.tbConfMdp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "mot dee passe";
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(263, 301);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(4);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(132, 22);
            this.tbMdp.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "tel";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(263, 245);
            this.tbTel.Margin = new System.Windows.Forms.Padding(4);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(132, 22);
            this.tbTel.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "mail";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(263, 215);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(132, 22);
            this.tbMail.TabIndex = 3;
            // 
            // dtpNaiss
            // 
            this.dtpNaiss.Location = new System.Drawing.Point(195, 186);
            this.dtpNaiss.Name = "dtpNaiss";
            this.dtpNaiss.Size = new System.Drawing.Size(200, 22);
            this.dtpNaiss.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "date de naissance";
            // 
            // FormOutilInscrits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNaiss);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbConfMdp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCredit);

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

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbConfMdp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.DateTimePicker dtpNaiss;
        private System.Windows.Forms.Label label3;

    }
}