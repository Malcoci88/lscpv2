
namespace Ust
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fil_btn = new System.Windows.Forms.Label();
            this.ped_btn = new System.Windows.Forms.Label();
            this.bio_btn = new System.Windows.Forms.Label();
            this.geo_btn = new System.Windows.Forms.Label();
            this.fmti_btn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 113);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ust.Properties.Resources._999;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMITERE 2021";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(237, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(599, 35);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "UNIVERSITATEA DE STAT DIN TIRASPOL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.fil_btn);
            this.panel2.Controls.Add(this.ped_btn);
            this.panel2.Controls.Add(this.bio_btn);
            this.panel2.Controls.Add(this.geo_btn);
            this.panel2.Controls.Add(this.fmti_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 532);
            this.panel2.TabIndex = 1;
            // 
            // fil_btn
            // 
            this.fil_btn.AutoSize = true;
            this.fil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fil_btn.Location = new System.Drawing.Point(11, 223);
            this.fil_btn.Name = "fil_btn";
            this.fil_btn.Size = new System.Drawing.Size(125, 25);
            this.fil_btn.TabIndex = 5;
            this.fil_btn.Text = "FILOLOGIE";
            this.fil_btn.Click += new System.EventHandler(this.fil_btn_Click);
            this.fil_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.fil_btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // ped_btn
            // 
            this.ped_btn.AutoSize = true;
            this.ped_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ped_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ped_btn.Location = new System.Drawing.Point(11, 194);
            this.ped_btn.Name = "ped_btn";
            this.ped_btn.Size = new System.Drawing.Size(139, 25);
            this.ped_btn.TabIndex = 4;
            this.ped_btn.Text = "PEDAGOGIE";
            this.ped_btn.Click += new System.EventHandler(this.ped_btn_Click);
            this.ped_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.ped_btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // bio_btn
            // 
            this.bio_btn.AutoSize = true;
            this.bio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bio_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bio_btn.Location = new System.Drawing.Point(11, 135);
            this.bio_btn.Name = "bio_btn";
            this.bio_btn.Size = new System.Drawing.Size(147, 50);
            this.bio_btn.TabIndex = 3;
            this.bio_btn.Text = "BIOLOGIE SI \r\nCHIMIE";
            this.bio_btn.Click += new System.EventHandler(this.bio_btn_Click);
            this.bio_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.bio_btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // geo_btn
            // 
            this.geo_btn.AutoSize = true;
            this.geo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geo_btn.Location = new System.Drawing.Point(11, 107);
            this.geo_btn.Name = "geo_btn";
            this.geo_btn.Size = new System.Drawing.Size(137, 25);
            this.geo_btn.TabIndex = 2;
            this.geo_btn.Text = "GEOGRAFIE";
            this.geo_btn.Click += new System.EventHandler(this.geo_btn_Click);
            this.geo_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.geo_btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // fmti_btn
            // 
            this.fmti_btn.AutoSize = true;
            this.fmti_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fmti_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmti_btn.Location = new System.Drawing.Point(11, 82);
            this.fmti_btn.Name = "fmti_btn";
            this.fmti_btn.Size = new System.Drawing.Size(63, 25);
            this.fmti_btn.TabIndex = 1;
            this.fmti_btn.Text = "FMTI";
            this.fmti_btn.Click += new System.EventHandler(this.fmti_btn_Click);
            this.fmti_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.fmti_btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "FACULTATI";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(183, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 532);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fil_btn;
        private System.Windows.Forms.Label ped_btn;
        private System.Windows.Forms.Label bio_btn;
        private System.Windows.Forms.Label geo_btn;
        private System.Windows.Forms.Label fmti_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}

