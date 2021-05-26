namespace PPE_brasserie
{
    partial class Connection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_utilisateur = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.bt_connection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // tb_utilisateur
            // 
            this.tb_utilisateur.Location = new System.Drawing.Point(679, 213);
            this.tb_utilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.tb_utilisateur.Name = "tb_utilisateur";
            this.tb_utilisateur.Size = new System.Drawing.Size(132, 22);
            this.tb_utilisateur.TabIndex = 1;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(679, 313);
            this.tb_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '*';
            this.tb_mdp.Size = new System.Drawing.Size(132, 22);
            this.tb_mdp.TabIndex = 2;
            // 
            // bt_connection
            // 
            this.bt_connection.Location = new System.Drawing.Point(620, 423);
            this.bt_connection.Margin = new System.Windows.Forms.Padding(4);
            this.bt_connection.Name = "bt_connection";
            this.bt_connection.Size = new System.Drawing.Size(133, 53);
            this.bt_connection.TabIndex = 3;
            this.bt_connection.Text = "Connection";
            this.bt_connection.UseVisualStyleBackColor = true;
            this.bt_connection.Click += new System.EventHandler(this.Bt_connection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Utilisateur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe :";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 740);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_connection);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_utilisateur);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_utilisateur;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button bt_connection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

