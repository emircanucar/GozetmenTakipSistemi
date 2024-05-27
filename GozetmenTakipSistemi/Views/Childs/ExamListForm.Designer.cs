namespace GozetmenTakipSistemi.Views.Childs
{
    partial class ExamListForm
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
            button2 = new Button();
            labelPageTitle = new Label();
            panelCenter = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            TimePicker = new DateTimePicker();
            datePicker = new DateTimePicker();
            panel9 = new Panel();
            comboBoxDerslik = new ComboBox();
            panel10 = new Panel();
            panel7 = new Panel();
            textBoxBolum = new TextBox();
            panel8 = new Panel();
            panel5 = new Panel();
            comboBoxEleman = new ComboBox();
            panel6 = new Panel();
            panel3 = new Panel();
            textBoxDersKodu = new TextBox();
            panel4 = new Panel();
            labelCapacity = new Label();
            panel2 = new Panel();
            numericUpDownCapacity = new NumericUpDown();
            panel12 = new Panel();
            buttonAddExam = new Button();
            panelHallTbox = new Panel();
            textBoxDersAdi = new TextBox();
            panelLine = new Panel();
            panelTop.SuspendLayout();
            panelCenter.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
            panelHallTbox.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ControlDarkDark;
            panelTop.Controls.Add(button2);
            panelTop.Controls.Add(labelPageTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(952, 60);
            panelTop.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(62, 62, 62);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(779, 4);
            button2.Name = "button2";
            button2.Size = new Size(169, 50);
            button2.TabIndex = 19;
            button2.Text = "Kayıt Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            labelPageTitle.Text = "Derslik Listesi";
            labelPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = SystemColors.Control;
            panelCenter.Controls.Add(tabControl1);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 60);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(952, 616);
            panelCenter.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(20, 16);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(952, 616);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 57);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(944, 555);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sınav Listesi";
            tabPage1.UseVisualStyleBackColor = true;
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
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(944, 555);
            dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.BackColor = SystemColors.ControlLight;
            tabPage2.Controls.Add(TimePicker);
            tabPage2.Controls.Add(datePicker);
            tabPage2.Controls.Add(panel9);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(labelCapacity);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(buttonAddExam);
            tabPage2.Controls.Add(panelHallTbox);
            tabPage2.Location = new Point(4, 57);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(944, 555);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sınav Ekle";
            // 
            // TimePicker
            // 
            TimePicker.Anchor = AnchorStyles.Top;
            TimePicker.CalendarFont = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TimePicker.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.Location = new Point(509, 317);
            TimePicker.Name = "TimePicker";
            TimePicker.ShowUpDown = true;
            TimePicker.Size = new Size(96, 36);
            TimePicker.TabIndex = 26;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Top;
            datePicker.CalendarFont = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            datePicker.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(330, 317);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(173, 36);
            datePicker.TabIndex = 25;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = Color.White;
            panel9.Controls.Add(comboBoxDerslik);
            panel9.Controls.Add(panel10);
            panel9.Enabled = false;
            panel9.Location = new Point(330, 251);
            panel9.Name = "panel9";
            panel9.Size = new Size(275, 40);
            panel9.TabIndex = 24;
            panel9.Visible = false;
            // 
            // comboBoxDerslik
            // 
            comboBoxDerslik.DisplayMember = "ascacsacs";
            comboBoxDerslik.Dock = DockStyle.Bottom;
            comboBoxDerslik.FlatStyle = FlatStyle.Flat;
            comboBoxDerslik.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxDerslik.FormattingEnabled = true;
            comboBoxDerslik.Location = new Point(0, 6);
            comboBoxDerslik.Name = "comboBoxDerslik";
            comboBoxDerslik.Size = new Size(275, 31);
            comboBoxDerslik.TabIndex = 3;
            comboBoxDerslik.Tag = "";
            comboBoxDerslik.Text = "Derslik";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ControlDarkDark;
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 37);
            panel10.Name = "panel10";
            panel10.Size = new Size(275, 3);
            panel10.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackColor = Color.White;
            panel7.Controls.Add(textBoxBolum);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(330, 193);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 40);
            panel7.TabIndex = 23;
            // 
            // textBoxBolum
            // 
            textBoxBolum.BorderStyle = BorderStyle.None;
            textBoxBolum.Dock = DockStyle.Bottom;
            textBoxBolum.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBolum.Location = new Point(0, 8);
            textBoxBolum.Name = "textBoxBolum";
            textBoxBolum.PlaceholderText = "Bölüm";
            textBoxBolum.Size = new Size(275, 29);
            textBoxBolum.TabIndex = 0;
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
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(comboBoxEleman);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(330, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 40);
            panel5.TabIndex = 22;
            // 
            // comboBoxEleman
            // 
            comboBoxEleman.Dock = DockStyle.Bottom;
            comboBoxEleman.FlatStyle = FlatStyle.Flat;
            comboBoxEleman.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxEleman.FormattingEnabled = true;
            comboBoxEleman.Location = new Point(0, 6);
            comboBoxEleman.Name = "comboBoxEleman";
            comboBoxEleman.Size = new Size(275, 31);
            comboBoxEleman.TabIndex = 3;
            comboBoxEleman.Tag = "";
            comboBoxEleman.Text = "Öğretim Elemanı";
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBoxDersKodu);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(330, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 40);
            panel3.TabIndex = 21;
            // 
            // textBoxDersKodu
            // 
            textBoxDersKodu.BorderStyle = BorderStyle.None;
            textBoxDersKodu.Dock = DockStyle.Bottom;
            textBoxDersKodu.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxDersKodu.Location = new Point(0, 8);
            textBoxDersKodu.Name = "textBoxDersKodu";
            textBoxDersKodu.PlaceholderText = "Ders Kodu";
            textBoxDersKodu.Size = new Size(275, 29);
            textBoxDersKodu.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 3);
            panel4.TabIndex = 2;
            // 
            // labelCapacity
            // 
            labelCapacity.Anchor = AnchorStyles.Top;
            labelCapacity.FlatStyle = FlatStyle.System;
            labelCapacity.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelCapacity.Location = new Point(330, 372);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(141, 25);
            labelCapacity.TabIndex = 20;
            labelCapacity.Text = "Öğrenci Sayısı";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(numericUpDownCapacity);
            panel2.Controls.Add(panel12);
            panel2.Location = new Point(330, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 40);
            panel2.TabIndex = 19;
            // 
            // numericUpDownCapacity
            // 
            numericUpDownCapacity.BorderStyle = BorderStyle.None;
            numericUpDownCapacity.Dock = DockStyle.Bottom;
            numericUpDownCapacity.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDownCapacity.Location = new Point(0, 5);
            numericUpDownCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCapacity.Name = "numericUpDownCapacity";
            numericUpDownCapacity.Size = new Size(275, 32);
            numericUpDownCapacity.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlDarkDark;
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 37);
            panel12.Name = "panel12";
            panel12.Size = new Size(275, 3);
            panel12.TabIndex = 5;
            // 
            // buttonAddExam
            // 
            buttonAddExam.Anchor = AnchorStyles.Top;
            buttonAddExam.BackColor = Color.FromArgb(62, 62, 62);
            buttonAddExam.FlatAppearance.BorderSize = 0;
            buttonAddExam.FlatStyle = FlatStyle.Flat;
            buttonAddExam.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonAddExam.ForeColor = Color.White;
            buttonAddExam.Location = new Point(330, 469);
            buttonAddExam.Name = "buttonAddExam";
            buttonAddExam.Size = new Size(275, 48);
            buttonAddExam.TabIndex = 18;
            buttonAddExam.Text = "Sınav Ekle";
            buttonAddExam.UseVisualStyleBackColor = false;
            buttonAddExam.Click += buttonAddExam_Click;
            // 
            // panelHallTbox
            // 
            panelHallTbox.Anchor = AnchorStyles.Top;
            panelHallTbox.BackColor = Color.White;
            panelHallTbox.Controls.Add(textBoxDersAdi);
            panelHallTbox.Controls.Add(panelLine);
            panelHallTbox.Location = new Point(330, 12);
            panelHallTbox.Name = "panelHallTbox";
            panelHallTbox.Size = new Size(275, 40);
            panelHallTbox.TabIndex = 17;
            // 
            // textBoxDersAdi
            // 
            textBoxDersAdi.BorderStyle = BorderStyle.None;
            textBoxDersAdi.Dock = DockStyle.Bottom;
            textBoxDersAdi.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxDersAdi.Location = new Point(0, 8);
            textBoxDersAdi.Name = "textBoxDersAdi";
            textBoxDersAdi.PlaceholderText = "Ders Adı";
            textBoxDersAdi.Size = new Size(275, 29);
            textBoxDersAdi.TabIndex = 0;
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
            // ExamListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 676);
            ControlBox = false;
            Controls.Add(panelCenter);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExamListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamListForm";
            Load += ExamListForm_Load;
            panelTop.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            panelHallTbox.ResumeLayout(false);
            panelHallTbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelCenter;
        private Label labelPageTitle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker TimePicker;
        private DateTimePicker datePicker;
        private Panel panel9;
        private ComboBox comboBoxDerslik;
        private Panel panel10;
        private Panel panel7;
        private TextBox textBoxBolum;
        private Panel panel8;
        private Panel panel5;
        private ComboBox comboBoxEleman;
        private Panel panel6;
        private Panel panel3;
        private TextBox textBoxDersKodu;
        private Panel panel4;
        private Label labelCapacity;
        private Panel panel2;
        private NumericUpDown numericUpDownCapacity;
        private Panel panel12;
        private Button buttonAddExam;
        private Panel panelHallTbox;
        private TextBox textBoxDersAdi;
        private Panel panelLine;
        private Button button2;
        private DataGridView dataGridView1;
    }
}