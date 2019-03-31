namespace WindowsFormsAppGSBAntibio
{
    partial class frmResultatRecherche
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResultat = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.lblDoseResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultat";
            // 
            // lstResultat
            // 
            this.lstResultat.FormattingEnabled = true;
            this.lstResultat.Location = new System.Drawing.Point(30, 46);
            this.lstResultat.Name = "lstResultat";
            this.lstResultat.Size = new System.Drawing.Size(213, 199);
            this.lstResultat.TabIndex = 1;
            this.lstResultat.SelectedIndexChanged += new System.EventHandler(this.lstResultat_SelectedIndexChanged);
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.BackColor = System.Drawing.SystemColors.Control;
            this.lblPoids.Location = new System.Drawing.Point(262, 49);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(39, 13);
            this.lblPoids.TabIndex = 8;
            this.lblPoids.Text = "Poids :";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(307, 46);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(121, 20);
            this.txtPoids.TabIndex = 7;
            this.txtPoids.TextChanged += new System.EventHandler(this.txtPoids_TextChanged);
            // 
            // lblDoseResultat
            // 
            this.lblDoseResultat.AutoSize = true;
            this.lblDoseResultat.BackColor = System.Drawing.SystemColors.Control;
            this.lblDoseResultat.Location = new System.Drawing.Point(262, 98);
            this.lblDoseResultat.Name = "lblDoseResultat";
            this.lblDoseResultat.Size = new System.Drawing.Size(38, 13);
            this.lblDoseResultat.TabIndex = 9;
            this.lblDoseResultat.Text = "Dose :";
            // 
            // frmResultatRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 279);
            this.Controls.Add(this.lblDoseResultat);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.lstResultat);
            this.Controls.Add(this.label1);
            this.Name = "frmResultatRecherche";
            this.Text = "Prescription d\'antibiotiques : Recherche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResultat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label lblDoseResultat;
    }
}