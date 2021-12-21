
namespace Lebonfrancais.service
{
    partial class FormServices
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnPasValider = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSuppr);
            this.splitContainer1.Panel1.Controls.Add(this.btnPasValider);
            this.splitContainer1.Panel1.Controls.Add(this.btnValider);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjout);
            this.splitContainer1.Panel1.Controls.Add(this.btnModif);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvServices);
            this.splitContainer1.Size = new System.Drawing.Size(1307, 592);
            this.splitContainer1.SplitterDistance = 435;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSuppr
            // 

            this.btnSuppr.Location = new System.Drawing.Point(299, 543);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(100, 28);
            this.btnSuppr.TabIndex = 4;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnPasValider
            // 
            this.btnPasValider.Location = new System.Drawing.Point(153, 466);
            this.btnPasValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasValider.Name = "btnPasValider";
            this.btnPasValider.Size = new System.Drawing.Size(144, 42);

            this.btnPasValider.TabIndex = 3;
            this.btnPasValider.Text = "ne Pas Valider";
            this.btnPasValider.UseVisualStyleBackColor = true;
            this.btnPasValider.Click += new System.EventHandler(this.btnPasValider_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(35, 473);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 28);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAjout
            // 

            this.btnAjout.Location = new System.Drawing.Point(153, 544);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(100, 28);

            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 

            this.btnModif.Location = new System.Drawing.Point(20, 543);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(100, 28);

            this.btnModif.TabIndex = 0;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvServices.Location = new System.Drawing.Point(4, 4);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.Size = new System.Drawing.Size(863, 588);

            this.dgvServices.TabIndex = 0;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 592);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormServices";
            this.Text = "FormServices";
            this.Load += new System.EventHandler(this.FormServices_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnPasValider;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.DataGridView dgvServices;
    }
}