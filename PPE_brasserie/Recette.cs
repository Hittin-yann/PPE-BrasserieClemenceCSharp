using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_brasserie
{
    class Recette
    {
        private int idRecette;
        private string nomRecette;
        private string dateCreation;
        private List<Ingredient> lesCompositions;

        public Recette(string nR, string dC, List<Ingredient> l)
        {
            //idRecette = iR;
            nomRecette = nR;
            dateCreation = dC;
            lesCompositions = l;
        }

        public Recette(int iR,string nR, string dC, List<Ingredient> l)
        {
            idRecette = iR;
            nomRecette = nR;
            dateCreation = dC;
            lesCompositions = l;
        }

        public int IdRecette
        {
            get => idRecette;
            set => idRecette = value;
        }
        public string NomRecette
        {
            get => nomRecette;
            set => nomRecette = value;
        }
        public string DateCreation
        {
            get => dateCreation;
            set => dateCreation = value;
        }

        public void ajoutRecette()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "insert into recette (`nomRecette`, `dateCreation`) VALUES ('" + this.nomRecette + "','" + this.dateCreation + "')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            myInsertQuery = "select * from recette where nomRecette = '" + this.nomRecette + "' AND dateCreation = '"+ this.dateCreation +"'";
            MySqlCommand cmd = new MySqlCommand(myInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                this.idRecette = Convert.ToInt32(rdr[0].ToString());
                //MessageBox.Show(this.idRecette.ToString());
            }

            conn.Close();
        }
        public void modifierRecette(int id)
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "update recette set nomRecette = '" + this.nomRecette + "', dateCreation = '" + this.dateCreation + "' WHERE idRecette = " + id;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }
        public void supprimerRecette(int id)
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "DELETE FROM composition WHERE idRecette = " + id;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            myInsertQuery = "DELETE FROM recette WHERE idRecette = " + id;
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }

        public Dictionary<string, double> quantiteIndredient()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "SELECT ingredient.nomIngredient ,composition.quantite FROM `composition` INNER JOIN ingredient ON composition.idIngredient = ingredient.idIngredient WHERE composition.idRecette = " + this.idRecette + ";";
            MySqlCommand cmd = new MySqlCommand(myInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Dictionary<string, double> NomEtQuantite = new Dictionary<string, double>();

            while (rdr.Read())
            {
                NomEtQuantite.Add(rdr[0].ToString(), Convert.ToDouble(rdr[1]) );
            }
            conn.Close();
            return NomEtQuantite;
        }

        public string bioOuPas()
        {
            this.lesCompositions = this.listIngredient();
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

            /* PREMIER TECHNIQUE
            foreach (Ingredient leIngredient in lesCompositions)
            {
                if (resultat == true) // si l'ingrédient précedent est bio
                {
                    while (rdr.Read())
                    {
                        if (Convert.ToInt32(rdr[0]) == leIngredient.IdIngredient)
                        {
                            resultat = true; //bio
                            break;
                        }
                        else
                        {
                            resultat = false; // non bio
                        }
                    }
                }
            }*/

            // DEUXIEME TECHNIQUE
            int nbIngredientBio = 0;
            while (rdr.Read())
            {
                resultat = false; // non bio
                foreach (Ingredient leIngredient in lesCompositions)
                {
                    if (resultat == false)
                    {
                        if (Convert.ToInt32(rdr[0]) == leIngredient.IdIngredient)
                        {
                            resultat = true; //bio
                            nbIngredientBio++;
                            //break;
                        }
                        else
                        {
                            resultat = false; // non bio
                        }
                    }
                }
            }

            conn.Close();
            if (nbIngredientBio == this.lesCompositions.Count())
            {
                return "Votre recette est bio";
            }
            else
            {
                return "Votre recette n'est pas bio";
            }

        }

        public List<Ingredient> listIngredient()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "select ingredient.* FROM ingredient INNER JOIN composition ON ingredient.idIngredient = composition.idIngredient WHERE composition.idRecette = " + this.IdRecette + ";";
            MySqlCommand cmd = new MySqlCommand(myInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Ingredient> resultat = new List<Ingredient>();

            while (rdr.Read())
            {
                Ingredient i = new Ingredient(Convert.ToInt32(rdr[0]),rdr[1].ToString(),rdr[2].ToString());
                resultat.Add(i);
            }
            return resultat;
        }

        public List<Recette> lesRecettes()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "select * FROM recette;";
            MySqlCommand cmd = new MySqlCommand(myInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Recette> listRecettes = new List<Recette>();

            while (rdr.Read())
            {
                Recette r = new Recette(Convert.ToInt32(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), this.lesCompositions);
                //r.lesCompositions = r.listIngredient();
                listRecettes.Add(r);
            }
            return listRecettes;
        }
    }
}
