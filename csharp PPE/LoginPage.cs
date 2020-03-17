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
    public partial class LoginPage : Form
    {
        // Variable contenant la chaine de connexion, la variable est static pour pouvoir être réutilisé dans d'autre classe
        static string chaineConnexion;

        // Variable contenant l'id du visiteur connecter, permettant de le récupérer dans les autres classes.
        static private string _id;

        // Getter / Setter permettant d'accéder à la chaine de connexion, ils sont static pour pouvoir être réutilisé dans d'autre classe
        public static string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }

        // Getter / Setter permettant d'accéder à l'id du visiteur connecté, ils sont static pour pouvoir être réutilisé dans d'autre classe
        public static string Id { get => _id; set => _id = value; }

        public LoginPage()
        {
            // Définition de la chaine de connexion
            ChaineConnexion = "server=localhost;user=root;database=gsb_c;SSL Mode=None;";

            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        // Cette Fonction est appelée quand on cliquer sur le bouton Connexion
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Si aucune information n'est renseigné il affichera un message d'erreur demandant de renseigner les logins
            if (txtbox_id.Text == "Login" || txtbox_mdp.Text == "Mot de passe")
            {
                lbl_erreur.Text = "Veuillez saisir votre mot de passe et votre identifiant";
                lbl_erreur.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //Si des informations ont été saisies, il vérifie si les informations sont exacts grâce à la fonction verif_login()
                if (verif_login(txtbox_id.Text, txtbox_mdp.Text))
                {
                    //si les informations sont exactes, il affiche le menu
                    Form.ActiveForm.Hide();
                    menu m = new menu();
                    m.Show();
                }
                else
                {
                    //si les informations sont fausses, il affiche un message d'erreur
                    lbl_erreur.Text = "Identifiant ou mots de passe incorrecte";
                    lbl_erreur.ForeColor = System.Drawing.Color.Red;
                }


            }

        }


        private bool verif_login(string login, string password)
        {
            bool ok = false;
            CURS cs = new CURS(ChaineConnexion);
            string requete = "SELECT COUNT(*) FROM collaborateur WHERE COL_NOM = '" + txtbox_id.Text + "' AND COL_DATEEMBAUCHE = '" + txtbox_mdp.Text + "';";
            string count = cs.Compter(requete);
            cs.fermer();
            if (count == "0")
            {

            ok = false;
        }
            else
            {
                CURS cs2 = new CURS(ChaineConnexion);
                string req_id = "SELECT COL_MATRICULE FROM collaborateur WHERE COL_NOM = '" + txtbox_id.Text + "' AND COL_DATEEMBAUCHE = '" + txtbox_mdp.Text + "';";
                cs2.ReqSelect(req_id);
                while (!cs2.Fin())
                {
                    Id = cs2.champ("COL_MATRICULE").ToString();
                    cs2.suivant();
                }
                cs2.fermer();
                ok = true;
            }

            return ok;
        }

        private void txtbox_id_Enter(object sender, EventArgs e)
        {
            if (txtbox_id.Text == "Login")
            {
                txtbox_id.Text = "";
                txtbox_id.ForeColor = Color.Black;
            }
        }

        private void txtbox_id_Leave(object sender, EventArgs e)
        {
            if (txtbox_id.Text == "")
            {
                txtbox_id.Text = "Login";
                txtbox_id.ForeColor = Color.Silver;
            }
        }

        private void txtbox_mdp_Enter(object sender, EventArgs e)
        {
            if (txtbox_mdp.Text == "Mot de passe")
            {
                txtbox_mdp.Text = "";
                txtbox_mdp.UseSystemPasswordChar = true;
                txtbox_mdp.ForeColor = Color.Black;
            }
        }

        private void txtbox_mdp_Leave(object sender, EventArgs e)
        {
            if (txtbox_mdp.Text == "")
            {
                txtbox_mdp.Text = "Mot de passe";
                txtbox_mdp.UseSystemPasswordChar = false;
                txtbox_mdp.ForeColor = Color.Silver;
            }
        }
    }
}
