using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ust
{
    public partial class FmtiControl : UserControl
    {



        public FmtiControl()
        {

            InitializeComponent();
            getdataformSQL();
            

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ciclu_SelectedValueChanged(object sender, EventArgs e)
        {
            String fname = nume.Text;
            String lname = prenume.Text;
            String ciclul = ciclu.Text;
            String special = spec.Text;
            String notam = nm.Text;

            DB db = new DB();

            db.oppenConnection();
            string command = "select specialitate from admitere where facultate = '" + facultate.Text + "' and ciclu='" + ciclul + "'";
            MySqlDataReader reader = new MySqlCommand(command, db.getConnection()).ExecuteReader();

            List<string> ciclu1 = new List<string>();

            while (reader.Read())
                ciclu1.Add(reader[0].ToString());

            spec.Items.Clear();
            foreach (string item in ciclu1)
                spec.Items.Add(item);

            db.closedConnection();


        }

        private void bt_cerere_Click(object sender, EventArgs e)
        {
            String fname = nume.Text;
            String lname = prenume.Text;
            String ciclul = ciclu.Text;
            String special = spec.Text;
            String notam = nm.Text;

            if ((fname != "") & (lname != "") & (ciclul != "") & (special != "") & (notam != ""))
            {
        
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `cerere_fmti` (`nume`, `prenume`, `notamedie`, `facultatea`, `ciclu`, `specialitatea`) VALUES (@num, @pre, @nm, @fac, @cic, @spec);", db.getConnection());
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@pre", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = notam;
            command.Parameters.Add("@fac", MySqlDbType.VarChar).Value = facultate.Text;
            command.Parameters.Add("@cic", MySqlDbType.VarChar).Value = ciclul;
            command.Parameters.Add("@spec", MySqlDbType.VarChar).Value = special;

            db.oppenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Cererea a fost transmisa cu succes!");
            else
                MessageBox.Show("Eroare!!! Cererea n-a fost transmisa!");

            db.closedConnection();

            getdataformSQL();
        }
            else MessageBox.Show("Eroare!!! Indeplineste toate campurile");
     }
      
        void getdataformSQL()
        {
            DB db = new DB();

            db.oppenConnection();


            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = new MySqlCommand("select * from cerere_fmti ", db.getConnection());

            dt.Clear();
            da.Fill(dt);
            db.closedConnection();

            dataGridView1.DataSource = dt;



        }
    }   }
