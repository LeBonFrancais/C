
namespace Lebonfrancais.service
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAdmin = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilInscritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesInscritsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdmin
            // 
            this.tbAdmin.Enabled = false;
            this.tbAdmin.Location = new System.Drawing.Point(700, 27);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Size = new System.Drawing.Size(100, 20);
            this.tbAdmin.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.gestionDesFormationsToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.statistiqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.reconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // reconnecterToolStripMenuItem
            // 
            this.reconnecterToolStripMenuItem.Name = "reconnecterToolStripMenuItem";
            this.reconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reconnecterToolStripMenuItem.Text = "Reconnecter";
            this.reconnecterToolStripMenuItem.Click += new System.EventHandler(this.reconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.BackColor = System.Drawing.Color.DarkRed;
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // gestionDesFormationsToolStripMenuItem
            // 
            this.gestionDesFormationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outilInscritToolStripMenuItem,
            this.outilServicesToolStripMenuItem});
            this.gestionDesFormationsToolStripMenuItem.Name = "gestionDesFormationsToolStripMenuItem";
            this.gestionDesFormationsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.gestionDesFormationsToolStripMenuItem.Text = "Outil";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLesInscritsToolStripMenuItem,
            this.afficherLesServicesToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aideToolStripMenuItem.Text = "Affichage";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            this.statistiqueToolStripMenuItem.Click += new System.EventHandler(this.statistiqueToolStripMenuItem_Click);
            // 
            // outilInscritToolStripMenuItem
            // 
            this.outilInscritToolStripMenuItem.Name = "outilInscritToolStripMenuItem";
            this.outilInscritToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outilInscritToolStripMenuItem.Text = "outil Inscrits";
            this.outilInscritToolStripMenuItem.Click += new System.EventHandler(this.outilInscritToolStripMenuItem_Click);
            // 
            // outilServicesToolStripMenuItem
            // 
            this.outilServicesToolStripMenuItem.Name = "outilServicesToolStripMenuItem";
            this.outilServicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outilServicesToolStripMenuItem.Text = "outil Services";
            this.outilServicesToolStripMenuItem.Click += new System.EventHandler(this.outilServicesToolStripMenuItem_Click);
            // 
            // afficherLesInscritsToolStripMenuItem
            // 
            this.afficherLesInscritsToolStripMenuItem.Name = "afficherLesInscritsToolStripMenuItem";
            this.afficherLesInscritsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherLesInscritsToolStripMenuItem.Text = "afficher les inscrits";
            this.afficherLesInscritsToolStripMenuItem.Click += new System.EventHandler(this.afficherLesInscritsToolStripMenuItem_Click);
            // 
            // afficherLesServicesToolStripMenuItem
            // 
            this.afficherLesServicesToolStripMenuItem.Name = "afficherLesServicesToolStripMenuItem";
            this.afficherLesServicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherLesServicesToolStripMenuItem.Text = "afficher les services";
            this.afficherLesServicesToolStripMenuItem.Click += new System.EventHandler(this.afficherLesServicesToolStripMenuItem_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbAdmin);
            this.Name = "FormPrincipale";
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdmin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilInscritToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesInscritsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
    }
}

