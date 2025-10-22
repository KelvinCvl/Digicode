using System.Text;
namespace WinFormsApp1
{

    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            //ouverture du fichier
            StreamReader monFichier = new StreamReader("digicod_perso.csv", Encoding.Default);
            //lecture des données pour enregistrement dans le tableau structuré
            string ligneFichier;
            //lecture de la ligne de titre
            ligneFichier = monFichier.ReadLine();
            //lecture des autres lignes 
            int i = 0;
            while ((ligneFichier = monFichier.ReadLine()) != null)
            {
                //extraction des informations des 4 colonnes 
                //pour les placer dans le tableau structuré
                string[] lesColonnes;
                lesColonnes = ligneFichier.Split(';');

                donnees.tabListe[i].matricule = int.Parse(lesColonnes[0]);
                i++;
            }
            //nombre de lignes dans le tableau
            donnees.nbListe = i;

            //fermeture du fichier
            monFichier.Close();
            i = 0;

            StreamReader monFichier2 = new StreamReader("digicod_secure.csv", Encoding.Default);
            string ligneFichier2;
            ligneFichier2 = monFichier2.ReadLine();
            while ((ligneFichier2 = monFichier2.ReadLine()) != null)
            {
                //extraction des informations des 4 colonnes 
                //pour les placer dans le tableau structuré
                string[] lesColonnes2;
                lesColonnes2 = ligneFichier2.Split(';');

                donnees.tabListe2[i].autorisation = lesColonnes2[0];
                donnees.tabListe2[i].datedebut = lesColonnes2[1];
                donnees.tabListe2[i].mdp = lesColonnes2[3];
                i++;
            }
            //nombre de lignes dans le tableau
            donnees.nbListe2 = i;

            //fermeture du fichier
            monFichier2.Close();



        }

        //verification des matricule et des mot de passe
        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            bool validematricule = false;
            bool validemdp = false;
            for (int i = 0; i < donnees.nbListe; i++)
            {
                if (donnees.tabListe[i].matricule == int.Parse(tb_matricule.Text))
                {
                    donnees.verifmatricule = true;
                    validematricule = true;
                }
            }
            for (int i = 0; i < donnees.nbListe; i++)
            {
                if (donnees.tabListe2[i].mdp == tb_mdp.Text)
                {
                    donnees.verifmdp = true;
                    validemdp = true;
                }
            }
            if (validematricule == true && validemdp == true)
            {
                cryptage maForm = new cryptage();
                maForm.Show();
            }
            else
            {
                if (validematricule == false && validemdp == false)
                {
                    MessageBox.Show("Votre matricule et votre mot de passe sont incorrect");
                }
                else if (validematricule == false)
                {
                    MessageBox.Show("Votre matricule est incorrect");
                }
                else
                {
                    MessageBox.Show("Votre mot de passe est incorrect");
                }
            }
        }
        //boutton quitter qui fonctionne
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
