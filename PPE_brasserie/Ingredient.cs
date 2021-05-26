using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_brasserie
{
    class Ingredient
    {
        private int idIngredient;
        private string fournisseurIngredient;
        private string nomIngredient;

        public int IdIngredient {
            get => idIngredient;
            set => idIngredient = value;
        }
        public string FournisseurIngredient {
            get => fournisseurIngredient;
            set => fournisseurIngredient = value;
        }
        public string NomIngredient {
            get => nomIngredient;
            set => nomIngredient = value;
        }

        public Ingredient(/*int id,*/ string fournisseur, string nom)
        {
            //this.idIngredient = id;
            this.fournisseurIngredient = fournisseur;
            this.nomIngredient = nom;
        }

        public Ingredient(int id, string fournisseur, string nom)
        {
            this.idIngredient = id;
            this.fournisseurIngredient = fournisseur;
            this.nomIngredient = nom;
        }

        public void supprimerIngredient(int c)
        {
            MySqlConnection conn;
            //string myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            string myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "delete from composition WHERE idIngredient = " + c;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            myInsertQuery = "delete from ingredient WHERE idIngredient = " + c;
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }
        public void ajouterIngredient()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "insert into ingredient (`fournisseurIngredient`, `nomIngredient`) VALUES ('" + this.fournisseurIngredient + "','" + this.nomIngredient + "')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }
        public void modifierIngredient(int n)
        {
            MySqlConnection conn;
            //string myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            string myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "update ingredient set fournisseurIngredient = '" + this.fournisseurIngredient + "', nomIngredient = '" + this.nomIngredient + "' WHERE idIngredient = " + n;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }

        public int IdDeIngredient()
        {
            MySqlConnection conn;

            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string requete = "select * from ingredient WHERE fournisseurIngredient = '" + this.fournisseurIngredient + "' AND nomIngredient = '" + this.nomIngredient +"'";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                idIngredient = Convert.ToInt32(rdr[0]);
            }
            rdr.Close();
            conn.Close();
            return idIngredient;
        }

        public bool bioOuPas()
        {
            bool resultat = false; // non bio
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "select * from bio";
            MySqlCommand cmd = new MySqlCommand(myInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (resultat == false)
                {
                    if (Convert.ToInt32(rdr[0]) == this.idIngredient)
                    {
                        resultat = true; //bio
                    }
                    else
                    {
                        resultat = false; // non bio
                    }
                }
            }

            conn.Close();
            return resultat;
        }
    }
}
