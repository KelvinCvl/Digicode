using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Text;
using static WinFormsApp1.donnees;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsApp1
{
    public partial class cryptage : Form
    {
        public cryptage()
        {
            InitializeComponent();

        }

        private void cryptage_Load(object sender, EventArgs e)
        {
            //affichage d'un message de prévention si il reste 3 jours ou moins avant le prochain changement de mdp
            msgdate.Visible = false;

            DateTime Date = DateTime.Now;

            if (Date.Month == 1 || Date.Month == 3 || Date.Month == 5 || Date.Month == 7 || Date.Month == 8 || Date.Month == 10 || Date.Month == 12)
            {
                if (31 - Date.Day < 4)
                {
                    msgdate.Visible = true;
                }
            }
            else if (Date.Month == 4 || Date.Month == 6 || Date.Month == 9 || Date.Month == 11)
            {
                if (30 - Date.Day < 4)
                {
                    msgdate.Visible = true;
                }
            }
            else
            {
                if (29 - Date.Day < 4)
                {
                    msgdate.Visible = true;
                }
            }
        }

        private bool Verify(string text)
        {
            //verification du mot à coder
            if (text.Length != 6)
            {
                MessageBox.Show("Veulliez entrer un mot de 6 lettres");
                return false;
            }
            else
            {
                int i = 0;
                bool trouve = false;
                while (i < text.Length && trouve == false)
                {
                    if (char.IsDigit(text[i]))
                    {
                        trouve = true;
                        MessageBox.Show("Veulliez entrer uniquement des lettres");
                    }
                    i++;
                }
                if (trouve == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        private int finmois(int mois)
        {
            //fontion pour trouver le nombre de jour présent dans le mois
            int jours;
            DateTime Date = DateTime.Now;
            if (Date.Month == 1 || Date.Month == 3 || Date.Month == 5 || Date.Month == 7 || Date.Month == 8 || Date.Month == 10 || Date.Month == 12)
            {
                jours = 31;
                return jours;
            }
            else if (Date.Month == 4 || Date.Month == 6 || Date.Month == 9 || Date.Month == 11)
            {
                jours = 30;
                return jours;
            }
            else
            {
                jours = 29;
                return jours;
            }
        }

        private void btn_calcul1_Click(object sender, EventArgs e)
        {
            //verifie si le mot de passe à déjà été changé ou non
            DateTime Date = DateTime.Now;
            bool deja = false;
            if (Verify(tb_motentree.Text) == true && deja == false)
            {
                //actualise les variables
                StreamReader monFichier2 = new StreamReader("digicod_secure.csv", Encoding.Default);
                string ligneFichier2;
                ligneFichier2 = monFichier2.ReadLine();
                int i = 0;
                while ((ligneFichier2 = monFichier2.ReadLine()) != null)
                {
                    string[] lesColonnes2;
                    lesColonnes2 = ligneFichier2.Split(';');

                    donnees.tabListe2[i].autorisation = lesColonnes2[0];
                    donnees.tabListe2[i].datedebut = lesColonnes2[1];
                    donnees.tabListe2[i].mdp = lesColonnes2[3];
                    i++;
                }
                donnees.nbListe2 = i;
                monFichier2.Close();
                for (int j = 0; j < donnees.nbListe2; j++)
                {
                    //verifie que le mot de passe n'a pas déjà été changé 
                    if (!string.IsNullOrEmpty(donnees.tabListe2[j].datedebut))
                    {
                        DateTime date_excel = Convert.ToDateTime(donnees.tabListe2[j].datedebut);
                        if (donnees.tabListe2[j].autorisation == "E" && date_excel.Month == Date.Month)
                        {
                            MessageBox.Show("Ce mot de passe à déjà été changé pour le mois");
                            deja = true;
                        }
                    }
                }
            }
            // ajoute la ligne au fichier
            if (deja == false)
            {
                using (StreamWriter monFichier3 = new StreamWriter("digicod_secure.csv", true))
                {
                    monFichier3.WriteLine("E" + ";" + "01/" + Date.Month + "/" + Date.Year + ";" + finmois(Date.Month) + "/" + Date.Month + "/" + Date.Year + ";" + CODE1(tb_motentree.Text));
                }
                tb_resultatentree.Text = CODE1(tb_motentree.Text);
            }
        }
        //crypte le mot de la porte d'entrée
        private string CODE1(string text)
        {
            string liste = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] code = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < liste.Length; j++)
                {
                    if (text[i] == liste[j])
                    {
                        code[i] = (j + 10) % 26;
                    }
                }
            }

            string newcode = "";
            for (int i = 0; i < code.Length; i++)
            {
                newcode = newcode + liste[code[i]];
            }
            return newcode;
        }

        private void btn_Calcul_Click(object sender, EventArgs e)
        {
            //verifie si le mot de passe à déjà été changé ou non
            DateTime Date = DateTime.Now;
            bool deja = false;
            if (Verify(tb_motinfo.Text) == true && deja == false)
            {
                //actualise les variables
                StreamReader monFichier2 = new StreamReader("digicod_secure.csv", Encoding.Default);
                string ligneFichier2;
                ligneFichier2 = monFichier2.ReadLine();
                int i = 0;
                while ((ligneFichier2 = monFichier2.ReadLine()) != null)
                {
                    string[] lesColonnes2;
                    lesColonnes2 = ligneFichier2.Split(';');

                    donnees.tabListe2[i].autorisation = lesColonnes2[0];
                    donnees.tabListe2[i].datedebut = lesColonnes2[1];
                    donnees.tabListe2[i].mdp = lesColonnes2[3];
                    i++;
                }
                donnees.nbListe2 = i;
                monFichier2.Close();
                for (int j = 0; j < nbListe2; j++)
                {
                    //verifie que le mot de passe n'a pas déjà été changé
                    if (!string.IsNullOrEmpty(donnees.tabListe2[j].datedebut))
                    {
                        DateTime date_excel = Convert.ToDateTime(donnees.tabListe2[j].datedebut);
                        if (donnees.tabListe2[j].autorisation == "I" && date_excel.Month == Date.Month)
                        {
                            MessageBox.Show("Ce mot de passe à déjà été changé pour le mois");
                            deja = true;
                        }
                    }
                }
            }
            // ajoute la ligne au fichier
            if (deja == false)
            {
                using (StreamWriter monFichier3 = new StreamWriter("digicod_secure.csv", true))
                {
                    monFichier3.WriteLine("I" + ";" + "01/" + Date.Month + "/" + Date.Year + ";" + finmois(Date.Month) + "/" + Date.Month + "/" + Date.Year + ";" + CODE2(tb_motinfo.Text));
                }
                tb_resultatinfo.Text = CODE2(tb_motinfo.Text);
            }

        }
        //crypte le mot de la porte d'entrée
        private string CODE2(string text)
        {
            string liste = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] code = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < liste.Length; j++)
                {
                    if (text[i] == liste[j])
                    {
                        code[i] = ((33 * j) + 1) % 26;
                    }
                }
            }

            string newcode = "";
            for (int i = 0; i < code.Length; i++)
            {
                newcode = newcode + liste[code[i]];
            }
            return newcode;
        }
        //Application.exit() qui fonctionne pas du coup j'ai opté pour un exit différent
        private void btn_quitter2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
