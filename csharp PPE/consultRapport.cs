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
    public partial class consultRapport : Form
    {

        public consultRapport()
        {
            InitializeComponent();
        }

        private void consultRapport_Load(object sender, EventArgs e)
        {
            cacherItem();
            txtbox_visiteur.Text = getNomPrenom_Visiteur();

            CURS cs = new CURS(LoginPage.ChaineConnexion);
            

            string req_id = "SELECT `RAP_NUM` FROM `rapport_visite` WHERE `COL_MATRICULE` = '" + LoginPage.Id + "';";
            cs.ReqSelect(req_id);
            while (!cs.Fin())
            {
                cbx_numrap.Items.Add(cs.champ("RAP_NUM"));
                cs.suivant();
            }
            cs.fermer();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultRapport_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            menu m = new menu();
            m.Show();
        }

        private void cacherItem()
        {
            lbl_prac.Visible = false;
            txtbox_prac.Visible = false;
            lbl_dateVisite.Visible = false;
            lbl_motif.Visible = false;
            txtbox_motif.Visible = false;
            lbl_bilan.Visible = false;
            richTextBox1.Visible = false;
            lbl_offre.Visible = false;
            dataGridView1.Visible = false;
            chackDateRap.Visible = false;
            chackPratRemp.Visible = false;
            dateVisite.Visible = false;
            tbar_coef.Visible = false;
            txt_coef.Visible = false;
        }

        private void showItem()
        {
            lbl_prac.Visible = true;
            txtbox_prac.Visible = true;
            lbl_dateVisite.Visible = true;
            lbl_motif.Visible = true;
            txtbox_motif.Visible = true;
            lbl_bilan.Visible = true;
            richTextBox1.Visible = true;
            lbl_offre.Visible = true;
            dataGridView1.Visible = true;
            chackDateRap.Visible = true;
            chackPratRemp.Visible = true;
            dateVisite.Visible = true;
            tbar_coef.Visible = true;
            txt_coef.Visible = true;
        }

        private void cbx_numrap_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            showItem();
            string praticien = "";
            string dateRapport = "";
            string bilan = "";
            string dateVisi = "";
            string motif = "";
            string praticienRemp = "";
            string coef = "";

            CURS cs = new CURS(LoginPage.ChaineConnexion);
            cs.DefFonctStockee("getRapport");
            cs.ajouteparametreCol("IdVisiteur", LoginPage.Id);
            cs.directionparametreCol("IdVisiteur", ParameterDirection.InputOutput);

            cs.ajouteparametreCol("IdRapport", cbx_numrap.SelectedItem.ToString());
            cs.directionparametreCol("IdRapport", ParameterDirection.InputOutput);

            cs.ajouteparametreCol("idPraticien", praticien);
            cs.directionparametreCol("idPraticien", ParameterDirection.Output);

            cs.ajouteparametreCol("dateRapport", dateRapport);
            cs.directionparametreCol("dateRapport", ParameterDirection.Output);

            cs.ajouteparametreCol("bilan", bilan);
            cs.directionparametreCol("bilan", ParameterDirection.Output);

            cs.ajouteparametreCol("dateVisite", dateVisi);
            cs.directionparametreCol("dateVisite", ParameterDirection.Output);

            cs.ajouteparametreCol("idMotif", motif);
            cs.directionparametreCol("idMotif", ParameterDirection.Output);

            cs.ajouteparametreCol("idPraticienRemp", praticienRemp);
            cs.directionparametreCol("idPraticienRemp", ParameterDirection.Output);

            cs.ajouteparametreCol("coef", coef);
            cs.directionparametreCol("coef", ParameterDirection.Output);

            cs.Appelfonctstockee();
            txtbox_prac.Text = getPrac(Convert.ToString(cs.getCol()[2].Value));

            //string req = "SELECT * FROM `rapport_visite` WHERE `COL_MATRICULE` = '" + LoginPage.Id + "' AND RAP_NUM = '" + cbx_numrap.SelectedItem.ToString() +"';";

            //cs.ReqSelect(req);
            /*while (!cs.Fin())
            {*/
                //txtbox_prac.Text = getPrac(cs.champ("PRA_NUM").ToString());
                if (Convert.ToString(cs.getCol()[3].Value) == "")
                {
                    chackDateRap.Checked = false;
                }
                else
                {
                    chackDateRap.Checked = true;
                    datebox.Text = Convert.ToString(cs.getCol()[3].Value);
                }
                if (Convert.ToString(cs.getCol()[7].Value) == "")
                {
                    chackPratRemp.Checked = false;
                }
                else
                {
                    chackPratRemp.Checked = true;
                    txtbox_PraRemp.Text = getPrac(Convert.ToString(cs.getCol()[7].Value));
                }
                tbar_coef.Value = Int32.Parse(Convert.ToString(cs.getCol()[8].Value));
                txt_coef.Text = Convert.ToString(cs.getCol()[8].Value);
                dateVisite.Text = Convert.ToString(cs.getCol()[5].Value);
                txtbox_motif.Text = getMotif(Convert.ToString(cs.getCol()[6].Value));
                richTextBox1.Text = Convert.ToString(cs.getCol()[4].Value);
                CURS cs1 = new CURS(LoginPage.ChaineConnexion);
                string med = "SELECT `MED_DEPOTLEGAL`, `OFF_QTE` FROM `offrir` WHERE `COL_MATRICULE` = '" + LoginPage.Id + "' AND `RAP_NUM` = '" + cbx_numrap.SelectedItem.ToString() + "';";
                cs1.ReqSelect(med);
                while (!cs1.Fin())
                {
                    CURS cs2 = new CURS(LoginPage.ChaineConnexion);
                    string reqmed = "SELECT `MED_NOMCOMMERCIAL` FROM `medicament` WHERE `MED_DEPOTLEGAL` = '" + cs1.champ("MED_DEPOTLEGAL") + "';";
                    cs2.ReqSelect(reqmed);
                    while (!cs2.Fin())
                    {
                        dataGridView1.Rows.Add(cs2.champ("MED_NOMCOMMERCIAL"), cs1.champ("OFF_QTE"));
                        cs2.suivant();
                    }
                    cs1.suivant();
                }
                cs1.fermer();
            
        }

        private string getPrac(string prac)
        {
            string nom_prenom = "";
            CURS cs = new CURS(LoginPage.ChaineConnexion);
            string req = "SELECT `PRA_NOM`, `PRA_PRENOM` FROM `praticien` WHERE `PRA_NUM` = '" + prac + "';";
            cs.ReqSelect(req);
            while (!cs.Fin())
            {
                nom_prenom = cs.champ("PRA_NOM").ToString() + " " + cs.champ("PRA_PRENOM").ToString();
                cs.suivant();
            }
            cs.fermer();
            return nom_prenom;
        }

        private string getMotif(string motif)
        {
            string mot = "";
            CURS cs = new CURS(LoginPage.ChaineConnexion);
            string req = "SELECT `libelle` FROM `motifs` WHERE `id` = " + motif + ";";
            cs.ReqSelect(req);
            while (!cs.Fin())
            {
                mot = cs.champ("libelle").ToString();
                cs.suivant();
            }
            cs.fermer();
            return mot;
        }

        private void chackPratRemp_CheckedChanged(object sender, EventArgs e)
        {
            if (chackPratRemp.Checked == true)
            {
                txtbox_PraRemp.Visible = true;
            }
            else
            {
                txtbox_PraRemp.Visible = false;
            }
        }

        private void chackDateRap_CheckedChanged(object sender, EventArgs e)
        {
            if (chackDateRap.Checked == true)
            {
                datebox.Visible = true;
            }
            else
            {
                datebox.Visible = false;
            }
        }

        private string getNomPrenom_Visiteur()
        {
            string nom_Prenom = "";
            CURS cs = new CURS(LoginPage.ChaineConnexion);
            string req = "SELECT CONCAT(`COL_NOM`, ' ', `COL_PRENOM`) AS NomPrenom FROM `collaborateur` WHERE `COL_MATRICULE` = '" + LoginPage.Id + "';";
            cs.ReqSelect(req);
            while (!cs.Fin())
            {
                nom_Prenom = cs.champ("NomPrenom").ToString();
                cs.suivant();
            }
            cs.fermer();
            return nom_Prenom;
        }

        private void tbar_coef_Scroll(object sender, EventArgs e)
        {
            txt_coef.Text = tbar_coef.Value.ToString();
        }
    }
}
