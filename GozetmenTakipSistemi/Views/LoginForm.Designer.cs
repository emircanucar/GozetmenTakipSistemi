namespace GozetmenTakipSistemi.Views
{
    partial class LoginForm
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
            panelMain = new Panel();
            panelRight = new Panel();
            buttonExit = new Button();
            buttonLogin = new Button();
            panelLeft = new Panel();
            labelTitle = new Label();
            pictureBoxLogo = new PictureBox();
            panelMain.SuspendLayout();
            panelRight.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelRight);
            panelMain.Controls.Add(panelLeft);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1262, 673);
            panelMain.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ControlLight;
            panelRight.Controls.Add(buttonExit);
            panelRight.Controls.Add(buttonLogin);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(631, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(631, 673);
            panelRight.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackColor = Color.FromArgb(62, 62, 62);
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(141, 329);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(356, 63);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Çıkış Yap";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.BackColor = Color.FromArgb(62, 62, 62);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(141, 260);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(356, 63);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Giriş Yap";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(170, 170, 170);
            panelLeft.Controls.Add(labelTitle);
            panelLeft.Controls.Add(pictureBoxLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(631, 673);
            panelLeft.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelTitle.Location = new Point(110, 83);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(414, 39);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "GÖZETMEN TAKİP SİSTEMİ";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Image = Properties.Resources.meuLogo;
            pictureBoxLogo.Location = new Point(176, 208);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(267, 237);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelMain);
            MinimumSize = new Size(800, 600);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gözetmen Takip Sisemi";
            panelMain.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelRight;
        private Panel panelLeft;
        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private Button buttonLogin;
        private Button buttonExit;
    }
}