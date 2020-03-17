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
    public partial class supprRapport : Form
    {
        //Création de variable en readonly (non modifiable)
        private static readonly string reqGetListRapport = "SELECT RAP_NUM FROM rapport_visite WHERE COL_MATRICULE = '" + LoginPage.Id + "';";
        private static readonly string reqGetRapportById = "SELECT libelle, PRA_NOM, PRA_PRENOM, rapport_visite.COL_MATRICULE, RAP_NUM, rapport_visite.PRA_NUM, RAP_DATE, RAP_BILAN, " +
            "date_visite, CoefConf, id_motif, PRA_NUM_REMP FROM ((praticien INNER JOIN rapport_visite ON praticien.PRA_NUM = rapport_visite.PRA_NUM) " +
            "INNER JOIN motifs ON rapport_visite.id_motif = motifs.id) WHERE COL_MATRICULE = '" + LoginPage.Id + "' AND RAP_NUM = ";
        private static readonly string requestSuppr = "DELETE FROM rapport_visite WHERE COL_MATRICULE = '" + LoginPage.Id + "' AND RAP_NUM = ";
        //Création de la liste d'object utilisé pour sauvegarder les variables du rapport
        private static List<object> rapport = new List<object>();
        //Création de la variable pour se connecter
        private static CURS connect;

        public supprRapport()
        {
            InitializeComponent();
        }

        //Event au chargement de la page
        private void supprRapport_Load(object sender, EventArgs e)
        {
            //Création de la connection
            connect = new CURS(LoginPage.ChaineConnexion);

            //éxecution de la requête
            connect.ReqSelect(reqGetListRapport);
            //Tant qu'il y a un enregistrement apres celui en cours
            while(!connect.Fin())
            {
                //Ajout de l'id du rapport dans la combo box
                comboBox1.Items.Add(connect.champ("RAP_NUM"));
                //Passage à l'enregistrement suivant
                connect.suivant();
            }
            //Fermeture de la connection
            connect.fermer();

            connect = new CURS(LoginPage.ChaineConnexion);

            string reqRapVisiteur = "select CONCAT(COL_NOM, ' ', COL_PRENOM) AS NomPre FROM collaborateur where COL_MATRICULE = '" + LoginPage.Id + "';";
            connect.ReqSelect(reqRapVisiteur);
            while (!connect.Fin())
            {
                //Ajout de l'id du rapport dans la combo box
                txtbox_visi.Text = connect.champ("NomPre").ToString();
                //Passage à l'enregistrement suivant
                connect.suivant();
            }
            //Fermeture de la connection
            connect.fermer();
        }

        //Event lors de la sélection dans la combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création de la connection
            connect = new CURS(LoginPage.ChaineConnexion);
            //Création de la requete selon l'id du rapport sélectionner
            String requete = reqGetRapportById + "'" + comboBox1.SelectedItem.ToString() + "'";
            //Création de la connection
            connect.ReqSelect(requete);

            //Récupération des valeurs de la requête
            object COL_MATRICULE = connect.champ("COL_MATRICULE");
            object RAP_NUM = connect.champ("RAP_NUM");
            object PRA_NUM = connect.champ("PRA_NUM");
            object RAP_DATE = connect.champ("RAP_DATE");
            object RAP_BILAN = connect.champ("RAP_BILAN");
            object DATE_VISITE = connect.champ("date_visite");
            object COEFCONF = connect.champ("CoefConf");
            object ID_MOTIF = connect.champ("id_motif");
            object PRA_NUM_EMP = connect.champ("PRA_NUM_REMP");

            string MOTIF_LIBELLE = connect.champ("libelle").ToString();
            string PRA_PRENOM_NOM = connect.champ("PRA_NOM").ToString() + " " + connect.champ("PRA_PRENOM").ToString();
            string PRA_PRENOM_NOM_EMP = connect.champ("PRA_NOM").ToString() + " " + connect.champ("PRA_PRENOM").ToString();

            //Vidage de la liste + ajout des variables à l'intérieur afin de les récupérer lors de l'activation de la suppression
            rapport.Clear();
            rapport.Add(COL_MATRICULE);
            rapport.Add(RAP_NUM);
            rapport.Add(PRA_NUM);
            rapport.Add(RAP_DATE);
            rapport.Add(RAP_BILAN);
            rapport.Add(DATE_VISITE);
            rapport.Add(COEFCONF);
            rapport.Add(ID_MOTIF);
            rapport.Add(PRA_NUM_EMP);

            //Ajout des variables dans leur box respective
            textBox1.Text = PRA_PRENOM_NOM;
            textBox2.Text = RAP_DATE.ToString();
            richTextBox1.Text = RAP_BILAN.ToString();
            textBox3.Text = DATE_VISITE.ToString();
            textBox4.Text = PRA_PRENOM_NOM_EMP;
            textBox5.Text = MOTIF_LIBELLE;
            textBox6.Text = COEFCONF.ToString();

            //Fermeture de la connection
            connect.fermer();
        }

        //Event quand l'utilisateur click sur le bouton supprimer
        private void button1_Click(object sender, EventArgs e)
        {
            //Création de la connection
            connect = new CURS(LoginPage.ChaineConnexion);
            //Requete de suppression avec l'id du rapport
            string supprRequest = requestSuppr + "'" + rapport[1].ToString() + "'";
            //Requete de sauvegarde
            string requete = "INSERT INTO save_rapport (COL_MATRICULE, RAP_NUM, PRA_NUM, RAP_DATE, RAP_BILAN, date_visite, CoefConf, id_motif, PRA_NUM_REMP)" +
                " VALUES (";
            //Ajout des variables dans la requête de sauvegarde
            foreach(object rap in rapport)
            {
                //Test si la variable est null
                if (rap.ToString() == "")
                {
                    //Rajout de "null" si la variable est null
                    requete += "null";
                } else
                {
                    //Rajout de la variable en text si elle est différent de null
                    //Si c'est une date on l'enregistre spécialement car en base c'est un type DateTime
                    if(rap.ToString() == rapport[3].ToString() || rap.ToString() == rapport[5].ToString())
                    {
                        DateTime date = DateTime.Parse(rap.ToString());
                        requete += "'" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    } else
                    {
                        requete += "'" + rap.ToString() + "'";
                    }
                }
                //Ajout d'une virgule à chaque tour
                requete += ", ";
            }//foreach(object rap in rapport)
            //Ajout de la parenthèse a la fin de la requête
            requete = requete.Substring(0, requete.Length - 2) + ")";
            //éxecution de la sauvegarde dans une autre table
            connect.ReqAdmin(requete);
            //éxecution de la requête de suppression
            connect.ReqAdmin(supprRequest);
            //Fermeture de la connection a la base
            connect.fermer();

            //Fermeture de la fenêtre
            Close();
            //Réouverture de la fenêtre pour actualisé les données
            menu main = new menu();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            menu m = new menu();
            m.Show();
        }
    }
}
