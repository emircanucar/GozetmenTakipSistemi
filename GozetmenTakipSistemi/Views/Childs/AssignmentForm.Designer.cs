namespace GozetmenTakipSistemi.Views.Childs
{
    partial class AssignmentForm
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
            panelCenter = new Panel();
            panelForm = new Panel();
            groupBox1 = new GroupBox();
            buttonExportExcel = new Button();
            btnAtamaYap = new Button();
            dataGridView1 = new DataGridView();
            panelTop.SuspendLayout();
            panelCenter.SuspendLayout();
            panelForm.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            labelPageTitle.Text = "Gözetmen Ata";
            labelPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ControlDarkDark;
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 498);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(952, 60);
            panelBottom.TabIndex = 1;
            // 
            // panelCenter
            // 
            panelCenter.AutoScroll = true;
            panelCenter.BackColor = SystemColors.Control;
            panelCenter.Controls.Add(panelForm);
            panelCenter.Controls.Add(dataGridView1);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 60);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(952, 438);
            panelCenter.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(groupBox1);
            panelForm.Dock = DockStyle.Bottom;
            panelForm.Location = new Point(0, 253);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(952, 185);
            panelForm.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonExportExcel);
            groupBox1.Controls.Add(btnAtamaYap);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(952, 179);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atama Yap";
            // 
            // buttonExportExcel
            // 
            buttonExportExcel.Anchor = AnchorStyles.None;
            buttonExportExcel.BackColor = Color.FromArgb(62, 62, 62);
            buttonExportExcel.FlatAppearance.BorderSize = 0;
            buttonExportExcel.FlatStyle = FlatStyle.Flat;
            buttonExportExcel.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonExportExcel.ForeColor = Color.White;
            buttonExportExcel.Location = new Point(329, 99);
            buttonExportExcel.Name = "buttonExportExcel";
            buttonExportExcel.Size = new Size(275, 60);
            buttonExportExcel.TabIndex = 3;
            buttonExportExcel.Text = "Excel Olarak Çıkar";
            buttonExportExcel.UseVisualStyleBackColor = false;
            buttonExportExcel.Click += buttonExportExcel_Click;
            // 
            // btnAtamaYap
            // 
            btnAtamaYap.Anchor = AnchorStyles.None;
            btnAtamaYap.BackColor = Color.FromArgb(62, 62, 62);
            btnAtamaYap.FlatAppearance.BorderSize = 0;
            btnAtamaYap.FlatStyle = FlatStyle.Flat;
            btnAtamaYap.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAtamaYap.ForeColor = Color.White;
            btnAtamaYap.Location = new Point(329, 33);
            btnAtamaYap.Name = "btnAtamaYap";
            btnAtamaYap.Size = new Size(275, 60);
            btnAtamaYap.TabIndex = 3;
            btnAtamaYap.Text = "Atama Yap";
            btnAtamaYap.UseVisualStyleBackColor = false;
            btnAtamaYap.Click += btnAtamaYap_Click;
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
            dataGridView1.Size = new Size(952, 438);
            dataGridView1.TabIndex = 0;
            // 
            // AssignmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 558);
            ControlBox = false;
            Controls.Add(panelCenter);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssignmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignmentForm";
            panelTop.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelCenter;
        private Label labelPageTitle;
        private DataGridView dataGridView1;
        private Panel panelForm;
        private Button btnAtamaYap;
        private GroupBox groupBox1;
        private Button button2;
        private Button buttonExportExcel;
    }
}