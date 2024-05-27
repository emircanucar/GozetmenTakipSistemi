namespace GozetmenTakipSistemi.Views.Controls
{
    partial class ClockControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelClock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelClock
            // 
            labelClock.Dock = DockStyle.Fill;
            labelClock.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelClock.Location = new Point(0, 0);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(117, 23);
            labelClock.TabIndex = 0;
            labelClock.Text = "labelClock";
            labelClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ClockControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelClock);
            Name = "ClockControl";
            Size = new Size(117, 23);
            Load += ClockControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelClock;
        private System.Windows.Forms.Timer timer1;
    }
}
