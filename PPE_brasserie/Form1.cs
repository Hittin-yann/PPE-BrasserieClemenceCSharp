using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_brasserie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AfficherIngredient();
            AfficherRecettes();
        }
        static int numero = 0;

        private void Bt_ajoutRecette_Click(object sender, EventArgs e)
        {
            List<Ingredient> lesIngredients = new List<Ingredient>();
            string[] Ingredients = new string[listBox3.SelectedItems.Count];
            listBox3.SelectedItems.CopyTo(Ingredients,0);
            for (int i = 0; i < listBox3.SelectedItems.Count; i++)
            {
                string[] liste = Ingredients.ElementAt(i).Split(' ');
                numero = Convert.ToInt32(liste[2]);
                Object o = IngredientAt(numero);
                Ingredient ing = (Ingredient)o;
                lesIngredients.Add(ing);
            }
            Recette laRecette = new Recette(tb_nomRecette.Text ,tb_dateCreation.Text, lesIngredients);
            laRecette.ajoutRecette();
            int idRecette = laRecette.IdRecette;
            int x = 0;
            string quantiteNeuf = tb_quantite.Text.Replace("\r\n"," ");
            string[] lesQuantites = quantiteNeuf.Split(' ');
            foreach (Ingredient ingredient in lesIngredients)
            {
                Composition c = new Composition(ingredient.IdIngredient, idRecette, Convert.ToDouble(lesQuantites[x]));
                c.ajoutComposition();
                x++;
            }
            tb_nomRecette.Text = "";
            tb_dateCreation.Text = "";
            tb_quantite.Text = "quantité 1\r\nquantité 2\r\n...";
            listBox3.SelectedItems.Clear();
            AfficherRecettes();
        }

        public static Object IngredientAt(int id)
        {
            MySqlConnection conn;

            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string requete = "select * from ingredient where idIngredient = " + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Object o = new Object();

            while (rdr.Read())
            {
                Ingredient i = new Ingredient(Convert.ToInt32(rdr[0]),rdr[1].ToString(),rdr[2].ToString());
                o = i;
            }
            conn.Close();
            return o;
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

            listBox2.Items.Clear();
            listBox3.Items.Clear();
            List<IngredientBio> lesIngredientsBio = new List<IngredientBio>();
            while (rdr.Read())
            {
                IngredientBio b = new IngredientBio(Convert.ToInt32(rdr[0]),rdr[1].ToString(),rdr[2].ToString(),0);
                lesIngredientsBio.Add(b);
                //listBox2.Items.Add("id : " + rdr[0] + " nom : " + rdr[2]);
                //listBox3.Items.Add("id : " + rdr[0] + " nom : " + rdr[2]);
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
                //listBox2.Items.Add("id : " + rdr[0] + " nom : " + rdr[2] + "  BIO");
                //listBox3.Items.Add("id : " + rdr[0] + " nom : " + rdr[2] + "  BIO");
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
                    listBox2.Items.Add("id : " + rdr[0] + " nom : " + rdr[2] + "  BIO");
                    listBox3.Items.Add("id : " + rdr[0] + " nom : " + rdr[2] + "  BIO");
                }
                else
                {
                    listBox2.Items.Add("id : " + rdr[0] + " nom : " + rdr[2]);
                    listBox3.Items.Add("id : " + rdr[0] + " nom : " + rdr[2]);
                }
            }

            //comboBox1.EndUpdate();
            rdr.Close();
            conn.Close();
        }

        public void AfficherRecettes()
        {
            MySqlConnection conn;

            string myConnectionString;
            //myConnectionString = "server=172.19.0.6;uid=clientsql;pwd=0550002D;database=PPE_Brasserie;";
            myConnectionString = "server=localhost;uid=root;pwd=;database=ppe_brasserie;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string requete = "select * from recette";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while (rdr.Read())
            {
                listBox1.Items.Add("id : " + rdr[0] + " nom : " + rdr[1]);
            }
            rdr.Close();
            conn.Close();
        }

        private void Bt_supprimerRecettes_Click(object sender, EventArgs e)
        {
            string[] liste = listBox1.SelectedItem.ToString().Split(' ');
            numero = Convert.ToInt32(liste[2]);

            List<Ingredient> l = new List<Ingredient>();
            Recette r = new Recette("","",l);
            r.supprimerRecette(numero);
            AfficherRecettes();
        }

        private void Bt_modifierRecettes_Click(object sender, EventArgs e)
        {
            string[] liste = listBox1.SelectedItem.ToString().Split(' ');
            numero = Convert.ToInt32(liste[2]);
            ModifierRecette r = new ModifierRecette(numero);
            r.Show();
            this.Close();
        }

        private void Bt_modifierIngredient_Click(object sender, EventArgs e)
        {
            string[] liste = listBox2.SelectedItem.ToString().Split(' ');
            numero = Convert.ToInt32(liste[2]);
            ModifierIngredient f = new ModifierIngredient(numero);
            f.Show();
            this.Close();
        }

        private void Bt_supprimerIngredient_Click(object sender, EventArgs e)
        {
            string[] liste = listBox2.SelectedItem.ToString().Split(' ');
            numero = Convert.ToInt32(liste[2]);

            Ingredient i = new Ingredient("","");
            i.supprimerIngredient(numero);
            AfficherIngredient();
        }

        private void bt_ajouterIngredient_Click(object sender, EventArgs e)
        {
            Ingredient i = new Ingredient(tb_nomFournisseur.Text, tb_nomIngredient.Text);
            i.ajouterIngredient();
            int id = i.IdDeIngredient();
            if (checkBox1.Checked)
            {
                IngredientBio b = new IngredientBio(id,tb_nomFournisseur.Text, tb_nomIngredient.Text,0);
                b.ajouterIngredientBio();
            }
            AfficherIngredient();
            tb_nomFournisseur.Text = "";
            tb_nomIngredient.Text = "";
            checkBox1.Checked = false;
        }

        private void bt_bioOuPas_Click(object sender, EventArgs e)
        {
            string[] liste = listBox1.SelectedItem.ToString().Split(' ');
            numero = Convert.ToInt32(liste[2]);
            List<Ingredient> l = new List<Ingredient>();

            Recette r = new Recette(numero,"","",l);
            MessageBox.Show(r.bioOuPas());
        }

        private void bt_deconnexion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci d'avoir utiliser nos servies. A bientôt !");
            Application.Exit();
        }

        private void bt_quantiteTotal_Click(object sender, EventArgs e)
        {
            string[] liste = listBox1.SelectedItem.ToString().Split(' ');
            numero = Convert.ToInt32(liste[2]);
            List<Ingredient> l = new List<Ingredient>();
            Recette r = new Recette(numero,"","",l);
            Dictionary<string, double> nomEtQuantite= new Dictionary<string, double>();
            nomEtQuantite = r.quantiteIndredient();

            MessageBox.Show("Pour votre recette, ils vous faut :");
            foreach (KeyValuePair<string, double> item in nomEtQuantite)
            {
                //fullValue.Add(item.Key);
                //fullValue.Add(item.Value.ToString());
                MessageBox.Show( (item.Value * Convert.ToDouble(tb_NbBiere.Text)) + " de quantité de " + item.Key);
            }
            MessageBox.Show("Pour " + tb_NbBiere.Text + " bières");
            tb_NbBiere.Text = "";
        }

        private void bt_genererPdf_Click(object sender, EventArgs e)
        {
            string fichier = Path.Combine(Application.StartupPath + "../../../PDF/", "lesRecettes.pdf");

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(fichier, FileMode.Create, FileAccess.ReadWrite));

            document.Open();
            Paragraph titre = new Paragraph("Vos Recettes");
            titre.Alignment = Element.ALIGN_CENTER;
            titre.Font.Size = 20;
            titre.Font.SetStyle(iTextSharp.text.Font.UNDERLINE + iTextSharp.text.Font.BOLDITALIC);
            document.Add(titre);
            document.Add(new Paragraph(""));
            document.Add(new Phrase("\r\n"));

            List<Ingredient> l = new List<Ingredient>();
            Recette r = new Recette("","", l);
            List<Recette> lesRecettes = r.lesRecettes();

            foreach(Recette laRecette in lesRecettes)
            {
                Phrase leTitreRecette = new Phrase("• " + laRecette.NomRecette);
                leTitreRecette.Font.Color = iTextSharp.text.BaseColor.RED;
                leTitreRecette.Font.SetStyle(iTextSharp.text.Font.BOLDITALIC);
                document.Add(leTitreRecette);
                document.Add(new Phrase(" " + laRecette.DateCreation + "\r\n"));
                foreach (Ingredient leIngredient in laRecette.listIngredient())
                {
                    Phrase ingredientFinal = new Phrase(leIngredient.NomIngredient);
                    ingredientFinal.Font.Color = iTextSharp.text.BaseColor.BLUE;
                    ingredientFinal.Font.SetStyle(iTextSharp.text.Font.BOLDITALIC);

                    Phrase fournisseurFinal = new Phrase(leIngredient.FournisseurIngredient);
                    fournisseurFinal.Font.SetColor(255,102,0);
                    fournisseurFinal.Font.SetStyle(iTextSharp.text.Font.BOLDITALIC);

                    if (leIngredient.bioOuPas())
                    {
                        document.Add(new Phrase("- "));
                        document.Add(ingredientFinal);
                        document.Add(new Phrase(" BIO fourni par "));
                        document.Add(fournisseurFinal);
                        document.Add(new Phrase("\r\n"));
                    }
                    else
                    {
                        document.Add(new Phrase("- "));
                        document.Add(ingredientFinal);
                        document.Add(new Phrase(" fourni par "));
                        document.Add(fournisseurFinal);
                        document.Add(new Phrase("\r\n"));
                    }
                }
                document.Add(new Phrase("\r\n"));
            }

            document.Close();

            MessageBox.Show("Document enregistrer !");
        }
    }
}
