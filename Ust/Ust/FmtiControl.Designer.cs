
namespace Ust
{
    partial class FmtiControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.facultate = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.spec = new System.Windows.Forms.ComboBox();
            this.ciclu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_cerere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.facultate);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 90);
            this.panel2.TabIndex = 22;
            // 
            // facultate
            // 
            this.facultate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.facultate.AutoSize = true;
            this.facultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultate.ForeColor = System.Drawing.Color.Black;
            this.facultate.Location = new System.Drawing.Point(340, 25);
            this.facultate.Name = "facultate";
            this.facultate.Size = new System.Drawing.Size(88, 36);
            this.facultate.TabIndex = 1;
            this.facultate.Text = "FMTI";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(139, 25);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 35);
            this.linkLabel2.TabIndex = 0;
            // 
            // spec
            // 
            this.spec.DropDownWidth = 500;
            this.spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.FormattingEnabled = true;
            this.spec.Location = new System.Drawing.Point(374, 173);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(329, 37);
            this.spec.TabIndex = 58;
            // 
            // ciclu
            // 
            this.ciclu.AccessibleDescription = "cic";
            this.ciclu.AccessibleName = "";
            this.ciclu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciclu.FormattingEnabled = true;
            this.ciclu.Items.AddRange(new object[] {
            "I (ZI)",
            "I (FR)",
            "II"});
            this.ciclu.Location = new System.Drawing.Point(374, 92);
            this.ciclu.Name = "ciclu";
            this.ciclu.Size = new System.Drawing.Size(329, 37);
            this.ciclu.TabIndex = 57;
            this.ciclu.SelectedValueChanged += new System.EventHandler(this.ciclu_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Selectează specialitatea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Selecteaza Ciclul";
            // 
            // nm
            // 
            this.nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm.Location = new System.Drawing.Point(250, 393);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(101, 34);
            this.nm.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nota medie";
            // 
            // prenume
            // 
            this.prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenume.Location = new System.Drawing.Point(250, 316);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(245, 34);
            this.prenume.TabIndex = 52;
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.Location = new System.Drawing.Point(250, 242);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(245, 34);
            this.nume.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 50;
            this.label8.Text = "Prenume";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 29);
            this.label14.TabIndex = 49;
            this.label14.Text = "Nume";
            // 
            // bt_cerere
            // 
            this.bt_cerere.BackColor = System.Drawing.Color.Gold;
            this.bt_cerere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerere.Location = new System.Drawing.Point(529, 393);
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 150);
            this.dataGridView1.TabIndex = 59;
            // 
            // FmtiControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.ciclu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt_cerere);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmtiControl";
            this.Size = new System.Drawing.Size(825, 653);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label facultate;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox spec;
        private System.Windows.Forms.ComboBox ciclu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_cerere;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
