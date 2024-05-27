namespace GozetmenTakipSistemi.Views.Childs
{
    partial class ExamHallForm
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
            buttonDelete = new Button();
            panelCenter = new Panel();
            dataGridView1 = new DataGridView();
            panelForm = new Panel();
            groupBox1 = new GroupBox();
            labelCapacity = new Label();
            panel1 = new Panel();
            numericUpDownCapacity = new NumericUpDown();
            panel2 = new Panel();
            buttonAddDerslik = new Button();
            panelHallTbox = new Panel();
            textBoxNameHall = new TextBox();
            panelLine = new Panel();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelForm.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
            panelHallTbox.SuspendLayout();
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
            labelPageTitle.Text = "Derslik Listesi";
            labelPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ControlDarkDark;
            panelBottom.Controls.Add(buttonDelete);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 498);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(952, 60);
            panelBottom.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.FromArgb(62, 62, 62);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(786, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(154, 48);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Kayıt Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
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
            dataGridView1.Size = new Size(952, 212);
            dataGridView1.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(groupBox1);
            panelForm.Dock = DockStyle.Bottom;
            panelForm.Location = new Point(0, 212);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(952, 226);
            panelForm.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCapacity);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(buttonAddDerslik);
            groupBox1.Controls.Add(panelHallTbox);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(952, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Derslik Ekle";
            // 
            // labelCapacity
            // 
            labelCapacity.Anchor = AnchorStyles.None;
            labelCapacity.FlatStyle = FlatStyle.System;
            labelCapacity.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelCapacity.Location = new Point(339, 75);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(141, 25);
            labelCapacity.TabIndex = 10;
            labelCapacity.Text = "Derslik Kapasitesi:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(numericUpDownCapacity);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(339, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 40);
            panel1.TabIndex = 9;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 3);
            panel2.TabIndex = 5;
            // 
            // buttonAddDerslik
            // 
            buttonAddDerslik.Anchor = AnchorStyles.None;
            buttonAddDerslik.BackColor = Color.FromArgb(62, 62, 62);
            buttonAddDerslik.FlatAppearance.BorderSize = 0;
            buttonAddDerslik.FlatStyle = FlatStyle.Flat;
            buttonAddDerslik.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonAddDerslik.ForeColor = Color.White;
            buttonAddDerslik.Location = new Point(339, 158);
            buttonAddDerslik.Name = "buttonAddDerslik";
            buttonAddDerslik.Size = new Size(275, 48);
            buttonAddDerslik.TabIndex = 8;
            buttonAddDerslik.Text = "Derslik Ekle";
            buttonAddDerslik.UseVisualStyleBackColor = false;
            buttonAddDerslik.Click += buttonAddSupervisor_Click;
            // 
            // panelHallTbox
            // 
            panelHallTbox.Anchor = AnchorStyles.None;
            panelHallTbox.BackColor = Color.White;
            panelHallTbox.Controls.Add(textBoxNameHall);
            panelHallTbox.Controls.Add(panelLine);
            panelHallTbox.Location = new Point(339, 24);
            panelHallTbox.Name = "panelHallTbox";
            panelHallTbox.Size = new Size(275, 40);
            panelHallTbox.TabIndex = 7;
            // 
            // textBoxNameHall
            // 
            textBoxNameHall.BorderStyle = BorderStyle.None;
            textBoxNameHall.Dock = DockStyle.Bottom;
            textBoxNameHall.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxNameHall.Location = new Point(0, 8);
            textBoxNameHall.Name = "textBoxNameHall";
            textBoxNameHall.PlaceholderText = "Derslik Adı";
            textBoxNameHall.Size = new Size(275, 29);
            textBoxNameHall.TabIndex = 0;
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
            // ExamHallForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 558);
            ControlBox = false;
            Controls.Add(panelCenter);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExamHallForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamHallForm";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelForm.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            panelHallTbox.ResumeLayout(false);
            panelHallTbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelCenter;
        private Label labelPageTitle;
        private Panel panelForm;
        private GroupBox groupBox1;
        private Label labelCapacity;
        private Panel panel1;
        private NumericUpDown numericUpDownCapacity;
        private Panel panel2;
        private Button buttonAddDerslik;
        private Panel panelHallTbox;
        private TextBox textBoxNameHall;
        private Panel panelLine;
        private Button buttonDelete;
        private DataGridView dataGridView1;
    }
}