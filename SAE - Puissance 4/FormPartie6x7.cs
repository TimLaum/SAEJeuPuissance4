﻿using BibliothequeJeuPuissance4;
using System.Media;

namespace SAE___Puissance_4
{
    public partial class FormPartie6x7 : Form
    {
        private FormPartiePerso? frmPrmPerso; //Variable pour récupérer les données du formulaire de partie personnalisée
        private int columnNumber; //Variable pour récuperer l'indice de la colonne correspondant a un panel de la partie
        SoundPlayer Musique = new SoundPlayer(Properties.Resources.Musique); //Détermination de la variable de la musique de fond 
        private SoundPlayer JetonPose = new SoundPlayer(Properties.Resources.Son_Placement_Pion); //Son joué a chaque pion posé sur le formulaire
        
        public FormPartie6x7()
        {
            InitializeComponent();
        }

        private void FormPartie6x7_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            TourDuJoueur();//Détermine dès le chargement le tour du joueur pour la picture box picJoueurActuel et le label lblTourJoueur
            //
            Panel_Transparence(pnlC1);
            Panel_Transparence(pnlC2);
            Panel_Transparence(pnlC3);
            Panel_Transparence(pnlC4);
            Panel_Transparence(pnlC5);
            Panel_Transparence(pnlC6);
            Panel_Transparence(pnlC7);
            //Transparence des panels pour le bon fonctionnement des designs dans le Form
            if (frmPrmPerso.Jeu.GetJoueurActif() == 2 && frmPrmPerso.Joueur2IA.GetPseudoJoueur() == "IA") //Si l'IA commence elle joue son coup dès le chargement du Form
            {
                appelleIA();
            }
            playLooping();//Joue la musique de fond en boucle
        }
        private void rejouer(bool win, string pseudo)//Fonction qui permet lorsque la partie est déterminée comme finie de rejouer en affichant un message selon qui a gagné ou si personne n'a gagné
        {
            try
            {
                if (win)//Si victoire
                {
                    DialogResult rejouer = MessageBox.Show($"Victoire du joueur {pseudo}\n\nSouhaitez-vous rejouer?", "Victoire !", MessageBoxButtons.YesNo);
                    if (rejouer == DialogResult.Yes)//Rejouer
                    {
                        this.Close(); //Ferme le formulaire pour revenir au paramètrage
                    }
                    else//Quitter
                    {
                        Environment.Exit(0);
                    }
                }
                else//Si égalité
                {
                    DialogResult rejouer = MessageBox.Show($"Égalité des deux joueurs!\n\nSouhaitez-vous rejouer?", "Égalité !", MessageBoxButtons.YesNo);
                    if (rejouer == DialogResult.Yes)//Rejouer
                        this.Close(); //Ferme le formulaire pour revenir au paramètrage
                    else//Quitter
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)//Exception si la fonction à une erreur quelconque lors de l'appel
            {
                MessageBox.Show(ex.Message, "Erreur lors de la tentative pour rejouer");
            }
        }
        private void Panel_Transparence(Panel p) //Fonction pour rendre les panels transparents
        {
            var posi = this.PointToScreen(p.Location);
            posi = picPlateau.PointToClient(posi);
            p.Parent = picPlateau;
            p.Location = posi;
            p.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void playLooping()//Fonction pour jouer la musique de fond en boucle
        {
            try
            {
                Musique.PlayLooping();
            }
            catch (Exception ex)//Exception si il y a une erreur dans le lancement de la musique
            {
                MessageBox.Show(ex.Message, "Erreur lors de la lecture de la musique de fond");
            }
        }

        private void ChoixPicCouleurPion(PictureBox pic)//Fonction qui attribue une image correspondant a un pion de couleur à une PictureBox donnée selon le numéro du joueur actif (Joueur1 == 1 / Joueur2IA == 2)
        {
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    pic.Image = Properties.Resources.PionRougeP6x7;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.PionJauneP6x7;
                }
                if (x == "Noir")
                {
                    pic.Image = Properties.Resources.PionNoirP6x7;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    pic.Image = Properties.Resources.PionNoirP6x7;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.PionJauneP6x7;
                }
                if (x == "Rouge")
                {
                    pic.Image = Properties.Resources.PionRougeP6x7;
                }
            }
        }

