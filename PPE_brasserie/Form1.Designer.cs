namespace PPE_brasserie
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bt_modifierRecettes = new System.Windows.Forms.Button();
            this.bt_supprimerRecettes = new System.Windows.Forms.Button();
            this.bt_modifierIngredient = new System.Windows.Forms.Button();
            this.bt_supprimerIngredient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nomRecette = new System.Windows.Forms.TextBox();
            this.tb_quantite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ajoutRecette = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_dateCreation = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.bt_ajouterIngredient = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nomFournisseur = new System.Windows.Forms.TextBox();
            this.tb_nomIngredient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_bioOuPas = new System.Windows.Forms.Button();
            this.bt_quantiteTotal = new System.Windows.Forms.Button();
            this.bt_deconnexion = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_NbBiere = new System.Windows.Forms.TextBox();
            this.bt_genererPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(555, 111);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 292);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(917, 111);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 292);
            this.listBox2.TabIndex = 1;
            // 
            // bt_modifierRecettes
            // 
            this.bt_modifierRecettes.Location = new System.Drawing.Point(555, 450);
            this.bt_modifierRecettes.Margin = new System.Windows.Forms.Padding(4);
            this.bt_modifierRecettes.Name = "bt_modifierRecettes";
            this.bt_modifierRecettes.Size = new System.Drawing.Size(100, 28);
            this.bt_modifierRecettes.TabIndex = 2;
            this.bt_modifierRecettes.Text = "Modifier";
            this.bt_modifierRecettes.UseVisualStyleBackColor = true;
            this.bt_modifierRecettes.Click += new System.EventHandler(this.Bt_modifierRecettes_Click);
            // 
            // bt_supprimerRecettes
            // 
            this.bt_supprimerRecettes.Location = new System.Drawing.Point(686, 450);
            this.bt_supprimerRecettes.Margin = new System.Windows.Forms.Padding(4);
            this.bt_supprimerRecettes.Name = "bt_supprimerRecettes";
            this.bt_supprimerRecettes.Size = new System.Drawing.Size(100, 28);
            this.bt_supprimerRecettes.TabIndex = 3;
            this.bt_supprimerRecettes.Text = "Supprimer";
            this.bt_supprimerRecettes.UseVisualStyleBackColor = true;
            this.bt_supprimerRecettes.Click += new System.EventHandler(this.Bt_supprimerRecettes_Click);
            // 
            // bt_modifierIngredient
            // 
            this.bt_modifierIngredient.Location = new System.Drawing.Point(984, 450);
            this.bt_modifierIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.bt_modifierIngredient.Name = "bt_modifierIngredient";
            this.bt_modifierIngredient.Size = new System.Drawing.Size(100, 28);
            this.bt_modifierIngredient.TabIndex = 5;
            this.bt_modifierIngredient.Text = "Modifier";
            this.bt_modifierIngredient.UseVisualStyleBackColor = true;
            this.bt_modifierIngredient.Click += new System.EventHandler(this.Bt_modifierIngredient_Click);
            // 
            // bt_supprimerIngredient
            // 
            this.bt_supprimerIngredient.Location = new System.Drawing.Point(984, 519);
            this.bt_supprimerIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.bt_supprimerIngredient.Name = "bt_supprimerIngredient";
            this.bt_supprimerIngredient.Size = new System.Drawing.Size(100, 28);
            this.bt_supprimerIngredient.TabIndex = 6;
            this.bt_supprimerIngredient.Text = "Supprimer";
            this.bt_supprimerIngredient.UseVisualStyleBackColor = true;
            this.bt_supprimerIngredient.Click += new System.EventHandler(this.Bt_supprimerIngredient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenue !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom :";
            // 
            // tb_nomRecette
            // 
            this.tb_nomRecette.Location = new System.Drawing.Point(215, 201);
            this.tb_nomRecette.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomRecette.Name = "tb_nomRecette";
            this.tb_nomRecette.Size = new System.Drawing.Size(132, 22);
            this.tb_nomRecette.TabIndex = 10;
            // 
            // tb_quantite
            // 
            this.tb_quantite.Location = new System.Drawing.Point(215, 518);
            this.tb_quantite.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quantite.Multiline = true;
            this.tb_quantite.Name = "tb_quantite";
            this.tb_quantite.Size = new System.Drawing.Size(132, 94);
            this.tb_quantite.TabIndex = 11;
            this.tb_quantite.Text = "quantité 1\r\nquantité 2\r\n...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 518);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantité :";
            // 
            // bt_ajoutRecette
            // 
            this.bt_ajoutRecette.Location = new System.Drawing.Point(169, 643);
            this.bt_ajoutRecette.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajoutRecette.Name = "bt_ajoutRecette";
            this.bt_ajoutRecette.Size = new System.Drawing.Size(100, 28);
            this.bt_ajoutRecette.TabIndex = 13;
            this.bt_ajoutRecette.Text = "Ajouter";
            this.bt_ajoutRecette.UseVisualStyleBackColor = true;
            this.bt_ajoutRecette.Click += new System.EventHandler(this.Bt_ajoutRecette_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ingrédient :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ajouter une Recette";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(935, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Liste Ingrédients";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Liste Recettes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date Création :";
            // 
            // tb_dateCreation
            // 
            this.tb_dateCreation.Location = new System.Drawing.Point(215, 459);
            this.tb_dateCreation.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dateCreation.Name = "tb_dateCreation";
            this.tb_dateCreation.Size = new System.Drawing.Size(132, 22);
            this.tb_dateCreation.TabIndex = 20;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(215, 255);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(232, 180);
            this.listBox3.TabIndex = 21;
            // 
            // bt_ajouterIngredient
            // 
            this.bt_ajouterIngredient.Location = new System.Drawing.Point(1335, 421);
            this.bt_ajouterIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouterIngredient.Name = "bt_ajouterIngredient";
            this.bt_ajouterIngredient.Size = new System.Drawing.Size(100, 28);
            this.bt_ajouterIngredient.TabIndex = 22;
            this.bt_ajouterIngredient.Text = "Ajouter";
            this.bt_ajouterIngredient.UseVisualStyleBackColor = true;
            this.bt_ajouterIngredient.Click += new System.EventHandler(this.bt_ajouterIngredient_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1272, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ajouter un Ingrédient";
            // 
            // tb_nomFournisseur
            // 
            this.tb_nomFournisseur.Location = new System.Drawing.Point(1385, 222);
            this.tb_nomFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nomFournisseur.Name = "tb_nomFournisseur";
            this.tb_nomFournisseur.Size = new System.Drawing.Size(100, 22);
            this.tb_nomFournisseur.TabIndex = 24;
            // 
            // tb_nomIngredient
            // 
            this.tb_nomIngredient.Location = new System.Drawing.Point(1385, 300);
            this.tb_nomIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nomIngredient.Name = "tb_nomIngredient";
            this.tb_nomIngredient.Size = new System.Drawing.Size(100, 22);
            this.tb_nomIngredient.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1256, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Fournisseur :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1256, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Nom Ingédient :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1277, 368);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 21);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Bio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bt_bioOuPas
            // 
            this.bt_bioOuPas.Location = new System.Drawing.Point(625, 507);
            this.bt_bioOuPas.Margin = new System.Windows.Forms.Padding(4);
            this.bt_bioOuPas.Name = "bt_bioOuPas";
            this.bt_bioOuPas.Size = new System.Drawing.Size(100, 28);
            this.bt_bioOuPas.TabIndex = 29;
            this.bt_bioOuPas.Text = "Bio Ou Pas";
            this.bt_bioOuPas.UseVisualStyleBackColor = true;
            this.bt_bioOuPas.Click += new System.EventHandler(this.bt_bioOuPas_Click);
            // 
            // bt_quantiteTotal
            // 
            this.bt_quantiteTotal.Location = new System.Drawing.Point(625, 569);
            this.bt_quantiteTotal.Margin = new System.Windows.Forms.Padding(4);
            this.bt_quantiteTotal.Name = "bt_quantiteTotal";
            this.bt_quantiteTotal.Size = new System.Drawing.Size(100, 28);
            this.bt_quantiteTotal.TabIndex = 30;
            this.bt_quantiteTotal.Text = "Quantité";
            this.bt_quantiteTotal.UseVisualStyleBackColor = true;
            this.bt_quantiteTotal.Click += new System.EventHandler(this.bt_quantiteTotal_Click);
            // 
            // bt_deconnexion
            // 
            this.bt_deconnexion.Location = new System.Drawing.Point(1312, 601);
            this.bt_deconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.bt_deconnexion.Name = "bt_deconnexion";
            this.bt_deconnexion.Size = new System.Drawing.Size(123, 43);
            this.bt_deconnexion.TabIndex = 31;
            this.bt_deconnexion.Text = "Deconnexion";
            this.bt_deconnexion.UseVisualStyleBackColor = true;
            this.bt_deconnexion.Click += new System.EventHandler(this.bt_deconnexion_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 622);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Nombre de bière :";
            // 
            // tb_NbBiere
            // 
            this.tb_NbBiere.Location = new System.Drawing.Point(672, 618);
            this.tb_NbBiere.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NbBiere.Name = "tb_NbBiere";
            this.tb_NbBiere.Size = new System.Drawing.Size(132, 22);
            this.tb_NbBiere.TabIndex = 33;
            // 
            // bt_genererPdf
            // 
            this.bt_genererPdf.Location = new System.Drawing.Point(1335, 519);
            this.bt_genererPdf.Name = "bt_genererPdf";
            this.bt_genererPdf.Size = new System.Drawing.Size(100, 49);
            this.bt_genererPdf.TabIndex = 34;
            this.bt_genererPdf.Text = "Générer pdf";
            this.bt_genererPdf.UseVisualStyleBackColor = true;
            this.bt_genererPdf.Click += new System.EventHandler(this.bt_genererPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 700);
            this.Controls.Add(this.bt_genererPdf);
            this.Controls.Add(this.tb_NbBiere);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bt_deconnexion);
            this.Controls.Add(this.bt_quantiteTotal);
            this.Controls.Add(this.bt_bioOuPas);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_nomIngredient);
            this.Controls.Add(this.tb_nomFournisseur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_ajouterIngredient);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.tb_dateCreation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_ajoutRecette);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_quantite);
            this.Controls.Add(this.tb_nomRecette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_supprimerIngredient);
            this.Controls.Add(this.bt_modifierIngredient);
            this.Controls.Add(this.bt_supprimerRecettes);
            this.Controls.Add(this.bt_modifierRecettes);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_modifierRecettes;
        private System.Windows.Forms.Button bt_supprimerRecettes;
        private System.Windows.Forms.Button bt_modifierIngredient;
        private System.Windows.Forms.Button bt_supprimerIngredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nomRecette;
        private System.Windows.Forms.TextBox tb_quantite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ajoutRecette;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_dateCreation;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button bt_ajouterIngredient;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox tb_nomFournisseur;
        private System.Windows.Forms.TextBox tb_nomIngredient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bt_bioOuPas;
        private System.Windows.Forms.Button bt_quantiteTotal;
        private System.Windows.Forms.Button bt_deconnexion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_NbBiere;
        private System.Windows.Forms.Button bt_genererPdf;
    }
}