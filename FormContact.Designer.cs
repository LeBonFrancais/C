
namespace Lebonfrancais.service
{
    partial class FormContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContact));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListeInscrits = new System.Windows.Forms.DataGridView();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeInscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des échanges administrateur et utilisateur";
            // 
            // dgvListeInscrits
            // 
            this.dgvListeInscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeInscrits.Location = new System.Drawing.Point(17, 76);
            this.dgvListeInscrits.Name = "dgvListeInscrits";
            this.dgvListeInscrits.Size = new System.Drawing.Size(403, 205);
            this.dgvListeInscrits.TabIndex = 1;
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(449, 76);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(311, 362);
            this.dgvMessages.TabIndex = 2;
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.dgvListeInscrits);
            this.Controls.Add(this.label1);
            this.Name = "FormContact";
            this.Text = "FormContact";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeInscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListeInscrits;
        private System.Windows.Forms.DataGridView dgvMessages;
    }
}