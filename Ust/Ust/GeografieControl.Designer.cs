
namespace Ust
{
    partial class GeografieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.facultate = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.spec = new System.Windows.Forms.ComboBox();
            this.ciclu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_cerere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.facultate);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 90);
            this.panel1.TabIndex = 21;
            // 
            // facultate
            // 
            this.facultate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.facultate.AutoSize = true;
            this.facultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultate.ForeColor = System.Drawing.Color.Black;
            this.facultate.Location = new System.Drawing.Point(314, 25);
            this.facultate.Name = "facultate";
            this.facultate.Size = new System.Drawing.Size(201, 36);
            this.facultate.TabIndex = 1;
            this.facultate.Text = "GEOGRAFIE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(207, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 35);
            this.linkLabel1.TabIndex = 0;
            // 
            // spec
            // 
            this.spec.DropDownWidth = 500;
            this.spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.FormattingEnabled = true;
            this.spec.Location = new System.Drawing.Point(445, 183);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(468, 37);
            this.spec.TabIndex = 58;
            // 
            // ciclu
            // 
            this.ciclu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciclu.FormattingEnabled = true;
            this.ciclu.Items.AddRange(new object[] {
            "I (ZI)",
            "I (FR)",
            "II"});
            this.ciclu.Location = new System.Drawing.Point(445, 110);
            this.ciclu.Name = "ciclu";
            this.ciclu.Size = new System.Drawing.Size(468, 37);
            this.ciclu.TabIndex = 57;
            this.ciclu.SelectedValueChanged += new System.EventHandler(this.ciclu_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Selectează specialitatea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Selecteaza Ciclul";
            // 
            // nm
            // 
            this.nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm.Location = new System.Drawing.Point(321, 411);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(101, 34);
            this.nm.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nota medie";
            // 
            // prenume
            // 
            this.prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenume.Location = new System.Drawing.Point(321, 334);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(245, 34);
            this.prenume.TabIndex = 52;
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.Location = new System.Drawing.Point(321, 260);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(245, 34);
            this.nume.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 50;
            this.label8.Text = "Prenume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 49;
            this.label9.Text = "Nume";
            // 
            // bt_cerere
            // 
            this.bt_cerere.BackColor = System.Drawing.Color.Gold;
            this.bt_cerere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerere.Location = new System.Drawing.Point(600, 411);
            this.bt_cerere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cerere.Name = "bt_cerere";
            this.bt_cerere.Size = new System.Drawing.Size(197, 33);
            this.bt_cerere.TabIndex = 48;
            this.bt_cerere.Text = "Creaza o cerere";
            this.bt_cerere.UseVisualStyleBackColor = false;
            this.bt_cerere.Click += new System.EventHandler(this.bt_cerere_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 489);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 150);
            this.dataGridView1.TabIndex = 60;
            // 
            // GeografieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.ciclu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_cerere);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeografieControl";
            this.Size = new System.Drawing.Size(961, 665);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label facultate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox spec;
        private System.Windows.Forms.ComboBox ciclu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_cerere;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
