namespace WinFormsApp1
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            label1 = new Label();
            label4 = new Label();
            btn_quitter = new Button();
            label5 = new Label();
            tb_matricule = new TextBox();
            label6 = new Label();
            tb_mdp = new TextBox();
            btn_Connexion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(294, 32);
            label1.Name = "label1";
            label1.Size = new Size(230, 59);
            label1.TabIndex = 0;
            label1.Text = "Connexion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 177);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // btn_quitter
            // 
            btn_quitter.BackColor = Color.Gray;
            btn_quitter.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_quitter.ForeColor = SystemColors.ButtonHighlight;
            btn_quitter.Location = new Point(262, 357);
            btn_quitter.Name = "btn_quitter";
            btn_quitter.Size = new Size(117, 64);
            btn_quitter.TabIndex = 4;
            btn_quitter.Text = "Quitter";
            btn_quitter.UseVisualStyleBackColor = false;
            btn_quitter.Click += btn_quitter_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(243, 173);
            label5.Name = "label5";
            label5.Size = new Size(147, 24);
            label5.TabIndex = 6;
            label5.Text = "Matricule :";
            // 
            // tb_matricule
            // 
            tb_matricule.Location = new Point(440, 170);
            tb_matricule.Name = "tb_matricule";
            tb_matricule.Size = new Size(125, 27);
            tb_matricule.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(243, 226);
            label6.Name = "label6";
            label6.Size = new Size(175, 24);
            label6.TabIndex = 10;
            label6.Text = "Mot de Passe :";
            // 
            // tb_mdp
            // 
            tb_mdp.Location = new Point(440, 223);
            tb_mdp.Name = "tb_mdp";
            tb_mdp.PasswordChar = '*';
            tb_mdp.Size = new Size(125, 27);
            tb_mdp.TabIndex = 11;
            // 
            // btn_Connexion
            // 
            btn_Connexion.BackColor = Color.Gray;
            btn_Connexion.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Connexion.ForeColor = SystemColors.ButtonHighlight;
            btn_Connexion.Location = new Point(423, 357);
            btn_Connexion.Name = "btn_Connexion";
            btn_Connexion.Size = new Size(133, 64);
            btn_Connexion.TabIndex = 12;
            btn_Connexion.Text = "Connexion";
            btn_Connexion.UseVisualStyleBackColor = false;
            btn_Connexion.Click += btn_Connexion_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Connexion);
            Controls.Add(tb_mdp);
            Controls.Add(label6);
            Controls.Add(tb_matricule);
            Controls.Add(label5);
            Controls.Add(btn_quitter);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Connexion";
            Text = "Page de Connexion";
            Load += Connexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button btn_quitter;
        private Label label5;
        private TextBox tb_matricule;
        private Label label6;
        private TextBox tb_mdp;
        private Button btn_Connexion;
    }
}
