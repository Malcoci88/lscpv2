using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ust
{
    public partial class CreateRequestControl : UserControl
    {
        public CreateRequestControl()
        {
            InitializeComponent();
           /* database();*/
        }
        /*public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\post\Ust\EDITAT\Ust\Ust\Database1.mdf;Integrated Security=True";
        public void database()
        {
            using (var conn = new SqlConnection(connString))
            {
                string sqlString = "SELECT * FROM RegistredRequest";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var ciclu = new Label();
                        var frecventa = new Label();

                        ciclu.Text = reader["Ciclu"].ToString();
                        frecventa.Text = reader["Frecventa"].ToString();

                        ciclu.Font = frecventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                        tableLayoutPanel1.Controls.Add(ciclu);
                        tableLayoutPanel1.Controls.Add(frecventa);
                    }
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Alegeti ciclu");
                return;
            }

            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Alegeti frecventa");
                return;
            }

            string ciclu = "";
            string frecventa = "";
            if (radioButton1.Checked)
            {
                ciclu = "Licenta";
            }
            else if (radioButton2.Checked)
            {
                ciclu = "Masterat";
            }
            if (radioButton3.Checked)
            {
                frecventa = "Frecventa";
            }
            else if (radioButton4.Checked)
            {
                frecventa = "Frecventa redusa";
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = "INSERT INTO RegistredRequest (Ciclu, Frecventa) VALUES(@ciclu,@frecventa);";
                conn.Open();
                SqlCommand command = new SqlCommand(sqlString, conn);
                command.Parameters.AddWithValue("@ciclu", ciclu);
                command.Parameters.AddWithValue("@frecventa", frecventa);

                command.ExecuteNonQuery();
                var cicluControl = new Label();
                var frecventaControl = new Label();

                cicluControl.Text = ciclu;
                frecventaControl.Text = frecventa;

                cicluControl.Font = frecventaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);

                tableLayoutPanel1.Controls.Add(cicluControl);
                tableLayoutPanel1.Controls.Add(frecventaControl);
            }
        }*/
    }
}
