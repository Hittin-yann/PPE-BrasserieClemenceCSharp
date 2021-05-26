using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_brasserie
{
    class Composition
    {
        private int idIngredient;
        private int idRecette;
        private double quantite;

        public int IdIngredient {
            get => idIngredient;
            set => idIngredient = value;
        }
        public int IdRecette {
            get => idRecette;
            set => idRecette = value;
        }
        public double Quantite {
            get => quantite;
            set => quantite = value;
        }
        public Composition(int idIng, int idRec, double q)
        {
            this.idIngredient = idIng;
            this.idRecette = idRec;
            this.quantite = q;
        }

        public void ajoutComposition()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string quantite = this.quantite.ToString();
            string quantiteNeuf = quantite.Replace(",",".");

            String myInsertQuery = "insert into composition (`idIngredient`, `idRecette`,`quantite`) VALUES (" + this.idIngredient + "," + this.idRecette + "," + quantiteNeuf + ")";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }

        public void supprComposition()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "DELETE FROM composition WHERE idRecette = " + this.idRecette;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }
    }
}
