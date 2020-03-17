namespace csharp_PPE
{
    partial class creationRapport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_visiteur;
            this.lbl_numrap = new System.Windows.Forms.Label();
            this.lbl_prac = new System.Windows.Forms.Label();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.lbl_bilan = new System.Windows.Forms.Label();
            this.lbl_offre = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txtbox_numrap = new System.Windows.Forms.TextBox();
            this.cbx_prat = new System.Windows.Forms.ComboBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_val = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cbx_prat_remp = new System.Windows.Forms.ComboBox();
            this.lbl_prat_remp = new System.Windows.Forms.Label();
            this.cbx_motif = new System.Windows.Forms.ComboBox();
            this.lbl_date_visite = new System.Windows.Forms.Label();
            this.dateboxVisite = new System.Windows.Forms.DateTimePicker();
            this.txtbox_visiteur = new System.Windows.Forms.MaskedTextBox();
            this.chkbox_date_rapport = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbx_lib_med = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_coef_conf = new System.Windows.Forms.Label();
            this.trackBar_CoefConf = new System.Windows.Forms.TrackBar();
            this.creationRapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lbl_visiteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CoefConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationRapportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_visiteur
            // 
            lbl_visiteur.AutoSize = true;
            lbl_visiteur.Location = new System.Drawing.Point(382, 42);
            lbl_visiteur.Name = "lbl_visiteur";
            lbl_visiteur.Size = new System.Drawing.Size(41, 13);
            lbl_visiteur.TabIndex = 19;
            lbl_visiteur.Text = "Visiteur";
            lbl_visiteur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_numrap
            // 
            this.lbl_numrap.AutoSize = true;
            this.lbl_numrap.Location = new System.Drawing.Point(30, 41);
            this.lbl_numrap.Name = "lbl_numrap";
            this.lbl_numrap.Size = new System.Drawing.Size(85, 13);
            this.lbl_numrap.TabIndex = 0;
            this.lbl_numrap.Text = "Numéro Rapport";
            // 
            // lbl_prac
            // 
            this.lbl_prac.AutoSize = true;
            this.lbl_prac.Location = new System.Drawing.Point(35, 69);
            this.lbl_prac.Name = "lbl_prac";
            this.lbl_prac.Size = new System.Drawing.Size(48, 13);
            this.lbl_prac.TabIndex = 1;
            this.lbl_prac.Text = "Praticien";
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Location = new System.Drawing.Point(32, 261);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(58, 13);
            this.lbl_motif.TabIndex = 2;
            this.lbl_motif.Text = "Motif Visite";
            // 
            // lbl_bilan
            // 
            this.lbl_bilan.AutoSize = true;
            this.lbl_bilan.Location = new System.Drawing.Point(43, 305);
            this.lbl_bilan.Name = "lbl_bilan";
            this.lbl_bilan.Size = new System.Drawing.Size(38, 13);
            this.lbl_bilan.TabIndex = 3;
            this.lbl_bilan.Text = "BILAN";
            // 
            // lbl_offre
            // 
            this.lbl_offre.AutoSize = true;
            this.lbl_offre.Location = new System.Drawing.Point(493, 205);
            this.lbl_offre.Name = "lbl_offre";
            this.lbl_offre.Size = new System.Drawing.Size(97, 13);
            this.lbl_offre.TabIndex = 4;
            this.lbl_offre.Text = "Offre d\'échantillons";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(32, 191);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(71, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date Rapport";
            this.lbl_date.Visible = false;
            // 
            // txtbox_numrap
            // 
            this.txtbox_numrap.Enabled = false;
            this.txtbox_numrap.Location = new System.Drawing.Point(158, 42);
            this.txtbox_numrap.Name = "txtbox_numrap";
            this.txtbox_numrap.ReadOnly = true;
            this.txtbox_numrap.Size = new System.Drawing.Size(100, 20);
            this.txtbox_numrap.TabIndex = 6;
            this.txtbox_numrap.TextChanged += new System.EventHandler(this.txtbox_numrap_TextChanged);
            // 
            // cbx_prat
            // 
            this.cbx_prat.FormattingEnabled = true;
            this.cbx_prat.Location = new System.Drawing.Point(158, 66);
            this.cbx_prat.Name = "cbx_prat";
            this.cbx_prat.Size = new System.Drawing.Size(200, 21);
            this.cbx_prat.TabIndex = 7;
            this.cbx_prat.SelectedIndexChanged += new System.EventHandler(this.cbx_prat_SelectedIndexChanged);
            // 
            // datebox
            // 
            this.datebox.CustomFormat = "dd/MM/yyyy";
            this.datebox.Location = new System.Drawing.Point(154, 189);
            this.datebox.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datebox.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 20);
            this.datebox.TabIndex = 8;
            this.datebox.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datebox.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(158, 305);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 122);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(202, 448);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(112, 23);
            this.btn_val.TabIndex = 12;
            this.btn_val.Text = "Valider le Rapport";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(394, 472);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cbx_prat_remp
            // 
            this.cbx_prat_remp.FormattingEnabled = true;
            this.cbx_prat_remp.Location = new System.Drawing.Point(516, 67);
            this.cbx_prat_remp.Name = "cbx_prat_remp";
            this.cbx_prat_remp.Size = new System.Drawing.Size(200, 21);
            this.cbx_prat_remp.TabIndex = 14;
            this.cbx_prat_remp.SelectedIndexChanged += new System.EventHandler(this.cbx_prat_remp_SelectedIndexChanged);
            // 
            // lbl_prat_remp
            // 
            this.lbl_prat_remp.AutoSize = true;
            this.lbl_prat_remp.Location = new System.Drawing.Point(382, 67);
            this.lbl_prat_remp.Name = "lbl_prat_remp";
            this.lbl_prat_remp.Size = new System.Drawing.Size(103, 13);
            this.lbl_prat_remp.TabIndex = 15;
            this.lbl_prat_remp.Text = "Praticien remplaçant";
            // 
            // cbx_motif
            // 
            this.cbx_motif.FormattingEnabled = true;
            this.cbx_motif.Location = new System.Drawing.Point(154, 260);
            this.cbx_motif.Name = "cbx_motif";
            this.cbx_motif.Size = new System.Drawing.Size(200, 21);
            this.cbx_motif.TabIndex = 16;
            // 
            // lbl_date_visite
            // 
            this.lbl_date_visite.AutoSize = true;
            this.lbl_date_visite.Location = new System.Drawing.Point(32, 227);
            this.lbl_date_visite.Name = "lbl_date_visite";
            this.lbl_date_visite.Size = new System.Drawing.Size(58, 13);
            this.lbl_date_visite.TabIndex = 17;
            this.lbl_date_visite.Text = "Date Visite";
            // 
            // dateboxVisite
            // 
            this.dateboxVisite.CustomFormat = "dd/MM/yyyy";
            this.dateboxVisite.Location = new System.Drawing.Point(154, 225);
            this.dateboxVisite.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateboxVisite.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateboxVisite.Name = "dateboxVisite";
            this.dateboxVisite.Size = new System.Drawing.Size(200, 20);
            this.dateboxVisite.TabIndex = 18;
            this.dateboxVisite.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // txtbox_visiteur
            // 
            this.txtbox_visiteur.Enabled = false;
            this.txtbox_visiteur.Location = new System.Drawing.Point(516, 42);
            this.txtbox_visiteur.Margin = new System.Windows.Forms.Padding(1);
            this.txtbox_visiteur.Name = "txtbox_visiteur";
            this.txtbox_visiteur.ReadOnly = true;
            this.txtbox_visiteur.Size = new System.Drawing.Size(133, 20);
            this.txtbox_visiteur.TabIndex = 20;
            // 
            // chkbox_date_rapport
            // 
            this.chkbox_date_rapport.AutoSize = true;
            this.chkbox_date_rapport.Location = new System.Drawing.Point(154, 168);
            this.chkbox_date_rapport.Margin = new System.Windows.Forms.Padding(1);
            this.chkbox_date_rapport.Name = "chkbox_date_rapport";
            this.chkbox_date_rapport.Size = new System.Drawing.Size(126, 17);
            this.chkbox_date_rapport.TabIndex = 21;
            this.chkbox_date_rapport.Text = "Datation du rapport ?";
            this.chkbox_date_rapport.UseVisualStyleBackColor = true;
            this.chkbox_date_rapport.CheckedChanged += new System.EventHandler(this.chkbox_date_rapport_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbx_lib_med,
            this.txt_qte});
            this.dataGridView1.Location = new System.Drawing.Point(495, 227);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(368, 167);
            this.dataGridView1.TabIndex = 22;
            // 
            // cbx_lib_med
            // 
            this.cbx_lib_med.HeaderText = "Médicament";
            this.cbx_lib_med.MinimumWidth = 12;
            this.cbx_lib_med.Name = "cbx_lib_med";
            // 
            // txt_qte
            // 
            this.txt_qte.HeaderText = "Nb. Echantillons";
            this.txt_qte.MinimumWidth = 12;
            this.txt_qte.Name = "txt_qte";
            // 
            // lbl_coef_conf
            // 
            this.lbl_coef_conf.AutoSize = true;
            this.lbl_coef_conf.Location = new System.Drawing.Point(30, 116);
            this.lbl_coef_conf.Name = "lbl_coef_conf";
            this.lbl_coef_conf.Size = new System.Drawing.Size(108, 13);
            this.lbl_coef_conf.TabIndex = 24;
            this.lbl_coef_conf.Text = "Coefficient Confiance";
            // 
            // trackBar_CoefConf
            // 
            this.trackBar_CoefConf.Location = new System.Drawing.Point(144, 107);
            this.trackBar_CoefConf.Name = "trackBar_CoefConf";
            this.trackBar_CoefConf.Size = new System.Drawing.Size(232, 45);
            this.trackBar_CoefConf.TabIndex = 26;
            // 
            // creationRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 517);
            this.Controls.Add(this.trackBar_CoefConf);
            this.Controls.Add(this.lbl_coef_conf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkbox_date_rapport);
            this.Controls.Add(this.txtbox_visiteur);
            this.Controls.Add(lbl_visiteur);
            this.Controls.Add(this.dateboxVisite);
            this.Controls.Add(this.lbl_date_visite);
            this.Controls.Add(this.cbx_motif);
            this.Controls.Add(this.lbl_prat_remp);
            this.Controls.Add(this.cbx_prat_remp);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.cbx_prat);
            this.Controls.Add(this.txtbox_numrap);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_offre);
            this.Controls.Add(this.lbl_bilan);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.lbl_prac);
            this.Controls.Add(this.lbl_numrap);
            this.Name = "creationRapport";
            this.Text = "creationRapport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.creationRapport_FormClosing);
            this.Load += new System.EventHandler(this.creationRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CoefConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationRapportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numrap;
        private System.Windows.Forms.Label lbl_prac;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.Label lbl_bilan;
        private System.Windows.Forms.Label lbl_offre;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txtbox_numrap;
        private System.Windows.Forms.ComboBox cbx_prat;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cbx_prat_remp;
        private System.Windows.Forms.Label lbl_prat_remp;
        private System.Windows.Forms.ComboBox cbx_motif;
        private System.Windows.Forms.Label lbl_date_visite;
        private System.Windows.Forms.DateTimePicker dateboxVisite;
        private System.Windows.Forms.MaskedTextBox txtbox_visiteur;
        private System.Windows.Forms.CheckBox chkbox_date_rapport;
        private System.Windows.Forms.BindingSource creationRapportBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbx_lib_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_qte;
        private System.Windows.Forms.Label lbl_coef_conf;
        private System.Windows.Forms.TrackBar trackBar_CoefConf;
    }
}