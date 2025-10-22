namespace WinFormsApp1
{
    partial class cryptage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cryptage));
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            tb_motentree = new TextBox();
            tb_motinfo = new TextBox();
            tb_resultatentree = new TextBox();
            tb_resultatinfo = new TextBox();
            btn_quitter2 = new Button();
            msgdate = new Label();
            btn_Calcul = new Button();
            label5 = new Label();
            btn_calcul1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(232, 179);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Mot à Coder";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(520, 179);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Résultat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(286, 18);
            label8.Name = "label8";
            label8.Size = new Size(251, 75);
            label8.TabIndex = 7;
            label8.Text = "Digicode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 148);
            label1.Name = "label1";
            label1.Size = new Size(193, 24);
            label1.TabIndex = 8;
            label1.Text = "Porte d'entrée";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(292, 270);
            label6.Name = "label6";
            label6.Size = new Size(245, 24);
            label6.TabIndex = 9;
            label6.Text = "salle informatique";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(232, 305);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 10;
            label7.Text = "Mot à Coder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(520, 305);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Résultat";
            // 
            // tb_motentree
            // 
            tb_motentree.Location = new Point(215, 202);
            tb_motentree.Name = "tb_motentree";
            tb_motentree.Size = new Size(125, 27);
            tb_motentree.TabIndex = 12;
            // 
            // tb_motinfo
            // 
            tb_motinfo.Location = new Point(215, 328);
            tb_motinfo.Name = "tb_motinfo";
            tb_motinfo.Size = new Size(125, 27);
            tb_motinfo.TabIndex = 13;
            // 
            // tb_resultatentree
            // 
            tb_resultatentree.Location = new Point(485, 202);
            tb_resultatentree.Name = "tb_resultatentree";
            tb_resultatentree.ReadOnly = true;
            tb_resultatentree.Size = new Size(125, 27);
            tb_resultatentree.TabIndex = 14;
            // 
            // tb_resultatinfo
            // 
            tb_resultatinfo.Location = new Point(485, 328);
            tb_resultatinfo.Name = "tb_resultatinfo";
            tb_resultatinfo.ReadOnly = true;
            tb_resultatinfo.Size = new Size(125, 27);
            tb_resultatinfo.TabIndex = 15;
            // 
            // btn_quitter2
            // 
            btn_quitter2.BackColor = Color.Gray;
            btn_quitter2.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_quitter2.ForeColor = SystemColors.ButtonHighlight;
            btn_quitter2.Location = new Point(348, 361);
            btn_quitter2.Name = "btn_quitter2";
            btn_quitter2.Size = new Size(133, 64);
            btn_quitter2.TabIndex = 16;
            btn_quitter2.Text = "Quitter";
            btn_quitter2.UseVisualStyleBackColor = false;
            btn_quitter2.Click += btn_quitter2_Click;
            // 
            // msgdate
            // 
            msgdate.AutoSize = true;
            msgdate.BackColor = Color.Transparent;
            msgdate.ForeColor = Color.Red;
            msgdate.Location = new Point(215, 116);
            msgdate.Name = "msgdate";
            msgdate.Size = new Size(403, 20);
            msgdate.TabIndex = 17;
            msgdate.Text = "Vous devez changer les mots de passe avant la fin du mois !";
            // 
            // btn_Calcul
            // 
            btn_Calcul.BackColor = Color.Gray;
            btn_Calcul.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Calcul.ForeColor = SystemColors.ButtonHighlight;
            btn_Calcul.Location = new Point(372, 321);
            btn_Calcul.Name = "btn_Calcul";
            btn_Calcul.Size = new Size(90, 34);
            btn_Calcul.TabIndex = 18;
            btn_Calcul.Text = "Calculer";
            btn_Calcul.UseVisualStyleBackColor = false;
            btn_Calcul.Click += btn_Calcul_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(254, 232);
            label5.Name = "label5";
            label5.Size = new Size(328, 20);
            label5.TabIndex = 19;
            label5.Text = "Les mots à coder doivent être écrit en majuscule";
            // 
            // btn_calcul1
            // 
            btn_calcul1.BackColor = Color.Gray;
            btn_calcul1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calcul1.ForeColor = SystemColors.ButtonHighlight;
            btn_calcul1.Location = new Point(372, 195);
            btn_calcul1.Name = "btn_calcul1";
            btn_calcul1.Size = new Size(90, 34);
            btn_calcul1.TabIndex = 20;
            btn_calcul1.Text = "Calculer";
            btn_calcul1.UseVisualStyleBackColor = false;
            btn_calcul1.Click += btn_calcul1_Click;
            // 
            // cryptage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_calcul1);
            Controls.Add(label5);
            Controls.Add(btn_Calcul);
            Controls.Add(msgdate);
            Controls.Add(btn_quitter2);
            Controls.Add(tb_resultatinfo);
            Controls.Add(tb_resultatentree);
            Controls.Add(tb_motinfo);
            Controls.Add(tb_motentree);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "cryptage";
            Text = "Générateur de Mot de Passe";
            Load += cryptage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label4;
        private TextBox tb_motentree;
        private TextBox tb_motinfo;
        private TextBox tb_resultatentree;
        private TextBox tb_resultatinfo;
        private Button btn_quitter2;
        private Label msgdate;
        private Button btn_Calcul;
        private Label label5;
        private Button btn_calcul1;
    }
}