using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace csharp_PPE
{
    public partial class modifRapport : Form
    {
        public string praticvalue;
        public string motifvalue;
        public string praticrempvalue;
        public List<string> liste_med = new List<string>();

        public modifRapport()
        {
            InitializeComponent();
        }

        private void modifRapport_Load(object sender, EventArgs e)
        {
            CURS cs = new CURS(LoginPage.ChaineConnexion);
            string requete = "select RAP_NUM from rapport_visite WHERE COL_MATRICULE = '" + LoginPage.Id + "';";
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                cbx_numrapport.Items.Add(cs.champ("RAP_NUM"));
                cs.suivant();
            }
            cs.fermer();
            cbx_numrapport.Show();

            CURS csVis = new CURS(LoginPage.ChaineConnexion);
            string requeteVis = "SELECT CONCAT(`COL_NOM`, ' ', `COL_PRENOM`) AS NomPrenom FROM `collaborateur` WHERE `COL_MATRICULE` = '" + LoginPage.Id + "';";
            csVis.ReqSelect(requeteVis);
            while (!csVis.Fin())
            {
                txtbox_vis.Text = csVis.champ("NomPrenom").ToString();
                csVis.suivant();
            }
            csVis.fermer();
            cbx_numrapport.Show();

        }

        private void cbx_numrapport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;
            praticvalue = null;
            motifvalue = null;
            praticrempvalue = null;
            liste_med.Clear();

            id = cbx_numrapport.SelectedItem.ToString();
            CURS cs = new CURS(LoginPage.ChaineConnexion);
            string requete = "select COL_MATRICULE, RAP_NUM, PRA_NUM, RAP_DATE, RAP_BILAN, date_visite, motifs.libelle as motif, id_motif, PRA_NUM_REMP, date_visite from rapport_visite INNER JOIN motifs ON rapport_visite.id_motif=motifs.id WHERE RAP_NUM=";
            requete += id + " AND COL_MATRICULE = '" + LoginPage.Id + "';";

            cs.ReqSelect(requete);
            txt_bilan.Text = cs.champ("RAP_BILAN").ToString();
            dt_daterapp.Text = cs.champ("RAP_DATE").ToString();
            dt_datevis.Text = cs.champ("date_visite").ToString();

            //Debut Praticien

            CURS cs2 = new CURS(LoginPage.ChaineConnexion);
            requete = "SELECT PRA_NUM, PRA_NOM FROM praticien";
            Dictionary<string, string> praticien = new Dictionary<string, string>();
            cs2.ReqSelect(requete);
            cbx_pratic.DataSource = null;
            cbx_pratic.Items.Clear();
            while(!cs2.Fin())
            {
                praticien.Add(cs2.champ("PRA_NUM").ToString(),cs2.champ("PRA_NOM").ToString());
                cs2.suivant();
            }
            cbx_pratic.DataSource = new BindingSource(praticien, null);
            cbx_pratic.DisplayMember = "Value";
            cbx_pratic.ValueMember = "Key";
            cbx_pratic.Show();
            cs2.fermer();

            cbx_pratic.SelectedValue = praticien[cs.champ("PRA_NUM").ToString()]; //régler problème sémection
            cbx_pratic.SelectedItem=praticien[cs.champ("PRA_NUM").ToString()];
            cbx_pratic.SelectedText = praticien[cs.champ("PRA_NUM").ToString()];
            praticvalue = cs.champ("PRA_NUM").ToString();

            //fin praticien
            //Debut Motif
            CURS cs3 = new CURS(LoginPage.ChaineConnexion);
            requete = "SELECT id, libelle from motifs";
            Dictionary<string, string> motifs = new Dictionary<string, string>();
            cs3.ReqSelect(requete);
            cbx_motifs.DataSource = null;
            while (!cs3.Fin())
            {
                motifs.Add(cs3.champ("id").ToString(), cs3.champ("libelle").ToString());
                cs3.suivant();
            }
            cbx_motifs.DataSource = new BindingSource(motifs, null);
            cbx_motifs.DisplayMember = "Value";
            cbx_motifs.ValueMember = "Key";
            cbx_motifs.Show();
            cs3.fermer();
            cbx_motifs.SelectedValue = motifs[cs.champ("id_motif").ToString()]; //Régler problème de sélection
            cbx_motifs.SelectedItem = motifs[cs.champ("id_motif").ToString()];
            cbx_motifs.SelectedText = motifs[cs.champ("id_motif").ToString()];
            motifvalue = cs.champ("id_motif").ToString();
            // fin motif
            //debut pratic remplant

            CURS cs4 = new CURS(LoginPage.ChaineConnexion);
            requete = "SELECT PRA_NUM, PRA_NOM FROM praticien";
            Dictionary<string, string> praticienRemp = new Dictionary<string, string>();
            cs4.ReqSelect(requete);
            cbx_praticremp.DataSource = null;
            cbx_praticremp.Items.Clear();
            while (!cs4.Fin())
            {
                praticienRemp.Add(cs4.champ("PRA_NUM").ToString(), cs4.champ("PRA_NOM").ToString());
                cs4.suivant();
            }
            cbx_praticremp.DataSource = new BindingSource(praticienRemp, null);
            cbx_praticremp.DisplayMember = "Value";
            cbx_praticremp.ValueMember = "Key";
            cbx_praticremp.Show();
            cs4.fermer();
            if (cs.champ("PRA_NUM_REMP").ToString()!="")
            {
                cbx_praticremp.SelectedValue = praticienRemp[cs.champ("PRA_NUM_REMP").ToString()]; //régler problème sémection
                cbx_praticremp.SelectedItem = praticienRemp[cs.champ("PRA_NUM_REMP").ToString()];
                cbx_praticremp.SelectedText = praticienRemp[cs.champ("PRA_NUM_REMP").ToString()];
                praticrempvalue = cs.champ("PRA_NUM_REMP").ToString();
            }

            //fin pratic remplacant
            //debut echantillon
            dgv_echantillon.Rows.Clear();
            Dictionary<string, string> echantillons = new Dictionary<string, string>();
            
            CURS cs5 = new CURS(LoginPage.ChaineConnexion);
            CURS cs7 = new CURS(LoginPage.ChaineConnexion);
            string reqRapp = "select medicament.MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, OFF_QTE from medicament INNER JOIN offrir ON medicament.MED_DEPOTLEGAL=offrir.MED_DEPOTLEGAL WHERE RAP_NUM=";
            reqRapp += id + " ORDER BY MED_NOMCOMMERCIAL;";
            string reqMedicament = "select MED_DEPOTLEGAL, MED_NOMCOMMERCIAL from medicament ORDER BY MED_NOMCOMMERCIAL ASC;";
            cs5.ReqSelect(reqMedicament);
            cs7.ReqSelect(reqRapp);

            while(!cs7.Fin())
            {
                dgv_echantillon.Rows.Add();
                cs7.suivant();
            }
            while (!cs5.Fin())
            {
                echantillons.Add(cs5.champ("MED_DEPOTLEGAL").ToString(), cs5.champ("MED_NOMCOMMERCIAL").ToString());
                cs5.suivant();
            }

            // on récupère le numéro de ligne du datagrid correspondant à la cellule sélectionnée
            //creationRapportBindingSource.DataSource = new BindingSource(comboMedicament, null);
            // lib_med.ValueMember = "Key";

            cbx_medic.DataSource = new BindingSource(echantillons, null);
            //lib_med.Items.AddRange(comboMedicament.ToDictionary());
            cbx_medic.DisplayMember = "Value";
            cbx_medic.ValueMember = "Key";

            /*while(!cs7.Fin())
             {
                 cbx_medic.ValueMember = cs7.champ("MED_DEPOTLEGAL").ToString();
                 cs7.suivant();
             }*/

            int compte = 0;
            CURS cs8 = new CURS(LoginPage.ChaineConnexion);
            cs8.ReqSelect(reqRapp);
            while(!cs8.Fin())
            {
                dgv_echantillon.Rows[compte].Cells["cbx_medic"].Value = cs8.champ("MED_DEPOTLEGAL").ToString();
                dgv_echantillon.Rows[compte].Cells["txt_quantite"].Value = cs8.champ("OFF_QTE").ToString();
                liste_med.Add(cs8.champ("MED_DEPOTLEGAL").ToString());
                cs8.suivant();
                compte += 1;
            }
            cs5.fermer();
            //Fin echantillon

            //Debut Coef

            CURS cs6 = new CURS(LoginPage.ChaineConnexion);
            requete = "SELECT CoefConf from rapport_visite WHERE RAP_NUM=";
            requete += id+";";
            cs6.ReqSelect(requete);
            trb_coef.Value = Int32.Parse(cs6.champ("CoefConf").ToString());
        }

        private void txt_motif_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_daterapp_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btn_modif_Click(object sender, EventArgs e)
        {
            string reqOffrir = "";


            for (int i = 0; i < dgv_echantillon.RowCount - 1; i++)
            {
                CURS csOffr = new CURS(LoginPage.ChaineConnexion);
                if (liste_med.ElementAtOrDefault(i) != null)
                {
                    reqOffrir = "UPDATE offrir SET MED_DEPOTLEGAL='" + dgv_echantillon.Rows[i].Cells["cbx_medic"].Value + "', OFF_QTE=" + dgv_echantillon.Rows[i].Cells["txt_quantite"].Value;
                    reqOffrir += " WHERE RAP_NUM='" + cbx_numrapport.SelectedItem.ToString() + "' AND MED_DEPOTLEGAL='" + liste_med[i] + "' AND COL_MATRICULE = '" + LoginPage.Id + "';";
                    csOffr.ReqSelect(reqOffrir);
                    csOffr.fermer();
                }
                else
                {
                    reqOffrir = "INSERT INTO offrir(COL_MATRICULE, RAP_NUM, MED_DEPOTLEGAL, OFF_QTE) VALUES ('" + LoginPage.Id + "', ";
                    reqOffrir += cbx_numrapport.SelectedItem.ToString() + ", '";
                    reqOffrir += dgv_echantillon.Rows[i].Cells["cbx_medic"].Value + "', ";
                    reqOffrir += dgv_echantillon.Rows[i].Cells["txt_quantite"].Value + ");";
                    liste_med.Add(dgv_echantillon.Rows[i].Cells["cbx_medic"].Value.ToString());
                    csOffr.ReqSelect(reqOffrir);
                    csOffr.fermer();
                }
            }

            CURS csRapp = new CURS(LoginPage.ChaineConnexion);
            string requete = "UPDATE rapport_visite SET id_motif=";
            requete += motifvalue + ", RAP_BILAN='";
            if (chkbox_date_rapport.Checked)
            {
                requete += txt_bilan.Text + "', RAP_DATE='";
                requete += dt_daterapp.Value.ToString("yyyy-MM-dd") + "', PRA_NUM=";
            }
            else
            {
                requete += txt_bilan.Text + "', PRA_NUM=";
            }
            requete += praticvalue + ", date_visite='";
            if (praticrempvalue != null)
            {
                requete += dt_datevis.Value.ToString("yyyy-MM-dd") + "', PRA_NUM_REMP=";
                requete += praticrempvalue + ", CoefConf=";
            }
            else
            {
                requete += dt_datevis.Value.ToString("yyyy-MM-dd") + "', CoefConf=";
            }
            requete += trb_coef.Value.ToString() + " WHERE RAP_NUM=";
            requete += cbx_numrapport.SelectedItem.ToString() + " AND COL_MATRICULE = '" + LoginPage.Id + "';";
            csRapp.ReqSelect(requete);
            MessageBox.Show("Les informations de ce rapport de visite ont bien été modifiées");

        }

        private void dt_datevis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbx_pratic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (praticvalue != null)
            {
                praticvalue = ((KeyValuePair<string, string>)cbx_pratic.SelectedItem).Key;
            }
        }

        private void cbx_motifs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motifvalue != null)
            {
                motifvalue = ((KeyValuePair<string, string>)cbx_motifs.SelectedItem).Key;
            }
        }

        private void cbx_praticremp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (praticrempvalue != null)
            {
                praticrempvalue = ((KeyValuePair<string, string>)cbx_praticremp.SelectedItem).Key;
            }
        }

        private void dgv_echantillon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkbox_date_rapport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_date_rapport.Checked)
            {
                lbl_date.Visible = true;
                dt_daterapp.Visible = true;
            }
            else
            {
                lbl_date.Visible = false;
                dt_daterapp.Visible = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            menu m = new menu();
            m.Show();
        }
    }
}
