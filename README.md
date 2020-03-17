<h1>Appli c#PPE Doc</h1>
<p>Ici vous retrouverez la documentation à propos de notre application c# pour le thème GSB</p>
<h2><a href="https://github.com/AkumaSama/PPE-c-/blob/master/csharp%20PPE/LoginPage.cs">LoginPage.cs</a></h2>
<img src="https://cdn.discordapp.com/attachments/629286204340437022/655166740572930049/unknown.png">
<h3>Contenu du Formulaire
<ul>
  <li><h5>Label</h5>
  <ul>
    <li>Identifiant : lbl_identifiant
    <li>Mot de passe : lbl_mdp | label avec PasswordChar = '•'
    <li>Erreur : lbl_erreur
  </ul>
  <li><h5>Text Box</h5>
  <ul>
    <li>identifiant : textbox_id
    <li>mot de passe : textbox_mdp
  </ul>
  <li><h5>Bouton</h5>
  <ul>
    <li>Connexion : btn_login
  </ul>
</ul>
<h3>Fonctionnalité du formulaire</h3>
<ul>
    <li><H5>Connexion</h5>
    <ul>
        <li> Le mot de passe est protégé par un caractère qui remplace les caractère saisies
        <img src="https://cdn.discordapp.com/attachments/629286204340437022/655168890665435156/unknown.png">
        <li> L'identifiant et le mot de passe doit être rempli pour pouvoir se connecter
        <img src="https://cdn.discordapp.com/attachments/629286204340437022/655169378702196747/unknown.png">
        <li> Une fois la connexion établit, la fenêtre est cachée en utilisant la fonction Hide() comme ceci : this.Hide();
    </ul>
<hr>
<h2><a href="https://github.com/AkumaSama/PPE-c-/blob/master/csharp%20PPE/menu.cs">menu.cs</a></h2>
<img src="https://cdn.discordapp.com/attachments/629286204340437022/655167522127085588/unknown.png">
<ul>
    <li><h5>MenuStrip<h5>
    <ul>
        <li>rapport de visite : rapportMenu
        <li>sous-menu création : créationToolStripMenuItem
        <li>sous-menu modification : modificationToolStripMenuItem
    </ul>
    <li><h5>Bouton Quitter</h5>
    <ul>
        <li>Permet d'arrêter complètement l'application à l'aide de la fonction Application.Exit()
</ul>
<h3>Fonctionnalité du formulaire</h3>
<ul>
    <li><H5>Choix</h5>
    <ul>
        <li> Cette page permet de sélectionner soit la création d'un rapport soit la modification d'un rapport à l'aide d'un menustrip. Une fois la page sélectionnée, celle afficher disoarait et l'autre s'affiche.
    </ul>
    <li><h5>Quitter la page</h5>
    <ul>
        <li>Cette page gère l'extinction de la page, on peut donc fermer cette page uniquement en appuyant sur le bouton Quitter grâce à la fonction Application.Exit()
        <br><img src="https://cdn.discordapp.com/attachments/629286204340437022/655465911255564298/unknown.png">
        <P>Pour permettre cela, on passe par la fonction : menu_FormClosing
        <p>et on ajoute menu.Designer.cs la ligne : <strong>this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing); </strong>
        <p>Mettre la ligne e.Cancel = true permet d'annuler la fermeture du formulaire
    </ul>
</ul>    
<hr>
<h2><a href="https://github.com/AkumaSama/PPE-c-/blob/master/csharp%20PPE/menu.cs">creationRapport.cs</a></h2>