namespace GozetmenTakipSistemi.Views.Childs
{
    partial class SupervisorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTop = new Panel();
            labelPageTitle = new Label();
            panelBottom = new Panel();
            button2 = new Button();
            panelCenter = new Panel();
            dataGridView1 = new DataGridView();
            panelForm = new Panel();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            panel4 = new Panel();
            comboBoxDurum = new ComboBox();
            panel7 = new Panel();
            panel8 = new Panel();
            panelUnvanTbox = new Panel();
            panel5 = new Panel();
            comboBoxUnvan = new ComboBox();
            panel6 = new Panel();
            panelLine = new Panel();
            buttonAddSupervisor = new Button();
            panel1 = new Panel();
            textBoxName = new TextBox();
            panel2 = new Panel();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelForm.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelUnvanTbox.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ControlDarkDark;
            panelTop.Controls.Add(labelPageTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(952, 60);
            panelTop.TabIndex = 0;
            // 
            // labelPageTitle
            // 
            labelPageTitle.Dock = DockStyle.Left;
            labelPageTitle.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPageTitle.ForeColor = Color.White;
            labelPageTitle.Location = new Point(0, 0);
            labelPageTitle.Name = "labelPageTitle";
            labelPageTitle.Padding = new Padding(10, 0, 0, 0);
            labelPageTitle.Size = new Size(168, 60);
            labelPageTitle.TabIndex = 0;
            labelPageTitle.Text = "Gözetmen Listesi";
            labelPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ControlDarkDark;
            panelBottom.Controls.Add(button2);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 498);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(952, 60);
            panelBottom.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(62, 62, 62);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(786, 9);
            button2.Name = "button2";
            button2.Size = new Size(154, 48);
            button2.TabIndex = 5;
            button2.Text = "Kayıt Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelCenter
            // 
            panelCenter.AutoScroll = true;
            panelCenter.BackColor = SystemColors.Control;
            panelCenter.Controls.Add(dataGridView1);
            panelCenter.Controls.Add(panelForm);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 60);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(952, 438);
            panelCenter.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(952, 214);
            dataGridView1.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(groupBox1);
            panelForm.Dock = DockStyle.Bottom;
            panelForm.Location = new Point(0, 214);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(952, 224);
            panelForm.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panelUnvanTbox);
            groupBox1.Controls.Add(buttonAddSupervisor);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(952, 221);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gözetmen Ekle";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(340, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 40);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(comboBoxDurum);
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, -3);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 40);
            panel4.TabIndex = 23;
            // 
            // comboBoxDurum
            // 
            comboBoxDurum.DisplayMember = "ascacsacs";
            comboBoxDurum.Dock = DockStyle.Bottom;
            comboBoxDurum.FlatStyle = FlatStyle.Flat;
            comboBoxDurum.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxDurum.FormattingEnabled = true;
            comboBoxDurum.Items.AddRange(new object[] { "Aktif", "Pasif" });
            comboBoxDurum.Location = new Point(0, 6);
            comboBoxDurum.Name = "comboBoxDurum";
            comboBoxDurum.Size = new Size(275, 31);
            comboBoxDurum.TabIndex = 3;
            comboBoxDurum.Tag = "";
            comboBoxDurum.Text = "Aktif";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDarkDark;
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 3);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlDarkDark;
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 37);
            panel8.Name = "panel8";
            panel8.Size = new Size(275, 3);
            panel8.TabIndex = 2;
            // 
            // panelUnvanTbox
            // 
            panelUnvanTbox.Anchor = AnchorStyles.None;
            panelUnvanTbox.BackColor = Color.White;
            panelUnvanTbox.Controls.Add(panel5);
            panelUnvanTbox.Controls.Add(panelLine);
            panelUnvanTbox.Location = new Point(340, 17);
            panelUnvanTbox.Name = "panelUnvanTbox";
            panelUnvanTbox.Size = new Size(275, 40);
            panelUnvanTbox.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(comboBoxUnvan);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, -3);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 40);
            panel5.TabIndex = 23;
            // 
            // comboBoxUnvan
            // 
            comboBoxUnvan.DisplayMember = "ascacsacs";
            comboBoxUnvan.Dock = DockStyle.Bottom;
            comboBoxUnvan.FlatStyle = FlatStyle.Flat;
            comboBoxUnvan.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxUnvan.FormattingEnabled = true;
            comboBoxUnvan.Items.AddRange(new object[] { "Arş. Gör.", "Öğr. Gör.", "Öğr. Gör. Dr.", "Öğr. Ü.", "Dr. Öğr. Üyesi", "Prof. Dr.", "Doç. Dr.", "Yrd. Doç.", "Arş. Gör. Dr.", "Dr.", "Uz.", "Okt.", "Çev.", "Müh.", "Personel", "Diğer" });
            comboBoxUnvan.Location = new Point(0, 6);
            comboBoxUnvan.Name = "comboBoxUnvan";
            comboBoxUnvan.Size = new Size(275, 31);
            comboBoxUnvan.TabIndex = 3;
            comboBoxUnvan.Tag = "";
            comboBoxUnvan.Text = "Ünvan";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 37);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 3);
            panel6.TabIndex = 2;
            // 
            // panelLine
            // 
            panelLine.BackColor = SystemColors.ControlDarkDark;
            panelLine.Dock = DockStyle.Bottom;
            panelLine.Location = new Point(0, 37);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(275, 3);
            panelLine.TabIndex = 2;
            // 
            // buttonAddSupervisor
            // 
            buttonAddSupervisor.Anchor = AnchorStyles.None;
            buttonAddSupervisor.BackColor = Color.FromArgb(62, 62, 62);
            buttonAddSupervisor.FlatAppearance.BorderSize = 0;
            buttonAddSupervisor.FlatStyle = FlatStyle.Flat;
            buttonAddSupervisor.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonAddSupervisor.ForeColor = Color.White;
            buttonAddSupervisor.Location = new Point(340, 164);
            buttonAddSupervisor.Name = "buttonAddSupervisor";
            buttonAddSupervisor.Size = new Size(275, 48);
            buttonAddSupervisor.TabIndex = 3;
            buttonAddSupervisor.Text = "Gözetmen Ekle";
            buttonAddSupervisor.UseVisualStyleBackColor = false;
            buttonAddSupervisor.Click += buttonAddSupervisor_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(340, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 40);
            panel1.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Dock = DockStyle.Bottom;
            textBoxName.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxName.Location = new Point(0, 8);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Ad Soyad";
            textBoxName.Size = new Size(275, 29);
            textBoxName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 3);
            panel2.TabIndex = 2;
            // 
            // SupervisorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 558);
            ControlBox = false;
            Controls.Add(panelCenter);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupervisorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupervisorForm";
            Load += SupervisorForm_Load;
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelForm.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelUnvanTbox.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelCenter;
        private Label labelPageTitle;
        private Panel panelForm;
        private Panel panelLine;
        private Panel panelUnvanTbox;
        private Panel panel1;
        private TextBox textBoxName;
        private Panel panel2;
        private Button buttonAddSupervisor;
        private GroupBox groupBox1;
        private Panel panel5;
        private ComboBox comboBoxUnvan;
        private Panel panel6;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox comboBoxDurum;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dataGridView1;
    }
}