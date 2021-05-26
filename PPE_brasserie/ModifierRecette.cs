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
    public partial class ModifierRecette : Form
    {
        private int idRecette;
        public ModifierRecette(int n)
        {
            InitializeComponent();
            this.idRecette = n;
            AfficherIngredient();
        }

        private void bt_modifierRecette_Click(object sender, EventArgs e)
        {
            Composition supprimer = new Composition(0,idRecette,0);
            supprimer.supprComposition();
            List<Ingredient> lesIngredients = new List<Ingredient>();
            string[] Ingredients = new string[listBox_ModifRecette.SelectedItems.Count];
            listBox_ModifRecette.SelectedItems.CopyTo(Ingredients, 0);
            for (int i = 0; i < listBox_ModifRecette.SelectedItems.Count; i++)
            {
                string[] liste = Ingredients.ElementAt(i).Split(' ');
                int idIngredient = Convert.ToInt32(liste[2]);
                Object o = Form1.IngredientAt(idIngredient);
                Ingredient ing = (Ingredient)o;
                lesIngredients.Add(ing);
            }

            Recette x = new Recette(tb_nomModifRecette.Text, tb_dateModifRecette.Text, lesIngredients);
            x.modifierRecette(idRecette);

            int y = 0;
            string quantiteNeuf = tb_quantiteModifRecette.Text.Replace("\r\n", " ");
            string[] lesQuantites = quantiteNeuf.Split(' ');
            foreach (Ingredient ingredient in lesIngredients)
            {
                Composition c = new Composition(ingredient.IdIngredient, idRecette, Convert.ToDouble(lesQuantites[y]));
                c.ajoutComposition();
                y++;
            }

            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        public void AfficherIngredient()
        {
            MySqlConnection conn;

            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string requete = "select * from bio";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            listBox_ModifRecette.Items.Clear();
            List<IngredientBio> lesIngredientsBio = new List<IngredientBio>();
            while (rdr.Read())
            {
                IngredientBio b = new IngredientBio(Convert.ToInt32(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), 0);
                lesIngredientsBio.Add(b);
            }

            conn.Close();

            conn.Open();
            requete = "select * from ingredient";
            cmd = new MySqlCommand(requete, conn);
            rdr = cmd.ExecuteReader();
            bool verif = false; // non bio
            while (rdr.Read())
            {
                verif = false;
                foreach (Ingredient leIngredientBio in lesIngredientsBio)
                {
                    if (verif == false)
                    {
                        if (leIngredientBio.IdIngredient == Convert.ToInt32(rdr[0]))
                        {
                            verif = true;
                        }
                        else
                        {
                            verif = false;
                        }
                    }
                }
                if (verif == true)
                {
                    listBox_ModifRecette.Items.Add("id : " + rdr[0] + " nom : " + rdr[2] + "  BIO");
                }
                else
                {
                    listBox_ModifRecette.Items.Add("id : " + rdr[0] + " nom : " + rdr[2]);
                }
            }

            rdr.Close();
            conn.Close();
        }
    }
}
