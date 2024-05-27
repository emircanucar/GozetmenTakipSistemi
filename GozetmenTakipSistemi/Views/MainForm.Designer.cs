namespace GozetmenTakipSistemi.Views
{
    partial class MainForm
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
            panelSide = new Panel();
            clockControl2 = new Controls.ClockControl();
            button1 = new Button();
            panel4 = new Panel();
            buttonSınav = new Button();
            panel3 = new Panel();
            buttonExamHall = new Button();
            panel1 = new Panel();
            buttonGozetmen = new Button();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            labelDate = new Label();
            panelConent = new Panel();
            labelWelcome = new Label();
            panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelConent.SuspendLayout();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.AutoScroll = true;
            panelSide.BackColor = Color.FromArgb(170, 170, 170);
            panelSide.Controls.Add(clockControl2);
            panelSide.Controls.Add(button1);
            panelSide.Controls.Add(panel4);
            panelSide.Controls.Add(buttonSınav);
            panelSide.Controls.Add(panel3);
            panelSide.Controls.Add(buttonExamHall);
            panelSide.Controls.Add(panel1);
            panelSide.Controls.Add(buttonGozetmen);
            panelSide.Controls.Add(panel2);
            panelSide.Controls.Add(pictureBoxLogo);
            panelSide.Controls.Add(labelDate);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(300, 673);
            panelSide.TabIndex = 0;
            // 
            // clockControl2
            // 
            clockControl2.Location = new Point(206, 0);
            clockControl2.Name = "clockControl2";
            clockControl2.Size = new Size(94, 29);
            clockControl2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 75, 75);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.list;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 358);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 10, 0);
            button1.Size = new Size(300, 54);
            button1.TabIndex = 12;
            button1.Text = "Atama Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 353);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 5);
            panel4.TabIndex = 11;
            // 
            // buttonSınav
            // 
            buttonSınav.BackColor = Color.FromArgb(90, 90, 90);
            buttonSınav.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSınav.Dock = DockStyle.Top;
            buttonSınav.FlatAppearance.BorderSize = 0;
            buttonSınav.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            buttonSınav.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 75, 75);
            buttonSınav.FlatStyle = FlatStyle.Flat;
            buttonSınav.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonSınav.ForeColor = Color.White;
            buttonSınav.Image = Properties.Resources.note;
            buttonSınav.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSınav.Location = new Point(0, 299);
            buttonSınav.Name = "buttonSınav";
            buttonSınav.Padding = new Padding(10, 0, 10, 0);
            buttonSınav.Size = new Size(300, 54);
            buttonSınav.TabIndex = 9;
            buttonSınav.Text = "Sınav Listesi";
            buttonSınav.UseVisualStyleBackColor = false;
            buttonSınav.Click += buttonSınav_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 5);
            panel3.TabIndex = 8;
            // 
            // buttonExamHall
            // 
            buttonExamHall.BackColor = Color.FromArgb(90, 90, 90);
            buttonExamHall.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExamHall.Dock = DockStyle.Top;
            buttonExamHall.FlatAppearance.BorderSize = 0;
            buttonExamHall.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            buttonExamHall.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 75, 75);
            buttonExamHall.FlatStyle = FlatStyle.Flat;
            buttonExamHall.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonExamHall.ForeColor = Color.White;
            buttonExamHall.Image = Properties.Resources.desk;
            buttonExamHall.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExamHall.Location = new Point(0, 240);
            buttonExamHall.Name = "buttonExamHall";
            buttonExamHall.Padding = new Padding(10, 0, 10, 0);
            buttonExamHall.Size = new Size(300, 54);
            buttonExamHall.TabIndex = 7;
            buttonExamHall.Text = "Derslik Listesi";
            buttonExamHall.UseVisualStyleBackColor = false;
            buttonExamHall.Click += buttonExamHall_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 5);
            panel1.TabIndex = 6;
            // 
            // buttonGozetmen
            // 
            buttonGozetmen.BackColor = Color.FromArgb(90, 90, 90);
            buttonGozetmen.BackgroundImageLayout = ImageLayout.Zoom;
            buttonGozetmen.Dock = DockStyle.Top;
            buttonGozetmen.FlatAppearance.BorderSize = 0;
            buttonGozetmen.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            buttonGozetmen.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 75, 75);
            buttonGozetmen.FlatStyle = FlatStyle.Flat;
            buttonGozetmen.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGozetmen.ForeColor = Color.White;
            buttonGozetmen.Image = Properties.Resources.user;
            buttonGozetmen.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGozetmen.Location = new Point(0, 181);
            buttonGozetmen.Name = "buttonGozetmen";
            buttonGozetmen.Padding = new Padding(10, 0, 10, 0);
            buttonGozetmen.Size = new Size(300, 54);
            buttonGozetmen.TabIndex = 5;
            buttonGozetmen.Text = "Gözetmen Listesi";
            buttonGozetmen.UseVisualStyleBackColor = false;
            buttonGozetmen.Click += buttonGozetmen_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 34);
            panel2.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = Properties.Resources.meuLogo;
            pictureBoxLogo.Location = new Point(0, 50);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 97);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Top;
            labelDate.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelDate.Location = new Point(0, 0);
            labelDate.Name = "labelDate";
            labelDate.Padding = new Padding(0, 4, 0, 0);
            labelDate.Size = new Size(300, 50);
            labelDate.TabIndex = 2;
            labelDate.Text = "Tarih";
            // 
            // panelConent
            // 
            panelConent.Controls.Add(labelWelcome);
            panelConent.Dock = DockStyle.Fill;
            panelConent.Location = new Point(300, 0);
            panelConent.Name = "panelConent";
            panelConent.Size = new Size(962, 673);
            panelConent.TabIndex = 1;
            // 
            // labelWelcome
            // 
            labelWelcome.Dock = DockStyle.Fill;
            labelWelcome.Font = new Font("Yu Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelWelcome.Location = new Point(0, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Padding = new Padding(0, 4, 0, 0);
            labelWelcome.Size = new Size(962, 673);
            labelWelcome.TabIndex = 3;
            labelWelcome.Text = "Gözetmen Takip Sistemi\r\n\r\nHoşgeldiniz!\r\n";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelConent);
            Controls.Add(panelSide);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gözetmen Takip Sistemi";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelConent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private Panel panelConent;
        private Panel panel2;
        private PictureBox pictureBoxLogo;
        private Button buttonGozetmen;
        private Panel panel1;
        private Button buttonSınav;
        private Panel panel3;
        private Button buttonExamHall;
        private Label labelDate;
        private Controls.ClockControl clockControl1;
        private Button button1;
        private Panel panel4;
        private Controls.ClockControl clockControl2;
        private Label labelWelcome;
    }
}