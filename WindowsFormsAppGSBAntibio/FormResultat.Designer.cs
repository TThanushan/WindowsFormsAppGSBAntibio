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
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblLibelleG = new System.Windows.Forms.Label();
            this.lblUnite = new System.Windows.Forms.Label();
            this.lblNbParJour = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoseMoy = new System.Windows.Forms.Label();
            this.txtDoseMoyEntree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnvoyerMail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
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
            this.lstResultat.Size = new System.Drawing.Size(213, 134);
            this.lstResultat.TabIndex = 1;
            this.lstResultat.SelectedIndexChanged += new System.EventHandler(this.lstResultat_SelectedIndexChanged);
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.BackColor = System.Drawing.SystemColors.Control;
            this.lblPoids.Location = new System.Drawing.Point(256, 181);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(39, 13);
            this.lblPoids.TabIndex = 8;
            this.lblPoids.Text = "Poids :";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(301, 178);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(170, 20);
            this.txtPoids.TabIndex = 7;
            this.txtPoids.TextChanged += new System.EventHandler(this.txtPoids_TextChanged);
            this.txtPoids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoids_KeyPress);
            // 
            // lblDoseResultat
            // 
            this.lblDoseResultat.AutoSize = true;
            this.lblDoseResultat.BackColor = System.Drawing.SystemColors.Control;
            this.lblDoseResultat.Location = new System.Drawing.Point(257, 215);
            this.lblDoseResultat.Name = "lblDoseResultat";
            this.lblDoseResultat.Size = new System.Drawing.Size(38, 13);
            this.lblDoseResultat.TabIndex = 9;
            this.lblDoseResultat.Text = "Dose :";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.BackColor = System.Drawing.SystemColors.Control;
            this.lblLibelle.Location = new System.Drawing.Point(257, 46);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 10;
            this.lblLibelle.Text = "Libelle :";
            // 
            // lblLibelleG
            // 
            this.lblLibelleG.AutoSize = true;
            this.lblLibelleG.BackColor = System.Drawing.SystemColors.Control;
            this.lblLibelleG.Location = new System.Drawing.Point(257, 72);
            this.lblLibelleG.Name = "lblLibelleG";
            this.lblLibelleG.Size = new System.Drawing.Size(51, 13);
            this.lblLibelleG.TabIndex = 11;
            this.lblLibelleG.Text = "LibelleG :";
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.BackColor = System.Drawing.SystemColors.Control;
            this.lblUnite.Location = new System.Drawing.Point(257, 105);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(38, 13);
            this.lblUnite.TabIndex = 12;
            this.lblUnite.Text = "Unite :";
            // 
            // lblNbParJour
            // 
            this.lblNbParJour.AutoSize = true;
            this.lblNbParJour.BackColor = System.Drawing.SystemColors.Control;
            this.lblNbParJour.Location = new System.Drawing.Point(257, 136);
            this.lblNbParJour.Name = "lblNbParJour";
            this.lblNbParJour.Size = new System.Drawing.Size(88, 13);
            this.lblNbParJour.TabIndex = 13;
            this.lblNbParJour.Text = "Nombre par jour :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(113, 208);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(130, 20);
            this.txtRecherche.TabIndex = 14;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Recherche :";
            // 
            // lblDoseMoy
            // 
            this.lblDoseMoy.AutoSize = true;
            this.lblDoseMoy.BackColor = System.Drawing.SystemColors.Control;
            this.lblDoseMoy.Location = new System.Drawing.Point(27, 374);
            this.lblDoseMoy.Name = "lblDoseMoy";
            this.lblDoseMoy.Size = new System.Drawing.Size(84, 13);
            this.lblDoseMoy.TabIndex = 16;
            this.lblDoseMoy.Text = "Dose moyenne :";
            this.lblDoseMoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDoseMoyEntree
            // 
            this.txtDoseMoyEntree.Location = new System.Drawing.Point(148, 329);
            this.txtDoseMoyEntree.Name = "txtDoseMoyEntree";
            this.txtDoseMoyEntree.Size = new System.Drawing.Size(95, 20);
            this.txtDoseMoyEntree.TabIndex = 17;
            this.txtDoseMoyEntree.TextChanged += new System.EventHandler(this.txtDoseMoyEntree_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unite doses moyenne :";
            // 
            // btnEnvoyerMail
            // 
            this.btnEnvoyerMail.Location = new System.Drawing.Point(396, 280);
            this.btnEnvoyerMail.Name = "btnEnvoyerMail";
            this.btnEnvoyerMail.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyerMail.TabIndex = 19;
            this.btnEnvoyerMail.Text = "Envoyer";
            this.btnEnvoyerMail.UseVisualStyleBackColor = true;
            this.btnEnvoyerMail.Visible = false;
            this.btnEnvoyerMail.Click += new System.EventHandler(this.btnEnvoyerMail_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Envoyer la posologie au mail : ";
            this.label4.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(198, 282);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(170, 20);
            this.txtMail.TabIndex = 21;
            this.txtMail.Visible = false;
            // 
            // frmResultatRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 469);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnvoyerMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoseMoyEntree);
            this.Controls.Add(this.lblDoseMoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblNbParJour);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.lblLibelleG);
            this.Controls.Add(this.lblLibelle);
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
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblLibelleG;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.Label lblNbParJour;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoseMoy;
        private System.Windows.Forms.TextBox txtDoseMoyEntree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnvoyerMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
    }
}