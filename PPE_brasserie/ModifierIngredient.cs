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
    public partial class ModifierIngredient : Form
    {
        private int numero;
        public ModifierIngredient(int n)
        {
            InitializeComponent();
            this.numero = n;
        }

        private void Bt_modifierIngredientV_Click(object sender, EventArgs e)
        {
            Ingredient i = new Ingredient(tb_newNomFournisseur.Text, tb_newNomIngredient.Text);
            i.modifierIngredient(numero);
            
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
