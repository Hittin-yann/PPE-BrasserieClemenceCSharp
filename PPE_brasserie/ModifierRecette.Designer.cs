namespace PPE_brasserie
{
    partial class ModifierRecette
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
            this.tb_nomModifRecette = new System.Windows.Forms.TextBox();
            this.listBox_ModifRecette = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dateModifRecette = new System.Windows.Forms.TextBox();
            this.tb_quantiteModifRecette = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_modifierRecette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nomModifRecette
            // 
            this.tb_nomModifRecette.Location = new System.Drawing.Point(327, 135);
            this.tb_nomModifRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nomModifRecette.Name = "tb_nomModifRecette";
            this.tb_nomModifRecette.Size = new System.Drawing.Size(132, 22);
            this.tb_nomModifRecette.TabIndex = 11;
            // 
            // listBox_ModifRecette
            // 
            this.listBox_ModifRecette.FormattingEnabled = true;
            this.listBox_ModifRecette.ItemHeight = 16;
            this.listBox_ModifRecette.Location = new System.Drawing.Point(327, 203);
            this.listBox_ModifRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_ModifRecette.Name = "listBox_ModifRecette";
            this.listBox_ModifRecette.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_ModifRecette.Size = new System.Drawing.Size(246, 180);
            this.listBox_ModifRecette.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Modifier une Recette";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ingrédient :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "date :";
            // 
            // tb_dateModifRecette
            // 
            this.tb_dateModifRecette.Location = new System.Drawing.Point(327, 420);
            this.tb_dateModifRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_dateModifRecette.Name = "tb_dateModifRecette";
            this.tb_dateModifRecette.Size = new System.Drawing.Size(132, 22);
            this.tb_dateModifRecette.TabIndex = 27;
            // 
            // tb_quantiteModifRecette
            // 
            this.tb_quantiteModifRecette.Location = new System.Drawing.Point(327, 478);
            this.tb_quantiteModifRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_quantiteModifRecette.Multiline = true;
            this.tb_quantiteModifRecette.Name = "tb_quantiteModifRecette";
            this.tb_quantiteModifRecette.Size = new System.Drawing.Size(132, 100);
            this.tb_quantiteModifRecette.TabIndex = 28;
            this.tb_quantiteModifRecette.Text = "quantité 1\r\nquantité 2\r\n...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 481);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "quantité :";
            // 
            // bt_modifierRecette
            // 
            this.bt_modifierRecette.Location = new System.Drawing.Point(327, 618);
            this.bt_modifierRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_modifierRecette.Name = "bt_modifierRecette";
            this.bt_modifierRecette.Size = new System.Drawing.Size(100, 28);
            this.bt_modifierRecette.TabIndex = 30;
            this.bt_modifierRecette.Text = "Modifier";
            this.bt_modifierRecette.UseVisualStyleBackColor = true;
            this.bt_modifierRecette.Click += new System.EventHandler(this.bt_modifierRecette_Click);
            // 
            // ModifierRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 715);
            this.Controls.Add(this.bt_modifierRecette);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_quantiteModifRecette);
            this.Controls.Add(this.tb_dateModifRecette);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_ModifRecette);
            this.Controls.Add(this.tb_nomModifRecette);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifierRecette";
            this.Text = "ModifierRecette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nomModifRecette;
        private System.Windows.Forms.ListBox listBox_ModifRecette;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dateModifRecette;
        private System.Windows.Forms.TextBox tb_quantiteModifRecette;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_modifierRecette;
    }
}