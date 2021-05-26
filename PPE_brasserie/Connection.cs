using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_brasserie
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Bt_connection_Click(object sender, EventArgs e)
        {
            bool vf = false;



            MySqlConnection conn;

            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string requete = "select * from compte";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() && vf == false)
            {
                LesComptes c = new LesComptes(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());

                if (tb_utilisateur.Text == rdr[3].ToString() && tb_mdp.Text == rdr[4].ToString())
                {
                    vf = true;
                }
                else
                {
                    vf = false;
                }

            }
            if (vf == true)
            {
                MessageBox.Show("Vous êtes connecter");
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur et/ou Mot de passe incorrecte");
                tb_mdp.Text = "";
                tb_utilisateur.Text = "";
            }
            rdr.Close();
            conn.Close();
        }
    }
}
