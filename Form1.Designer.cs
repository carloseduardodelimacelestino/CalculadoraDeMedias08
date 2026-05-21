namespace CalculadoraDeMedias08
{
    partial class TXTPIM
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
            BOXNP1 = new TextBox();
            BOXNP2 = new TextBox();
            BOXPIM = new TextBox();
            BT2LIMPAR = new Button();
            TXTSEMESTRAL = new Label();
            panel1 = new Panel();
            lblStatus = new Label();
            TXTEXAME = new Label();
            BOXEXAME = new TextBox();
            BTFINAL = new Button();
            BT1LIMPAR = new Button();
            BTSEMESTRAL = new Button();
            BOXSEMESTRAL = new TextBox();
            TXTFINAL = new Label();
            BOXFINAL = new TextBox();
            lblNP1 = new Label();
            lblNP2 = new Label();
            lblPIM = new Label();
            SuspendLayout();
            // 
            // BOXNP1
            // 
            BOXNP1.Location = new Point(249, 77);
            BOXNP1.Name = "BOXNP1";
            BOXNP1.Size = new Size(125, 27);
            BOXNP1.TabIndex = 1;
            // 
            // BOXNP2
            // 
            BOXNP2.Location = new Point(249, 110);
            BOXNP2.Name = "BOXNP2";
            BOXNP2.Size = new Size(125, 27);
            BOXNP2.TabIndex = 4;
            // 
            // BOXPIM
            // 
            BOXPIM.Location = new Point(250, 153);
            BOXPIM.Name = "BOXPIM";
            BOXPIM.Size = new Size(125, 27);
            BOXPIM.TabIndex = 5;
            // 
            // BT2LIMPAR
            // 
            BT2LIMPAR.Enabled = false;
            BT2LIMPAR.ForeColor = Color.Black;
            BT2LIMPAR.Location = new Point(144, 364);
            BT2LIMPAR.Name = "BT2LIMPAR";
            BT2LIMPAR.Size = new Size(94, 29);
            BT2LIMPAR.TabIndex = 6;
            BT2LIMPAR.Text = "Limpar";
            BT2LIMPAR.UseVisualStyleBackColor = true;
            BT2LIMPAR.Click += BT2LIMPAR_Click;
            // 
            // TXTSEMESTRAL
            // 
            TXTSEMESTRAL.AutoSize = true;
            TXTSEMESTRAL.Location = new Point(144, 204);
            TXTSEMESTRAL.Name = "TXTSEMESTRAL";
            TXTSEMESTRAL.Size = new Size(72, 20);
            TXTSEMESTRAL.TabIndex = 9;
            TXTSEMESTRAL.Text = "semestral";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 38);
            panel1.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.WhiteSmoke;
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(225, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "STATUS";
            lblStatus.Click += lblStatus_Click;
            // 
            // TXTEXAME
            // 
            TXTEXAME.AutoSize = true;
            TXTEXAME.Enabled = false;
            TXTEXAME.Location = new Point(163, 284);
            TXTEXAME.Name = "TXTEXAME";
            TXTEXAME.Size = new Size(53, 20);
            TXTEXAME.TabIndex = 11;
            TXTEXAME.Text = "Exame";
            // 
            // BOXEXAME
            // 
            BOXEXAME.Enabled = false;
            BOXEXAME.Location = new Point(266, 277);
            BOXEXAME.Name = "BOXEXAME";
            BOXEXAME.Size = new Size(125, 27);
            BOXEXAME.TabIndex = 12;
            // 
            // BTFINAL
            // 
            BTFINAL.Enabled = false;
            BTFINAL.ForeColor = Color.Black;
            BTFINAL.Location = new Point(297, 364);
            BTFINAL.Name = "BTFINAL";
            BTFINAL.Size = new Size(94, 29);
            BTFINAL.TabIndex = 15;
            BTFINAL.Text = "FINAL";
            BTFINAL.UseVisualStyleBackColor = true;
            BTFINAL.Click += BTFINAL_Click;
            // 
            // BT1LIMPAR
            // 
            BT1LIMPAR.ForeColor = Color.Black;
            BT1LIMPAR.Location = new Point(144, 238);
            BT1LIMPAR.Name = "BT1LIMPAR";
            BT1LIMPAR.Size = new Size(94, 29);
            BT1LIMPAR.TabIndex = 16;
            BT1LIMPAR.Text = "Limpar";
            BT1LIMPAR.UseVisualStyleBackColor = true;
            BT1LIMPAR.Click += BT1LIMPAR_Click;
            // 
            // BTSEMESTRAL
            // 
            BTSEMESTRAL.ForeColor = Color.Black;
            BTSEMESTRAL.Location = new Point(280, 238);
            BTSEMESTRAL.Name = "BTSEMESTRAL";
            BTSEMESTRAL.Size = new Size(94, 29);
            BTSEMESTRAL.TabIndex = 7;
            BTSEMESTRAL.Text = "Semestral";
            BTSEMESTRAL.UseVisualStyleBackColor = true;
            BTSEMESTRAL.Click += BTSEMESTRAL_Click;
            // 
            // BOXSEMESTRAL
            // 
            BOXSEMESTRAL.Location = new Point(250, 197);
            BOXSEMESTRAL.Name = "BOXSEMESTRAL";
            BOXSEMESTRAL.Size = new Size(125, 27);
            BOXSEMESTRAL.TabIndex = 17;
            BOXSEMESTRAL.Text = "0,0";
            // 
            // TXTFINAL
            // 
            TXTFINAL.AutoSize = true;
            TXTFINAL.Location = new Point(176, 322);
            TXTFINAL.Name = "TXTFINAL";
            TXTFINAL.Size = new Size(40, 20);
            TXTFINAL.TabIndex = 13;
            TXTFINAL.Text = "Final";
            // 
            // BOXFINAL
            // 
            BOXFINAL.Location = new Point(266, 315);
            BOXFINAL.Name = "BOXFINAL";
            BOXFINAL.Size = new Size(125, 27);
            BOXFINAL.TabIndex = 19;
            BOXFINAL.Text = "0,0";
            // 
            // lblNP1
            // 
            lblNP1.AutoSize = true;
            lblNP1.Location = new Point(165, 84);
            lblNP1.Name = "lblNP1";
            lblNP1.Size = new Size(36, 20);
            lblNP1.TabIndex = 20;
            lblNP1.Text = "NP1";
            // 
            // lblNP2
            // 
            lblNP2.AutoSize = true;
            lblNP2.Location = new Point(165, 123);
            lblNP2.Name = "lblNP2";
            lblNP2.Size = new Size(36, 20);
            lblNP2.TabIndex = 21;
            lblNP2.Text = "NP2";
            lblNP2.Click += TXTNP2_Click;
            // 
            // lblPIM
            // 
            lblPIM.AutoSize = true;
            lblPIM.Location = new Point(167, 160);
            lblPIM.Name = "lblPIM";
            lblPIM.Size = new Size(34, 20);
            lblPIM.TabIndex = 22;
            lblPIM.Text = "PIM";
            lblPIM.Click += label3_Click;
            // 
            // TXTPIM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 415);
            Controls.Add(lblStatus);
            Controls.Add(lblPIM);
            Controls.Add(lblNP2);
            Controls.Add(lblNP1);
            Controls.Add(BOXFINAL);
            Controls.Add(BOXSEMESTRAL);
            Controls.Add(BT1LIMPAR);
            Controls.Add(BTFINAL);
            Controls.Add(TXTFINAL);
            Controls.Add(BOXEXAME);
            Controls.Add(TXTEXAME);
            Controls.Add(panel1);
            Controls.Add(TXTSEMESTRAL);
            Controls.Add(BTSEMESTRAL);
            Controls.Add(BT2LIMPAR);
            Controls.Add(BOXPIM);
            Controls.Add(BOXNP2);
            Controls.Add(BOXNP1);
            ForeColor = Color.Black;
            Name = "TXTPIM";
            Text = "       ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNP1;
        private TextBox BOXNP1;
        private Label lblNP2;
        private TextBox BOXNP2;
        private TextBox BOXPIM;
        private Button BT2LIMPAR;
        private Label TXTSEMESTRAL;
        private Panel panel1;
        private Label TXTEXAME;
        private TextBox BOXEXAME;
        private Label lblStatus;
        private Button BTFINAL;
        private Button BT1LIMPAR;
        private Button BTSEMESTRAL;
        private TextBox BOXSEMESTRAL;
        private Label TXTFINAL;
        private TextBox BOXFINAL;
        private Label lblPIM;
    }
}
