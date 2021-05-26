using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_brasserie
{
    class IngredientBio : Ingredient
    {
        private int numeroIngredient;

        public int NumeroIngredient { get => numeroIngredient; set => numeroIngredient = value; }

        public IngredientBio(int id, string fournisseur, string nom, int numero) : base(id, fournisseur, nom)
        {
            this.numeroIngredient = numero;
        }

        public void ajouterIngredientBio()
        {
            MySqlConnection conn;
            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            String myInsertQuery = "insert into bio (`idIngredient`, `fournisseurIngredient`, `nomIngredient`, `numeroBio`) VALUES (" + this.IdIngredient + " ,'" + this.FournisseurIngredient + "','" + this.NomIngredient + "', " + this.numeroIngredient + ")";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = conn;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }
    }
}
