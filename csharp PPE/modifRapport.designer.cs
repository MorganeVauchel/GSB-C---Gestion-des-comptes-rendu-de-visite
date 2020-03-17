namespace csharp_PPE
{
    partial class modifRapport
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
            this.btn_modif = new System.Windows.Forms.Button();
            this.txt_bilan = new System.Windows.Forms.RichTextBox();
            this.cbx_pratic = new System.Windows.Forms.ComboBox();
            this.cbx_numrapport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Praticien = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_daterapp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_motifs = new System.Windows.Forms.ComboBox();
            this.dt_datevis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_praticremp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_echantillon = new System.Windows.Forms.DataGridView();
            this.cbx_medic = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trb_coef = new System.Windows.Forms.TrackBar();
            this.Coef = new System.Windows.Forms.Label();
            this.txtbox_vis = new System.Windows.Forms.TextBox();
            this.lbl_vis = new System.Windows.Forms.Label();
            this.chkbox_date_rapport = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_echantillon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_coef)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(764, 422);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(75, 23);
            this.btn_modif.TabIndex = 0;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(115, 282);
            this.txt_bilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.Size = new System.Drawing.Size(183, 132);
            this.txt_bilan.TabIndex = 2;
            this.txt_bilan.Text = "";
            // 
            // cbx_pratic
            // 
            this.cbx_pratic.FormattingEnabled = true;
            this.cbx_pratic.Location = new System.Drawing.Point(115, 91);
            this.cbx_pratic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_pratic.Name = "cbx_pratic";
            this.cbx_pratic.Size = new System.Drawing.Size(121, 24);
            this.cbx_pratic.TabIndex = 5;
            this.cbx_pratic.SelectedIndexChanged += new System.EventHandler(this.cbx_pratic_SelectedIndexChanged);
            // 
            // cbx_numrapport
            // 
            this.cbx_numrapport.FormattingEnabled = true;
            this.cbx_numrapport.Location = new System.Drawing.Point(157, 37);
            this.cbx_numrapport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_numrapport.Name = "cbx_numrapport";
            this.cbx_numrapport.Size = new System.Drawing.Size(121, 24);
            this.cbx_numrapport.TabIndex = 6;
            this.cbx_numrapport.SelectedIndexChanged += new System.EventHandler(this.cbx_numrapport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numéro Rapport";
            // 
            // Praticien
            // 
            this.Praticien.AutoSize = true;
            this.Praticien.Location = new System.Drawing.Point(12, 98);
            this.Praticien.Name = "Praticien";
            this.Praticien.Size = new System.Drawing.Size(63, 17);
            this.Praticien.TabIndex = 9;
            this.Praticien.Text = "Praticien";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 164);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 17);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "Date";
            this.lbl_date.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Motif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bilan";
            // 
            // dt_daterapp
            // 
            this.dt_daterapp.CustomFormat = "y-m-d";
            this.dt_daterapp.Location = new System.Drawing.Point(83, 164);
            this.dt_daterapp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_daterapp.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dt_daterapp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_daterapp.Name = "dt_daterapp";
            this.dt_daterapp.Size = new System.Drawing.Size(265, 22);
            this.dt_daterapp.TabIndex = 13;
            this.dt_daterapp.Value = new System.DateTime(2019, 12, 12, 0, 0, 0, 0);
            this.dt_daterapp.Visible = false;
            this.dt_daterapp.ValueChanged += new System.EventHandler(this.dt_daterapp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Échantillons";
            // 
            // cbx_motifs
            // 
            this.cbx_motifs.FormattingEnabled = true;
            this.cbx_motifs.Location = new System.Drawing.Point(115, 229);
            this.cbx_motifs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_motifs.Name = "cbx_motifs";
            this.cbx_motifs.Size = new System.Drawing.Size(121, 24);
            this.cbx_motifs.TabIndex = 16;
            this.cbx_motifs.SelectedIndexChanged += new System.EventHandler(this.cbx_motifs_SelectedIndexChanged);
            // 
            // dt_datevis
            // 
            this.dt_datevis.CustomFormat = "y-m-d";
            this.dt_datevis.Location = new System.Drawing.Point(105, 192);
            this.dt_datevis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_datevis.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dt_datevis.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_datevis.Name = "dt_datevis";
            this.dt_datevis.Size = new System.Drawing.Size(265, 22);
            this.dt_datevis.TabIndex = 17;
            this.dt_datevis.Value = new System.DateTime(2019, 12, 12, 0, 0, 0, 0);
            this.dt_datevis.ValueChanged += new System.EventHandler(this.dt_datevis_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date de visite";
            // 
            // cbx_praticremp
            // 
            this.cbx_praticremp.FormattingEnabled = true;
            this.cbx_praticremp.Location = new System.Drawing.Point(116, 128);
            this.cbx_praticremp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_praticremp.Name = "cbx_praticremp";
            this.cbx_praticremp.Size = new System.Drawing.Size(121, 24);
            this.cbx_praticremp.TabIndex = 19;
            this.cbx_praticremp.SelectedIndexChanged += new System.EventHandler(this.cbx_praticremp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Remplaçant";
            // 
            // dgv_echantillon
            // 
            this.dgv_echantillon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_echantillon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbx_medic,
            this.txt_quantite});
            this.dgv_echantillon.Location = new System.Drawing.Point(403, 249);
            this.dgv_echantillon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_echantillon.Name = "dgv_echantillon";
            this.dgv_echantillon.RowTemplate.Height = 24;
            this.dgv_echantillon.Size = new System.Drawing.Size(352, 150);
            this.dgv_echantillon.TabIndex = 21;
            this.dgv_echantillon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_echantillon_CellContentClick);
            // 
            // cbx_medic
            // 
            this.cbx_medic.HeaderText = "Medicament";
            this.cbx_medic.Name = "cbx_medic";
            // 
            // txt_quantite
            // 
            this.txt_quantite.HeaderText = "Quantité";
            this.txt_quantite.Name = "txt_quantite";
            // 
            // trb_coef
            // 
            this.trb_coef.Location = new System.Drawing.Point(507, 128);
            this.trb_coef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trb_coef.Name = "trb_coef";
            this.trb_coef.Size = new System.Drawing.Size(187, 56);
            this.trb_coef.TabIndex = 22;
            // 
            // Coef
            // 
            this.Coef.AutoSize = true;
            this.Coef.Location = new System.Drawing.Point(432, 128);
            this.Coef.Name = "Coef";
            this.Coef.Size = new System.Drawing.Size(37, 17);
            this.Coef.TabIndex = 23;
            this.Coef.Text = "Coef";
            // 
            // txtbox_vis
            // 
            this.txtbox_vis.Enabled = false;
            this.txtbox_vis.Location = new System.Drawing.Point(507, 36);
            this.txtbox_vis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_vis.Name = "txtbox_vis";
            this.txtbox_vis.Size = new System.Drawing.Size(132, 22);
            this.txtbox_vis.TabIndex = 24;
            // 
            // lbl_vis
            // 
            this.lbl_vis.AutoSize = true;
            this.lbl_vis.Location = new System.Drawing.Point(331, 36);
            this.lbl_vis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vis.Name = "lbl_vis";
            this.lbl_vis.Size = new System.Drawing.Size(154, 17);
            this.lbl_vis.TabIndex = 25;
            this.lbl_vis.Text = "Nom et Prénom Visteur";
            // 
            // chkbox_date_rapport
            // 
            this.chkbox_date_rapport.AutoSize = true;
            this.chkbox_date_rapport.Location = new System.Drawing.Point(366, 168);
            this.chkbox_date_rapport.Margin = new System.Windows.Forms.Padding(1);
            this.chkbox_date_rapport.Name = "chkbox_date_rapport";
            this.chkbox_date_rapport.Size = new System.Drawing.Size(165, 21);
            this.chkbox_date_rapport.TabIndex = 28;
            this.chkbox_date_rapport.Text = "Datation du rapport ?";
            this.chkbox_date_rapport.UseVisualStyleBackColor = true;
            this.chkbox_date_rapport.CheckedChanged += new System.EventHandler(this.chkbox_date_rapport_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(862, 419);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // modifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.chkbox_date_rapport);
            this.Controls.Add(this.lbl_vis);
            this.Controls.Add(this.txtbox_vis);
            this.Controls.Add(this.Coef);
            this.Controls.Add(this.trb_coef);
            this.Controls.Add(this.dgv_echantillon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_praticremp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_datevis);
            this.Controls.Add(this.cbx_motifs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_daterapp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.Praticien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_numrapport);
            this.Controls.Add(this.cbx_pratic);
            this.Controls.Add(this.txt_bilan);
            this.Controls.Add(this.btn_modif);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "modifRapport";
            this.Text = "modifRapport";
            this.Load += new System.EventHandler(this.modifRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_echantillon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_coef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.RichTextBox txt_bilan;
        private System.Windows.Forms.ComboBox cbx_pratic;
        private System.Windows.Forms.ComboBox cbx_numrapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Praticien;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_daterapp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_motifs;
        private System.Windows.Forms.DateTimePicker dt_datevis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_praticremp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_echantillon;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbx_medic;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_quantite;
        private System.Windows.Forms.TrackBar trb_coef;
        private System.Windows.Forms.Label Coef;
        private System.Windows.Forms.TextBox txtbox_vis;
        private System.Windows.Forms.Label lbl_vis;
        private System.Windows.Forms.CheckBox chkbox_date_rapport;
        private System.Windows.Forms.Button btn_exit;
    }
}