        private void pnlC_MouseEnter(object sender, EventArgs e) //Fonction qui renvoie l'indice de colonne d'un panel lorsque la souris entre à l'intérieur
        {
            Panel panel = sender as Panel;// Récupère les informations du panel dans lequel se trouve la souris lors du click

            string panelName = panel.Name;// Récupère le nom du panel dans une nouvelle variable

            string numericPart = panelName.Replace("pnlC", "");//Tous nos panels ayant un nom générique pnlCX (X étant le numéro de la colonne du panel),
                                                               //cette ligne permet de récuperer le nom du panel et d'enlever pnlC pour ne récupérer que l'indice de la colonne du panel

            columnNumber = int.Parse(numericPart) - 1; //Transforme l'indice du panel de string à int dans une nouvelle variable
                                                       //L'indice de colonne des panels commençant par 1 on retire 1 à la variable columnNumber

        }

        private void appelleIA() //Fonction qui, lorsqu'elle est appelée, Joue un coup optimisé par la classe IA qui détermine le meilleur coup possible
        {
            IA JoueurIA = new IA(5, 2); // 5 = Profondeur maximum de l'IA / 2 = numéro du joueur (forcément 2 car l'IA remplace le joueur 2)

            int i = 0;
            List<(int, int)> CoupAJouer = new List<(int, int)>();//Liste qui récupère l'indice de ligne et colonne du coup à jouer

            CoupAJouer = JoueurIA.MeilleurCoup(frmPrmPerso.Jeu); //Appel la fonction MeilleurCoup de l'IA qui renvoie le meilleur coup à jouer

            string nomPanel = string.Format("pnlC{0}", CoupAJouer[0].Item2 + 1); //Récupère le nom du panel lié à l'indice de la colonne de la liste CoupAJouer

            Panel panel = Controls.Find(nomPanel, true).FirstOrDefault() as Panel; //Relie le panel qui contient la pictureBox de la bonne colonne grâce à une fonction qui recherche le nom du panel que l'on a déterminé auparavant

            ChoixPicCouleurPion((PictureBox)panel.Controls[frmPrmPerso.Jeu.GetLignes() - (CoupAJouer[0].Item1) - 1]);//Appel de la fonction qui donne l'image du pion selon le joueur à la pictureBox
                                                                                                                     //correspondant à la ligne dans la liste CoupAJouer
            JouerUnCoup(CoupAJouer);//Joue le coup dans le plateau avec la liste qui comprend la ligne et la colonne

            if (frmPrmPerso.Jeu.EstTerminee() == 1)//Si le joueur 1 a gagné
                rejouer(true, frmPrmPerso.Joueur1.GetPseudoJoueur());
            else if (frmPrmPerso.Jeu.EstTerminee() == 2)//Si l'IA a gagné
                rejouer(true, frmPrmPerso.Joueur2IA.GetPseudoJoueur());
            else if (frmPrmPerso.Jeu.EstTerminee() == 0)//Si il y a égalité
                rejouer(false, "");
        }

        private void JouerUnCoup(List<(int, int)> CoupAJouer) //Fonction qui selon une liste de coordonnées (ligne, colonne), joue un coup dans le plateau de la partie, joue un son de pion posé, et actualise l'affichage 
        {
            frmPrmPerso.Jeu.JouerCoup(CoupAJouer, frmPrmPerso.Jeu.GetJoueurActif());
            JetonPose.Play(); //Joue le son lorsqu'un pion est posé
            JetonPose.Dispose(); //Débarasse les ressources associées au son JetonPose
            TourDuJoueur(); //Actualise l'affichage
        }

