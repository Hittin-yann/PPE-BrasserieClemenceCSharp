namespace PPE_brasserie
{
    partial class ModifierIngredient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_newNomFournisseur = new System.Windows.Forms.TextBox();
            this.tb_newNomIngredient = new System.Windows.Forms.TextBox();
            this.bt_modifierIngredientV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier l\'ingrédient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du Fournisseur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom de L\'ingrédient :";
            // 
            // tb_newNomFournisseur
            // 
            this.tb_newNomFournisseur.Location = new System.Drawing.Point(335, 123);
            this.tb_newNomFournisseur.Name = "tb_newNomFournisseur";
            this.tb_newNomFournisseur.Size = new System.Drawing.Size(100, 20);
            this.tb_newNomFournisseur.TabIndex = 3;
            // 
            // tb_newNomIngredient
            // 
            this.tb_newNomIngredient.Location = new System.Drawing.Point(335, 190);
            this.tb_newNomIngredient.Name = "tb_newNomIngredient";
            this.tb_newNomIngredient.Size = new System.Drawing.Size(100, 20);
            this.tb_newNomIngredient.TabIndex = 4;
            // 
            // bt_modifierIngredientV
            // 
            this.bt_modifierIngredientV.Location = new System.Drawing.Point(308, 275);
            this.bt_modifierIngredientV.Name = "bt_modifierIngredientV";
            this.bt_modifierIngredientV.Size = new System.Drawing.Size(75, 23);
            this.bt_modifierIngredientV.TabIndex = 5;
            this.bt_modifierIngredientV.Text = "Modifier";
            this.bt_modifierIngredientV.UseVisualStyleBackColor = true;
            this.bt_modifierIngredientV.Click += new System.EventHandler(this.Bt_modifierIngredientV_Click);
            // 
            // ModifierIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_modifierIngredientV);
            this.Controls.Add(this.tb_newNomIngredient);
            this.Controls.Add(this.tb_newNomFournisseur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifierIngredient";
            this.Text = "ModifierIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_newNomFournisseur;
        private System.Windows.Forms.TextBox tb_newNomIngredient;
        private System.Windows.Forms.Button bt_modifierIngredientV;
    }
}