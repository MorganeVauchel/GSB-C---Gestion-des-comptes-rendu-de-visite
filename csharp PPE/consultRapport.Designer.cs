namespace csharp_PPE
{
    partial class consultRapport
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
            this.lbl_numrap = new System.Windows.Forms.Label();
            this.lbl_prac = new System.Windows.Forms.Label();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.lbl_bilan = new System.Windows.Forms.Label();
            this.lbl_offre = new System.Windows.Forms.Label();
            this.lbl_dateVisite = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.txtbox_motif = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lib_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_ech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtbox_prac = new System.Windows.Forms.TextBox();
            this.cbx_numrap = new System.Windows.Forms.ComboBox();
            this.chackPratRemp = new System.Windows.Forms.CheckBox();
            this.chackDateRap = new System.Windows.Forms.CheckBox();
            this.txtbox_PraRemp = new System.Windows.Forms.TextBox();
            this.dateVisite = new System.Windows.Forms.DateTimePicker();
            this.lbl_visiteur = new System.Windows.Forms.Label();
            this.txtbox_visiteur = new System.Windows.Forms.TextBox();
            this.tbar_coef = new System.Windows.Forms.TrackBar();
            this.txt_coef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_coef)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_numrap
            // 
            this.lbl_numrap.AutoSize = true;
            this.lbl_numrap.Location = new System.Drawing.Point(35, 44);
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
            this.lbl_motif.Location = new System.Drawing.Point(35, 178);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(58, 13);
            this.lbl_motif.TabIndex = 2;
            this.lbl_motif.Text = "Motif Visite";
            // 
            // lbl_bilan
            // 
            this.lbl_bilan.AutoSize = true;
            this.lbl_bilan.Location = new System.Drawing.Point(35, 227);
            this.lbl_bilan.Name = "lbl_bilan";
            this.lbl_bilan.Size = new System.Drawing.Size(38, 13);
            this.lbl_bilan.TabIndex = 3;
            this.lbl_bilan.Text = "BILAN";
            // 
            // lbl_offre
            // 
            this.lbl_offre.AutoSize = true;
            this.lbl_offre.Location = new System.Drawing.Point(402, 227);
            this.lbl_offre.Name = "lbl_offre";
            this.lbl_offre.Size = new System.Drawing.Size(97, 13);
            this.lbl_offre.TabIndex = 4;
            this.lbl_offre.Text = "Offre d\'échantillons";
            // 
            // lbl_dateVisite
            // 
            this.lbl_dateVisite.AutoSize = true;
            this.lbl_dateVisite.Location = new System.Drawing.Point(35, 153);
            this.lbl_dateVisite.Name = "lbl_dateVisite";
            this.lbl_dateVisite.Size = new System.Drawing.Size(58, 13);
            this.lbl_dateVisite.TabIndex = 5;
            this.lbl_dateVisite.Text = "Date Visite";
            // 
            // datebox
            // 
            this.datebox.CustomFormat = "dd-MM-yyyy";
            this.datebox.Enabled = false;
            this.datebox.Location = new System.Drawing.Point(171, 122);
            this.datebox.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datebox.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 20);
            this.datebox.TabIndex = 8;
            this.datebox.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datebox.Visible = false;
            // 
            // txtbox_motif
            // 
            this.txtbox_motif.Enabled = false;
            this.txtbox_motif.Location = new System.Drawing.Point(171, 175);
            this.txtbox_motif.Name = "txtbox_motif";
            this.txtbox_motif.Size = new System.Drawing.Size(200, 20);
            this.txtbox_motif.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(171, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 122);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lib_med,
            this.qte_ech});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(405, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(253, 103);
            this.dataGridView1.TabIndex = 11;
            // 
            // lib_med
            // 
            this.lib_med.HeaderText = "Médicament";
            this.lib_med.Name = "lib_med";
            this.lib_med.ReadOnly = true;
            // 
            // qte_ech
            // 
            this.qte_ech.HeaderText = "Nb. Echantillons";
            this.qte_ech.Name = "qte_ech";
            this.qte_ech.ReadOnly = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(221, 412);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtbox_prac
            // 
            this.txtbox_prac.Enabled = false;
            this.txtbox_prac.Location = new System.Drawing.Point(171, 66);
            this.txtbox_prac.Name = "txtbox_prac";
            this.txtbox_prac.Size = new System.Drawing.Size(200, 20);
            this.txtbox_prac.TabIndex = 14;
            // 
            // cbx_numrap
            // 
            this.cbx_numrap.FormattingEnabled = true;
            this.cbx_numrap.Location = new System.Drawing.Point(171, 39);
            this.cbx_numrap.Name = "cbx_numrap";
            this.cbx_numrap.Size = new System.Drawing.Size(121, 21);
            this.cbx_numrap.TabIndex = 15;
            this.cbx_numrap.SelectedIndexChanged += new System.EventHandler(this.cbx_numrap_SelectedIndexChanged);
            // 
            // chackPratRemp
            // 
            this.chackPratRemp.AutoSize = true;
            this.chackPratRemp.Enabled = false;
            this.chackPratRemp.Location = new System.Drawing.Point(38, 98);
            this.chackPratRemp.Name = "chackPratRemp";
            this.chackPratRemp.Size = new System.Drawing.Size(136, 17);
            this.chackPratRemp.TabIndex = 17;
            this.chackPratRemp.Text = "Praticien Remplaçant ?";
            this.chackPratRemp.UseVisualStyleBackColor = true;
            this.chackPratRemp.CheckedChanged += new System.EventHandler(this.chackPratRemp_CheckedChanged);
            // 
            // chackDateRap
            // 
            this.chackDateRap.AutoSize = true;
            this.chackDateRap.Enabled = false;
            this.chackDateRap.Location = new System.Drawing.Point(38, 123);
            this.chackDateRap.Name = "chackDateRap";
            this.chackDateRap.Size = new System.Drawing.Size(114, 17);
            this.chackDateRap.TabIndex = 18;
            this.chackDateRap.Text = "Date de Rapport ?";
            this.chackDateRap.UseVisualStyleBackColor = true;
            this.chackDateRap.CheckedChanged += new System.EventHandler(this.chackDateRap_CheckedChanged);
            // 
            // txtbox_PraRemp
            // 
            this.txtbox_PraRemp.Enabled = false;
            this.txtbox_PraRemp.Location = new System.Drawing.Point(171, 96);
            this.txtbox_PraRemp.Name = "txtbox_PraRemp";
            this.txtbox_PraRemp.Size = new System.Drawing.Size(200, 20);
            this.txtbox_PraRemp.TabIndex = 19;
            this.txtbox_PraRemp.Visible = false;
            // 
            // dateVisite
            // 
            this.dateVisite.Enabled = false;
            this.dateVisite.Location = new System.Drawing.Point(171, 149);
            this.dateVisite.Name = "dateVisite";
            this.dateVisite.Size = new System.Drawing.Size(200, 20);
            this.dateVisite.TabIndex = 20;
            // 
            // lbl_visiteur
            // 
            this.lbl_visiteur.AutoSize = true;
            this.lbl_visiteur.Location = new System.Drawing.Point(459, 44);
            this.lbl_visiteur.Name = "lbl_visiteur";
            this.lbl_visiteur.Size = new System.Drawing.Size(134, 13);
            this.lbl_visiteur.TabIndex = 21;
            this.lbl_visiteur.Text = "Nom / Prénom du Visiteur :";
            // 
            // txtbox_visiteur
            // 
            this.txtbox_visiteur.Enabled = false;
            this.txtbox_visiteur.Location = new System.Drawing.Point(462, 66);
            this.txtbox_visiteur.Name = "txtbox_visiteur";
            this.txtbox_visiteur.Size = new System.Drawing.Size(164, 20);
            this.txtbox_visiteur.TabIndex = 22;
            // 
            // tbar_coef
            // 
            this.tbar_coef.Enabled = false;
            this.tbar_coef.Location = new System.Drawing.Point(453, 144);
            this.tbar_coef.Name = "tbar_coef";
            this.tbar_coef.Size = new System.Drawing.Size(164, 45);
            this.tbar_coef.TabIndex = 23;
            this.tbar_coef.Scroll += new System.EventHandler(this.tbar_coef_Scroll);
            // 
            // txt_coef
            // 
            this.txt_coef.Enabled = false;
            this.txt_coef.Location = new System.Drawing.Point(623, 149);
            this.txt_coef.Name = "txt_coef";
            this.txt_coef.Size = new System.Drawing.Size(35, 20);
            this.txt_coef.TabIndex = 24;
            // 
            // consultRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_coef);
            this.Controls.Add(this.tbar_coef);
            this.Controls.Add(this.txtbox_visiteur);
            this.Controls.Add(this.lbl_visiteur);
            this.Controls.Add(this.dateVisite);
            this.Controls.Add(this.txtbox_PraRemp);
            this.Controls.Add(this.chackDateRap);
            this.Controls.Add(this.chackPratRemp);
            this.Controls.Add(this.cbx_numrap);
            this.Controls.Add(this.txtbox_prac);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtbox_motif);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.lbl_dateVisite);
            this.Controls.Add(this.lbl_offre);
            this.Controls.Add(this.lbl_bilan);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.lbl_prac);
            this.Controls.Add(this.lbl_numrap);
            this.Name = "consultRapport";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultRapport_FormClosing);
            this.Load += new System.EventHandler(this.consultRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_coef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numrap;
        private System.Windows.Forms.Label lbl_prac;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.Label lbl_bilan;
        private System.Windows.Forms.Label lbl_offre;
        private System.Windows.Forms.Label lbl_dateVisite;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.TextBox txtbox_motif;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn lib_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_ech;
        private System.Windows.Forms.TextBox txtbox_prac;
        private System.Windows.Forms.ComboBox cbx_numrap;
        private System.Windows.Forms.CheckBox chackPratRemp;
        private System.Windows.Forms.CheckBox chackDateRap;
        private System.Windows.Forms.TextBox txtbox_PraRemp;
        private System.Windows.Forms.DateTimePicker dateVisite;
        private System.Windows.Forms.Label lbl_visiteur;
        private System.Windows.Forms.TextBox txtbox_visiteur;
        private System.Windows.Forms.TrackBar tbar_coef;
        private System.Windows.Forms.TextBox txt_coef;
    }
}