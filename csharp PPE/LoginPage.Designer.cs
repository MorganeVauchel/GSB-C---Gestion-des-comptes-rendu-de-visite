namespace csharp_PPE
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.txtbox_mdp = new System.Windows.Forms.TextBox();
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_id
            // 
            this.txtbox_id.ForeColor = System.Drawing.Color.Silver;
            this.txtbox_id.Location = new System.Drawing.Point(325, 100);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(222, 20);
            this.txtbox_id.TabIndex = 0;
            this.txtbox_id.Text = "Login";
            this.txtbox_id.Enter += new System.EventHandler(this.txtbox_id_Enter);
            this.txtbox_id.Leave += new System.EventHandler(this.txtbox_id_Leave);
            // 
            // txtbox_mdp
            // 
            this.txtbox_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_mdp.ForeColor = System.Drawing.Color.Silver;
            this.txtbox_mdp.Location = new System.Drawing.Point(325, 156);
            this.txtbox_mdp.Name = "txtbox_mdp";
            this.txtbox_mdp.Size = new System.Drawing.Size(222, 23);
            this.txtbox_mdp.TabIndex = 1;
            this.txtbox_mdp.Text = "Mot de passe";
            this.txtbox_mdp.Enter += new System.EventHandler(this.txtbox_mdp_Enter);
            this.txtbox_mdp.Leave += new System.EventHandler(this.txtbox_mdp_Leave);
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(222, 107);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(53, 13);
            this.lbl_identifiant.TabIndex = 2;
            this.lbl_identifiant.Text = "Identifiant";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(222, 159);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(71, 13);
            this.lbl_mdp.TabIndex = 3;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.Location = new System.Drawing.Point(376, 209);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(0, 13);
            this.lbl_erreur.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(390, 252);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Connexion";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::csharp_PPE.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_erreur);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_identifiant);
            this.Controls.Add(this.txtbox_mdp);
            this.Controls.Add(this.txtbox_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.TextBox txtbox_mdp;
        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.Button btn_login;
    }
}

