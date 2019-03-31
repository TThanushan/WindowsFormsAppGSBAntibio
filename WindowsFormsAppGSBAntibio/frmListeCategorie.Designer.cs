namespace WindowsFormsAppGSBAntibio
{
    partial class frmListeCategorie
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstCategorie = new System.Windows.Forms.ListBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir la catégorie d\'antibiotique :";
            // 
            // lstCategorie
            // 
            this.lstCategorie.FormattingEnabled = true;
            this.lstCategorie.Location = new System.Drawing.Point(50, 66);
            this.lstCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.lstCategorie.Name = "lstCategorie";
            this.lstCategorie.Size = new System.Drawing.Size(165, 134);
            this.lstCategorie.TabIndex = 1;
            this.lstCategorie.SelectedIndexChanged += new System.EventHandler(this.lstCategorie_SelectedIndexChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(95, 243);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // frmListeCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 317);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lstCategorie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListeCategorie";
            this.Text = "Prescription d\'antibiotiques";
            this.Load += new System.EventHandler(this.frmListeCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCategorie;
        private System.Windows.Forms.Button btnRechercher;
    }
}

