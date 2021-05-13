using System.Drawing;
using System.Windows.Forms;

namespace Ust
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void AddToPanel(Control userControl)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
        }
    

        private void fmti_btn_Click(object sender, System.EventArgs e)
        {
            AddToPanel(new FmtiControl());
        }

        private void geo_btn_Click(object sender, System.EventArgs e)
        {
            AddToPanel(new GeografieControl());
        }

        private void bio_btn_Click(object sender, System.EventArgs e)
        {
            AddToPanel(new BioAndChimieControl());
        }

        private void ped_btn_Click(object sender, System.EventArgs e)
        {
            AddToPanel(new PedagogieControl());
        }

        private void fil_btn_Click(object sender, System.EventArgs e)
        {
            AddToPanel(new FilologieControl());
        }

        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            if (sender.Equals(fmti_btn))
            {
                fmti_btn.ForeColor = Color.Blue;
            }
            else if (sender.Equals(geo_btn))
            {
                geo_btn.ForeColor = Color.Blue;
            }
            else if (sender.Equals(bio_btn))
            {
                bio_btn.ForeColor = Color.Blue;
            }
            else if (sender.Equals(ped_btn))
            {
                ped_btn.ForeColor = Color.Blue;
            }
            else if (sender.Equals(fil_btn))
            {
                fil_btn.ForeColor = Color.Blue;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            if (sender.Equals(fmti_btn))
            {
                fmti_btn.ForeColor = Color.Black;
            }
            else if (sender.Equals(geo_btn))
            {
                geo_btn.ForeColor = Color.Black;
            }
            else if (sender.Equals(bio_btn))
            {
                bio_btn.ForeColor = Color.Black;
            }
            else if (sender.Equals(ped_btn))
            {
                ped_btn.ForeColor = Color.Black;
            }
            else if (sender.Equals(fil_btn))
            {
                fil_btn.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Controls.Clear();
        }
    }
}
