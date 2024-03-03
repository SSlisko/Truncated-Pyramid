namespace Pyramidenstumpf
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.txtDeckseiteA = new System.Windows.Forms.TextBox();
            this.txtDeckseiteB = new System.Windows.Forms.TextBox();
            this.txtHoehe = new System.Windows.Forms.TextBox();
            this.txtBasisseiteB = new System.Windows.Forms.TextBox();
            this.txtBasisseiteA = new System.Windows.Forms.TextBox();
            this.lblDeckseiteA = new System.Windows.Forms.Label();
            this.lblDeckseiteB = new System.Windows.Forms.Label();
            this.lblBasisseiteA = new System.Windows.Forms.Label();
            this.lblBasisseiteB = new System.Windows.Forms.Label();
            this.lblHoehe = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnRechnen = new System.Windows.Forms.Button();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblManteflaeche = new System.Windows.Forms.Label();
            this.lblBasisflaecheAB = new System.Windows.Forms.Label();
            this.lblBasisflaecheAB2 = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.txtManteflaeche = new System.Windows.Forms.TextBox();
            this.txtBasisflaecheAB = new System.Windows.Forms.TextBox();
            this.txtBasisflaecheAB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pyramidenstumpf berechnen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.BackColor = System.Drawing.Color.Red;
            this.btnLoeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoeschen.ForeColor = System.Drawing.Color.White;
            this.btnLoeschen.Location = new System.Drawing.Point(238, 99);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(269, 45);
            this.btnLoeschen.TabIndex = 1;
            this.btnLoeschen.Text = "Einträge löschen";
            this.btnLoeschen.UseVisualStyleBackColor = false;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // txtDeckseiteA
            // 
            this.txtDeckseiteA.Location = new System.Drawing.Point(238, 195);
            this.txtDeckseiteA.Name = "txtDeckseiteA";
            this.txtDeckseiteA.Size = new System.Drawing.Size(269, 26);
            this.txtDeckseiteA.TabIndex = 2;
            // 
            // txtDeckseiteB
            // 
            this.txtDeckseiteB.Location = new System.Drawing.Point(238, 227);
            this.txtDeckseiteB.Name = "txtDeckseiteB";
            this.txtDeckseiteB.Size = new System.Drawing.Size(269, 26);
            this.txtDeckseiteB.TabIndex = 3;
            // 
            // txtHoehe
            // 
            this.txtHoehe.Location = new System.Drawing.Point(238, 323);
            this.txtHoehe.Name = "txtHoehe";
            this.txtHoehe.Size = new System.Drawing.Size(269, 26);
            this.txtHoehe.TabIndex = 5;
            // 
            // txtBasisseiteB
            // 
            this.txtBasisseiteB.Location = new System.Drawing.Point(238, 291);
            this.txtBasisseiteB.Name = "txtBasisseiteB";
            this.txtBasisseiteB.Size = new System.Drawing.Size(269, 26);
            this.txtBasisseiteB.TabIndex = 6;
            // 
            // txtBasisseiteA
            // 
            this.txtBasisseiteA.Location = new System.Drawing.Point(238, 259);
            this.txtBasisseiteA.Name = "txtBasisseiteA";
            this.txtBasisseiteA.Size = new System.Drawing.Size(269, 26);
            this.txtBasisseiteA.TabIndex = 7;
            // 
            // lblDeckseiteA
            // 
            this.lblDeckseiteA.AutoSize = true;
            this.lblDeckseiteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDeckseiteA.Location = new System.Drawing.Point(18, 196);
            this.lblDeckseiteA.Name = "lblDeckseiteA";
            this.lblDeckseiteA.Size = new System.Drawing.Size(93, 20);
            this.lblDeckseiteA.TabIndex = 8;
            this.lblDeckseiteA.Text = "Deckseite a";
            // 
            // lblDeckseiteB
            // 
            this.lblDeckseiteB.AutoSize = true;
            this.lblDeckseiteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDeckseiteB.Location = new System.Drawing.Point(18, 227);
            this.lblDeckseiteB.Name = "lblDeckseiteB";
            this.lblDeckseiteB.Size = new System.Drawing.Size(93, 20);
            this.lblDeckseiteB.TabIndex = 9;
            this.lblDeckseiteB.Text = "Deckseite b";
            // 
            // lblBasisseiteA
            // 
            this.lblBasisseiteA.AutoSize = true;
            this.lblBasisseiteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBasisseiteA.Location = new System.Drawing.Point(18, 256);
            this.lblBasisseiteA.Name = "lblBasisseiteA";
            this.lblBasisseiteA.Size = new System.Drawing.Size(97, 20);
            this.lblBasisseiteA.TabIndex = 10;
            this.lblBasisseiteA.Text = "Basisseite A";
            // 
            // lblBasisseiteB
            // 
            this.lblBasisseiteB.AutoSize = true;
            this.lblBasisseiteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBasisseiteB.Location = new System.Drawing.Point(18, 287);
            this.lblBasisseiteB.Name = "lblBasisseiteB";
            this.lblBasisseiteB.Size = new System.Drawing.Size(97, 20);
            this.lblBasisseiteB.TabIndex = 11;
            this.lblBasisseiteB.Text = "Basisseite B";
            // 
            // lblHoehe
            // 
            this.lblHoehe.AutoSize = true;
            this.lblHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHoehe.Location = new System.Drawing.Point(18, 320);
            this.lblHoehe.Name = "lblHoehe";
            this.lblHoehe.Size = new System.Drawing.Size(61, 20);
            this.lblHoehe.TabIndex = 12;
            this.lblHoehe.Text = "Höhe h";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BackColor = System.Drawing.Color.Silver;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultat.Location = new System.Drawing.Point(12, 449);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(82, 25);
            this.lblResultat.TabIndex = 13;
            this.lblResultat.Text = "Resultat";
            // 
            // btnRechnen
            // 
            this.btnRechnen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRechnen.ForeColor = System.Drawing.Color.White;
            this.btnRechnen.Location = new System.Drawing.Point(374, 375);
            this.btnRechnen.Name = "btnRechnen";
            this.btnRechnen.Size = new System.Drawing.Size(133, 66);
            this.btnRechnen.TabIndex = 14;
            this.btnRechnen.Text = "Rechnen";
            this.btnRechnen.UseVisualStyleBackColor = false;
            this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVolumen.Location = new System.Drawing.Point(13, 508);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(87, 20);
            this.lblVolumen.TabIndex = 15;
            this.lblVolumen.Text = "Volumen V";
            // 
            // lblManteflaeche
            // 
            this.lblManteflaeche.AutoSize = true;
            this.lblManteflaeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblManteflaeche.Location = new System.Drawing.Point(13, 552);
            this.lblManteflaeche.Name = "lblManteflaeche";
            this.lblManteflaeche.Size = new System.Drawing.Size(115, 20);
            this.lblManteflaeche.TabIndex = 16;
            this.lblManteflaeche.Text = "Mantelfläche A";
            // 
            // lblBasisflaecheAB
            // 
            this.lblBasisflaecheAB.AutoSize = true;
            this.lblBasisflaecheAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBasisflaecheAB.Location = new System.Drawing.Point(14, 596);
            this.lblBasisflaecheAB.Name = "lblBasisflaecheAB";
            this.lblBasisflaecheAB.Size = new System.Drawing.Size(117, 20);
            this.lblBasisflaecheAB.TabIndex = 17;
            this.lblBasisflaecheAB.Text = "Basisfläche AB";
            // 
            // lblBasisflaecheAB2
            // 
            this.lblBasisflaecheAB2.AutoSize = true;
            this.lblBasisflaecheAB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBasisflaecheAB2.Location = new System.Drawing.Point(15, 640);
            this.lblBasisflaecheAB2.Name = "lblBasisflaecheAB2";
            this.lblBasisflaecheAB2.Size = new System.Drawing.Size(113, 20);
            this.lblBasisflaecheAB2.TabIndex = 18;
            this.lblBasisflaecheAB2.Text = "Basisfläche ab";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(278, 505);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(229, 26);
            this.txtVolumen.TabIndex = 23;
            // 
            // txtManteflaeche
            // 
            this.txtManteflaeche.Location = new System.Drawing.Point(278, 546);
            this.txtManteflaeche.Name = "txtManteflaeche";
            this.txtManteflaeche.Size = new System.Drawing.Size(229, 26);
            this.txtManteflaeche.TabIndex = 24;
            // 
            // txtBasisflaecheAB
            // 
            this.txtBasisflaecheAB.Location = new System.Drawing.Point(278, 590);
            this.txtBasisflaecheAB.Name = "txtBasisflaecheAB";
            this.txtBasisflaecheAB.Size = new System.Drawing.Size(229, 26);
            this.txtBasisflaecheAB.TabIndex = 25;
            // 
            // txtBasisflaecheAB2
            // 
            this.txtBasisflaecheAB2.Location = new System.Drawing.Point(278, 634);
            this.txtBasisflaecheAB2.Name = "txtBasisflaecheAB2";
            this.txtBasisflaecheAB2.Size = new System.Drawing.Size(229, 26);
            this.txtBasisflaecheAB2.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 703);
            this.Controls.Add(this.txtBasisflaecheAB2);
            this.Controls.Add(this.txtBasisflaecheAB);
            this.Controls.Add(this.txtManteflaeche);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblBasisflaecheAB2);
            this.Controls.Add(this.lblBasisflaecheAB);
            this.Controls.Add(this.lblManteflaeche);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.btnRechnen);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblHoehe);
            this.Controls.Add(this.lblBasisseiteB);
            this.Controls.Add(this.lblBasisseiteA);
            this.Controls.Add(this.lblDeckseiteB);
            this.Controls.Add(this.lblDeckseiteA);
            this.Controls.Add(this.txtBasisseiteA);
            this.Controls.Add(this.txtBasisseiteB);
            this.Controls.Add(this.txtHoehe);
            this.Controls.Add(this.txtDeckseiteB);
            this.Controls.Add(this.txtDeckseiteA);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.TextBox txtDeckseiteA;
        private System.Windows.Forms.TextBox txtDeckseiteB;
        private System.Windows.Forms.TextBox txtHoehe;
        private System.Windows.Forms.TextBox txtBasisseiteB;
        private System.Windows.Forms.TextBox txtBasisseiteA;
        private System.Windows.Forms.Label lblDeckseiteA;
        private System.Windows.Forms.Label lblDeckseiteB;
        private System.Windows.Forms.Label lblBasisseiteA;
        private System.Windows.Forms.Label lblBasisseiteB;
        private System.Windows.Forms.Label lblHoehe;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnRechnen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblManteflaeche;
        private System.Windows.Forms.Label lblBasisflaecheAB;
        private System.Windows.Forms.Label lblBasisflaecheAB2;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.TextBox txtManteflaeche;
        private System.Windows.Forms.TextBox txtBasisflaecheAB;
        private System.Windows.Forms.TextBox txtBasisflaecheAB2;
    }
}

