﻿namespace SAE___Puissance_4
{
    partial class FormPartiePerso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartiePerso));
            button1 = new Button();
            rbnRandom = new RadioButton();
            rbnJ2IA = new RadioButton();
            rbnJ1 = new RadioButton();
            label5 = new Label();
            lblPseudos = new Label();
            pnlPseudos = new Panel();
            txbJ2 = new TextBox();
            txbJ1 = new TextBox();
            lblJ2 = new Label();
            lblJ1 = new Label();
            panel3 = new Panel();
            rbnNR = new RadioButton();
            rbnJN = new RadioButton();
            rbnRJ = new RadioButton();
            panel2 = new Panel();
            rbnJoueur = new RadioButton();
            rbnIA = new RadioButton();
            panel1 = new Panel();
            rbn9x9 = new RadioButton();
            rbn8x8 = new RadioButton();
            rbn6x7 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            btnRetour = new Button();
            pnlPseudos.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(470, 556);
            button1.Name = "button1";
            button1.Size = new Size(269, 57);
            button1.TabIndex = 26;
            button1.Text = "JOUER !";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbnRandom
            // 
            rbnRandom.AutoSize = true;
            rbnRandom.BackColor = Color.Transparent;
            rbnRandom.Checked = true;
            rbnRandom.ForeColor = SystemColors.Control;
            rbnRandom.Location = new Point(646, 491);
            rbnRandom.Name = "rbnRandom";
            rbnRandom.Size = new Size(91, 24);
            rbnRandom.TabIndex = 25;
            rbnRandom.TabStop = true;
            rbnRandom.Text = "Aléatoire";
            rbnRandom.UseVisualStyleBackColor = false;
            rbnRandom.CheckedChanged += rbnQuiDebute;
            // 
            // rbnJ2IA
            // 
            rbnJ2IA.AutoSize = true;
            rbnJ2IA.BackColor = Color.Transparent;
            rbnJ2IA.ForeColor = SystemColors.Control;
            rbnJ2IA.Location = new Point(382, 491);
            rbnJ2IA.Name = "rbnJ2IA";
            rbnJ2IA.Size = new Size(124, 24);
            rbnJ2IA.TabIndex = 24;
            rbnJ2IA.Text = "Joueur 2 ou IA";
            rbnJ2IA.UseVisualStyleBackColor = false;
            rbnJ2IA.CheckedChanged += rbnQuiDebute;
            // 
            // rbnJ1
            // 
            rbnJ1.AutoSize = true;
            rbnJ1.BackColor = Color.Transparent;
            rbnJ1.ForeColor = SystemColors.Control;
            rbnJ1.Location = new Point(162, 491);
            rbnJ1.Name = "rbnJ1";
            rbnJ1.Size = new Size(85, 24);
            rbnJ1.TabIndex = 23;
            rbnJ1.Text = "Joueur 1";
            rbnJ1.UseVisualStyleBackColor = false;
            rbnJ1.CheckedChanged += rbnQuiDebute;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(331, 448);
            label5.Name = "label5";
            label5.Size = new Size(245, 20);
            label5.TabIndex = 22;
            label5.Text = "Choix du joueur débutant la partie";
            // 
            // lblPseudos
            // 
            lblPseudos.AutoSize = true;
            lblPseudos.BackColor = Color.Transparent;
            lblPseudos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPseudos.ForeColor = SystemColors.Control;
            lblPseudos.Location = new Point(123, 265);
            lblPseudos.Name = "lblPseudos";
            lblPseudos.Size = new Size(124, 38);
            lblPseudos.TabIndex = 21;
            lblPseudos.Text = "Pseudos";
            // 
            // pnlPseudos
            // 
            pnlPseudos.BackColor = Color.Transparent;
            pnlPseudos.Controls.Add(txbJ2);
            pnlPseudos.Controls.Add(txbJ1);
            pnlPseudos.Controls.Add(lblJ2);
            pnlPseudos.Controls.Add(lblJ1);
            pnlPseudos.ForeColor = SystemColors.Control;
            pnlPseudos.Location = new Point(101, 289);
            pnlPseudos.Name = "pnlPseudos";
            pnlPseudos.Size = new Size(689, 140);
            pnlPseudos.TabIndex = 20;
            // 
            // txbJ2
            // 
            txbJ2.Location = new Point(280, 81);
            txbJ2.MaxLength = 30;
            txbJ2.Name = "txbJ2";
            txbJ2.Size = new Size(325, 27);
            txbJ2.TabIndex = 3;
            // 
            // txbJ1
            // 
            txbJ1.Location = new Point(280, 25);
            txbJ1.MaxLength = 30;
            txbJ1.Name = "txbJ1";
            txbJ1.Size = new Size(325, 27);
            txbJ1.TabIndex = 2;
            // 
            // lblJ2
            // 
            lblJ2.AutoSize = true;
            lblJ2.Location = new Point(74, 88);
            lblJ2.Name = "lblJ2";
            lblJ2.Size = new Size(64, 20);
            lblJ2.TabIndex = 1;
            lblJ2.Text = "Joueur 2";
            // 
            // lblJ1
            // 
            lblJ1.AutoSize = true;
            lblJ1.Location = new Point(74, 32);
            lblJ1.Name = "lblJ1";
            lblJ1.Size = new Size(64, 20);
            lblJ1.TabIndex = 0;
            lblJ1.Text = "Joueur 1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(rbnNR);
            panel3.Controls.Add(rbnJN);
            panel3.Controls.Add(rbnRJ);
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(331, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 43);
            panel3.TabIndex = 18;
            // 
            // rbnNR
            // 
            rbnNR.AutoSize = true;
            rbnNR.Location = new Point(305, 11);
            rbnNR.Name = "rbnNR";
            rbnNR.Size = new Size(116, 24);
            rbnNR.TabIndex = 2;
            rbnNR.Text = "Noir / Rouge";
            rbnNR.UseVisualStyleBackColor = true;
            rbnNR.CheckedChanged += rbnCouleur_CheckedChanged;
            // 
            // rbnJN
            // 
            rbnJN.AutoSize = true;
            rbnJN.Location = new Point(149, 11);
            rbnJN.Name = "rbnJN";
            rbnJN.Size = new Size(110, 24);
            rbnJN.TabIndex = 1;
            rbnJN.Text = "Jaune / Noir";
            rbnJN.UseVisualStyleBackColor = true;
            rbnJN.CheckedChanged += rbnCouleur_CheckedChanged;
            // 
            // rbnRJ
            // 
            rbnRJ.AutoSize = true;
            rbnRJ.Checked = true;
            rbnRJ.Location = new Point(3, 11);
            rbnRJ.Name = "rbnRJ";
            rbnRJ.Size = new Size(124, 24);
            rbnRJ.TabIndex = 0;
            rbnRJ.TabStop = true;
            rbnRJ.Text = "Rouge / Jaune";
            rbnRJ.UseVisualStyleBackColor = true;
            rbnRJ.CheckedChanged += rbnCouleur_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(rbnJoueur);
            panel2.Controls.Add(rbnIA);
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(331, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 43);
            panel2.TabIndex = 19;
            // 
            // rbnJoueur
            // 
            rbnJoueur.AutoSize = true;
            rbnJoueur.Checked = true;
            rbnJoueur.Location = new Point(3, 11);
            rbnJoueur.Name = "rbnJoueur";
            rbnJoueur.Size = new Size(73, 24);
            rbnJoueur.TabIndex = 1;
            rbnJoueur.TabStop = true;
            rbnJoueur.Text = "Joueur";
            rbnJoueur.UseVisualStyleBackColor = true;
            // 
            // rbnIA
            // 
            rbnIA.AutoSize = true;
            rbnIA.Location = new Point(149, 11);
            rbnIA.Name = "rbnIA";
            rbnIA.Size = new Size(44, 24);
            rbnIA.TabIndex = 0;
            rbnIA.Text = "IA";
            rbnIA.UseVisualStyleBackColor = true;
            rbnIA.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(rbn9x9);
            panel1.Controls.Add(rbn8x8);
            panel1.Controls.Add(rbn6x7);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(331, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 43);
            panel1.TabIndex = 17;
            // 
            // rbn9x9
            // 
            rbn9x9.AutoSize = true;
            rbn9x9.Location = new Point(305, 11);
            rbn9x9.Name = "rbn9x9";
            rbn9x9.Size = new Size(61, 24);
            rbn9x9.TabIndex = 2;
            rbn9x9.Text = "9 x 9";
            rbn9x9.UseVisualStyleBackColor = true;
            rbn9x9.CheckedChanged += rbn_CheckedChanged;
            // 
            // rbn8x8
            // 
            rbn8x8.AutoSize = true;
            rbn8x8.Location = new Point(149, 11);
            rbn8x8.Name = "rbn8x8";
            rbn8x8.Size = new Size(61, 24);
            rbn8x8.TabIndex = 1;
            rbn8x8.Text = "8 x 8";
            rbn8x8.UseVisualStyleBackColor = true;
            rbn8x8.CheckedChanged += rbn_CheckedChanged;
            // 
            // rbn6x7
            // 
            rbn6x7.AutoSize = true;
            rbn6x7.Checked = true;
            rbn6x7.Location = new Point(3, 11);
            rbn6x7.Name = "rbn6x7";
            rbn6x7.Size = new Size(61, 24);
            rbn6x7.TabIndex = 0;
            rbn6x7.TabStop = true;
            rbn6x7.Text = "6 x 7";
            rbn6x7.UseVisualStyleBackColor = true;
            rbn6x7.CheckedChanged += rbn_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(101, 223);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 16;
            label4.Text = "Choix de l'adversaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(101, 175);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 15;
            label3.Text = "Couleur des pions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(101, 125);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 14;
            label2.Text = "Taille du plateau";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(469, 62);
            label1.TabIndex = 13;
            label1.Text = "Partie Personnalisée";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(101, 472);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(689, 59);
            panel4.TabIndex = 27;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(135, 556);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(269, 57);
            btnRetour.TabIndex = 28;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormPartiePerso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Design_sans_titre;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 645);
            Controls.Add(btnRetour);
            Controls.Add(button1);
            Controls.Add(rbnRandom);
            Controls.Add(rbnJ2IA);
            Controls.Add(rbnJ1);
            Controls.Add(label5);
            Controls.Add(lblPseudos);
            Controls.Add(pnlPseudos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormPartiePerso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partie personnalisée";
            FormClosed += FormPartiePerso_FormClosed;
            Load += FormPartiePerso_Load;
            pnlPseudos.ResumeLayout(false);
            pnlPseudos.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton rbnRandom;
        private RadioButton rbnJ2IA;
        private RadioButton rbnJ1;
        private Label label5;
        private Label lblPseudos;
        private Panel pnlPseudos;
        private TextBox txbJ2;
        private TextBox txbJ1;
        private Label lblJ2;
        private Label lblJ1;
        private Panel panel3;
        private RadioButton rbnNR;
        private RadioButton rbnJN;
        private RadioButton rbnRJ;
        private Panel panel2;
        private RadioButton rbnJoueur;
        private RadioButton rbnIA;
        private Panel panel1;
        private RadioButton rbn9x9;
        private RadioButton rbn8x8;
        private RadioButton rbn6x7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Button btnRetour;
    }
}