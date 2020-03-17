using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_PPE
{
    public partial class creationRapport : Form
    {
        public creationRapport()
        {
            InitializeComponent();
        }

        private void creationRapport_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            CURS cs = new CURS(LoginPage.ChaineConnexion);
            string requete = "select PRA_NUM, PRA_NOM, PRA_PRENOM from praticien ORDER BY PRA_NOM ASC;";
            cs.ReqSelect(requete);
            
            while (!cs.Fin())
            {
                string nom_prenom = cs.champ("PRA_NOM") + " " + cs.champ("PRA_PRENOM");
                comboSource.Add(cs.champ("PRA_NUM").ToString(), nom_prenom);
                cs.suivant();
            }
            cbx_prat.DataSource = new BindingSource(comboSource, null);
            cbx_prat.DisplayMember = "Value";
            cbx_prat.ValueMember = "Key";

            cs.fermer();

            CURS csRapNum = new CURS(LoginPage.ChaineConnexion);
            string reqRapNum = "select MAX(RAP_NUM) as MaxRapNum from rapport_visite;";
            csRapNum.ReqSelect(reqRapNum);
            while(!csRapNum.Fin())
            {
                txtbox_numrap.Text = (Int32.Parse(csRapNum.champ("MaxRapNum").ToString()) + 1).ToString();
                csRapNum.suivant();
            }

            csRapNum.fermer();

            Dictionary<string, string> comboMotif = new Dictionary<string, string>();

            CURS csMotif = new CURS(LoginPage.ChaineConnexion);
            string reqMotif = "select id, libelle from motifs ORDER BY libelle ASC;";
            csMotif.ReqSelect(reqMotif);

            while (!csMotif.Fin())
            {
                comboMotif.Add(csMotif.champ("id").ToString(), csMotif.champ("libelle").ToString());
                csMotif.suivant();
            }
            cbx_motif.DataSource = new BindingSource(comboMotif, null);
            cbx_motif.DisplayMember = "Value";
            cbx_motif.ValueMember = "Key";

            csMotif.fermer();
            CURS csRapVisiteur = new CURS(LoginPage.ChaineConnexion);
            string reqRapVisiteur = "select CONCAT(COL_NOM, ' ', COL_PRENOM) AS NomPre FROM collaborateur where COL_MATRICULE = '" + LoginPage.Id + "';";
            csRapVisiteur.ReqSelect(reqRapVisiteur);
            while (!csRapVisiteur.Fin())
            {
                txtbox_visiteur.Text = csRapVisiteur.champ("NomPre").ToString();
                csRapVisiteur.suivant();
            }

            csRapVisiteur.fermer();

            Dictionary<string, string> comboMedicament = new Dictionary<string, string>();

            CURS csMedicament = new CURS(LoginPage.ChaineConnexion);
            string reqMedicament = "select MED_DEPOTLEGAL, MED_NOMCOMMERCIAL from medicament ORDER BY MED_NOMCOMMERCIAL ASC;";
            csMedicament.ReqSelect(reqMedicament);

            while (!csMedicament.Fin())
            {
                comboMedicament.Add(csMedicament.champ("MED_DEPOTLEGAL").ToString(), csMedicament.champ("MED_NOMCOMMERCIAL").ToString());
                csMedicament.suivant();
            }


            cbx_lib_med.DataSource = new BindingSource(comboMedicament, null);

            cbx_lib_med.DisplayMember = "Value";
            cbx_lib_med.ValueMember = "Key";

            csMedicament.fermer();


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            string strErreur = "";
           if (cbx_prat.Text == "")
           {
                strErreur = " - Vous n'avez pas sélectionné un praticien \n";
           }
           if (richTextBox1.Text == "")
           {
                strErreur = strErreur + " - Vous n'avez pas saisi le bilan \n";
           }
           if (dateboxVisite.Value.ToString("dd/MM/yyyy") == "01/01/2020")
           {
                strErreur = strErreur + " - Vous n'avez pas sélectionné une date différente de celle de départ \n";
           }
           if (strErreur != "")
           {
                strErreur = "La création du rapport ne peut se faire : \n" + strErreur;
                DialogResult dresult = MessageBox.Show(strErreur, "Erreur de saisie");
           }
            else
            {
                string NumRapport = txtbox_numrap.Text;
                string Nom_prenom_visiteur = txtbox_visiteur.Text;
                string NomPre_Praticien = ((KeyValuePair<string, string>)cbx_prat.SelectedItem).Key;
                string NomPre_Prat_Remp = ((KeyValuePair<string, string>)cbx_prat_remp.SelectedItem).Key;
                string datebox_rapport = datebox.Value.ToString("yyyy/MM/dd");
                string datebox_visite = dateboxVisite.Value.ToString("yyyy/MM/dd");
                string motif = ((KeyValuePair<string, string>)cbx_motif.SelectedItem).Key;
                string bilan = richTextBox1.Text;
                string coefConf = trackBar_CoefConf.Value.ToString();
                string medicament = "";
                string quantite = "";

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    medicament = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    quantite = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    CURS csInsertEchantillons = new CURS(LoginPage.ChaineConnexion);
                    string reqInsertEchantillons = "INSERT INTO `offrir`(`COL_MATRICULE`, `RAP_NUM`, `MED_DEPOTLEGAL`, `OFF_QTE`) VALUES ('";
                    reqInsertEchantillons += LoginPage.Id + "', ";
                    reqInsertEchantillons += NumRapport + ", '";
                    reqInsertEchantillons += medicament + "', ";
                    reqInsertEchantillons += quantite + ");";
                    csInsertEchantillons.ReqAdmin(reqInsertEchantillons);

                }

                //string resultat = NumRapport + " " + Nom_prenom_visiteur + " " + NomPre_Praticien + " " + NomPre_Prat_Remp + " " + datebox_rapport + " " + datebox_visite + " " + motif + " " + bilan + " " + medicament + " " + quantite + " " + coefConf;
                //richTest.Text = resultat;

                CURS csInsert = new CURS(LoginPage.ChaineConnexion);
                string reqInsert = "INSERT INTO rapport_visite (COL_MATRICULE, RAP_NUM, PRA_NUM, RAP_DATE, RAP_BILAN, date_visite, id_motif, PRA_NUM_REMP, CoefConf) VALUES ('";
                reqInsert += LoginPage.Id + "', ";
                reqInsert += NumRapport + ", ";
                reqInsert += NomPre_Praticien + ", ";
                if (chkbox_date_rapport.Checked)
                {
                    reqInsert += "'" + datebox_rapport + "', ";
                }
                else
                {
                    reqInsert += "NULL, ";
                }

                reqInsert += "'" + bilan + "', ";
                reqInsert += "'" + datebox_visite + "', ";
                reqInsert += motif + ", ";
                if (cbx_prat_remp.Text == " ")
                {
                    reqInsert += "NULL, ";

                }
                else
                {
                    reqInsert += NomPre_Prat_Remp + ", ";
                }
                reqInsert += coefConf + ");";
                csInsert.ReqAdmin(reqInsert);
                DialogResult dresult2 = MessageBox.Show("La création du rapport s'est bien passée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }

        private void creationRapport_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            menu m = new menu();
            m.Show();
        }

        private void cbx_prat_remp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbx_prat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbx_prat_remp.Items.Clear();
            Dictionary<string, string> comboPratRemp = new Dictionary<string, string>();

            CURS cs2 = new CURS(LoginPage.ChaineConnexion);
            string requete2 = "select PRA_NUM, PRA_NOM, PRA_PRENOM from praticien WHERE PRA_NUM <> " + ((KeyValuePair<string,string>)cbx_prat.SelectedItem).Key + " ORDER BY PRA_NOM ASC;";
            cs2.ReqSelect(requete2);

            comboPratRemp.Add("NULL", " ");
            while (!cs2.Fin())
            {
                string nom_prenom = cs2.champ("PRA_NOM") + " " + cs2.champ("PRA_PRENOM");
                comboPratRemp.Add(cs2.champ("PRA_NUM").ToString(), nom_prenom);
                //cbx_prat_remp.Items.Add(cs2.champ("PRA_NOM") + " " + cs2.champ("PRA_PRENOM"));
                cs2.suivant();
            }
            cbx_prat_remp.DataSource = new BindingSource(comboPratRemp, null);
            cbx_prat_remp.DisplayMember = "Value";
            cbx_prat_remp.ValueMember = "Key";
            cs2.fermer();
        }

        private void txtbox_numrap_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkbox_date_rapport_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox_date_rapport.Checked)
            {
                lbl_date.Visible = true;
                datebox.Visible = true;
            }
            else
            {
                lbl_date.Visible = false;
                datebox.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