        private void TourDuJoueur()//Actualise les données d'affichage liées au label et a la pictureBox du joueur devant jouer le coup
        {
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1) //Si le prochain coup doit être jouer par le joueur 1
            {
                lblTourJoueur.Text = $"Au tour du joueur : {frmPrmPerso.Joueur1.GetPseudoJoueur()}";
                ChoixPicCouleurPion(picJoueurActuel);
            }
            else //Si le prochain coup doit être jouer par le joueur 2 ou l'IA
            {
                lblTourJoueur.Text = $"Au tour du joueur : {frmPrmPerso.Joueur2IA.GetPseudoJoueur()}";
                ChoixPicCouleurPion(picJoueurActuel);
            }
        }

        private async void pnlC_Click(object sender, EventArgs e)//Fonction qui joue un coup selon le panel cliqué (la fonction possède async car il y a une ligne qui ajoute du délai avant un prochain coup lors de l'appel de l'IA)
        {
            Panel panel = sender as Panel; // Récupère les informations du panel dans lequel se trouve la souris lors du click
            List<(int, int)> CoupAJouer = new List<(int, int)>(); // Liste permettant d'avoir la colonne et la ligne du coup qui sera joué
            int i = frmPrmPerso.Jeu.GetLignes() - 1; // Récupération du nombre de lignes du plateau - 1 pour inspecter les lignes du tableau 1 par 1 en partant de la ligne la plus basse correspondant à la ligne de dépot des pions au début du jeu
            while (i >= 0) //Tant que toutes les lignes ne sont pas vérifiées
            {
                if (frmPrmPerso.Jeu.EstPossible(i, columnNumber)) //Détermine si la valeur dans le tableau est a 0, dans ce cas le coup est jouable et la fonction renvoie true
                {
                    CoupAJouer.Add((i, columnNumber)); //On donne les indices du coup jouable a la variable CoupAJouer
                    ChoixPicCouleurPion((PictureBox)panel.Controls[frmPrmPerso.Jeu.GetLignes() - 1 - i]); //Appel la fonction ChoixPicCouleurPion avec la pictureBox la plus basse possible du tableau sans valeur (==0)
                                                                                                          //et lui donne l'image du pion du joueur actif (autrement dit le joueur ayant cliqué sur le panel)
                    JouerUnCoup(CoupAJouer); // Joue le coup dans le tableau de la partie avec la ligne et colonne entrées dans CoupAJouer précédemment
                    if (frmPrmPerso.Jeu.EstTerminee() == 1) //Si victoire du joueur 1
                    {
                        rejouer(true, frmPrmPerso.Joueur1.GetPseudoJoueur());
                        break;

                    }
                    else if (frmPrmPerso.Jeu.EstTerminee() == 2)//Si victoire du joueur 2 
                    {
                        rejouer(true, frmPrmPerso.Joueur2IA.GetPseudoJoueur());
                        break;

                    }
                    else if (frmPrmPerso.Jeu.EstTerminee() == 0)//Si égalité
                    {
                        rejouer(false, "");
                        break;
                    }
                    else
                    {
                        if (frmPrmPerso.Joueur2IA.GetPseudoJoueur() == "IA" && frmPrmPerso.Jeu.GetJoueurActif() == frmPrmPerso.Joueur2IA.GetN_Joueur()) // Si le joueur 2 est l'IA et non un humain
                        {
                            await Task.Delay(500); // Patiente 500 millisecondes pour éviter des coups trop rapides et donner un meilleur aspect au coup de l'IA
                            appelleIA(); //Appel l'IA
                        }
                        break; //Arrête le while car la condition est remplie et il ne faut jouer qu'un coup sur la ligne cliquée

                    }


                }
                i--; // Désincrémente i de 1 jusqu'a ce qu'il soit égal à 0

            }

        }
        private void FormPartie6x7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Musique.Stop(); //Arrêt de la musique lors de la fermeture du Form
        }

        private void btnAbandon_Click(object sender, EventArgs e) //Retour au FormParametrage si le bouton d'abandon de partie est cliqué
        {
            this.Close();
        }
    }
}
