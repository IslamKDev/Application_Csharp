using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using MesExceptions;
using Utilitaires;

/*
 * App_name: AppGsb
 * Author : Islam
 * Date : 2022-05-07
 * Mise a jour : V2
 * Date MAJ : 2022-05-30
 * Windows Forms : Menu
 */

namespace AppGsb
{
    public partial class Fprincipal : Form
    {
        private visiteur unVisiteur = null;
        #region Importation des Dynamic Link Library
        //-----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidhtEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidhtEllipse,
           int nHeightEllipse
         );

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        #region Fenetre principal
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public Fprincipal()
        {
            InitializeComponent();
            applicationDesigne();
            Init_Etat();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            // Panel de navigation
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btAccueil.Height;
            pnlNav.Top = btAccueil.Top;
            pnlNav.Left = btAccueil.Left;
            btAccueil.BackColor = Color.FromArgb(46, 51, 73);
            // Appel du panel de chargement
            this.pnlChargement.Controls.Clear();
            Presentations.Accueil.Faccueil FAccueil = new Presentations.Accueil.Faccueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FAccueil.FormBorderStyle = FormBorderStyle.None;
            this.pnlChargement.Controls.Add(FAccueil);
            FAccueil.Show();
        }
        //-------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fprincipal_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //---------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fprincipal_Load(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applicationDesigne()
        {
            pnlListeSousMenu.Visible = false;
            pnlAjouterSousMenu.Visible = false;
            pnlModifierSousMenu.Visible = false;
            pnlRechercheSousMenu.Visible = false;
            pnlSupprimerSousMenu.Visible = false;
            pnlParametreSousMenu.Visible = false;
        }
        //----------------------------------------------------------------
        /// <summary>
        /// Initsialisation de l'etat 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Init_Etat()
        {
            
            btAccueil.Enabled = true;
            btListe.Enabled = false;
            btAjouter.Enabled = false;
            btModifier.Enabled = false;
            btRecherche.Enabled = false;
            btSupprimer.Enabled = false;
            btParametre.Enabled = true;
            btDeconnexion.Enabled = false;

        }
        #endregion
        #region Menu et sous menu
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cacherSousMenu()
        {
            //
            if (pnlListeSousMenu.Visible == true)
            {
                pnlListeSousMenu.Visible = false;
            }
            //
            if (pnlAjouterSousMenu.Visible == true)
            {
                pnlAjouterSousMenu.Visible = false;
            }
            //
            if (pnlModifierSousMenu.Visible == true)
            {
                pnlModifierSousMenu.Visible = false;
            }
            //
            if (pnlRechercheSousMenu.Visible == true)
            {
                pnlRechercheSousMenu.Visible = false;
            }
            //
            if(pnlSupprimerSousMenu.Visible == true)
            {
                pnlSupprimerSousMenu.Visible = false;
            }
            //
            if (pnlParametreSousMenu.Visible == true)
            {
                pnlParametreSousMenu.Visible = false;
            }
        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void montreSousMenu(Panel sousMenu)
        {
            //
            if (sousMenu.Visible == false)
            {
                cacherSousMenu();
                sousMenu.Visible = true;
            }
            else
            {
                sousMenu.Visible = false;
            }
        }
        #endregion
        #region Accueil
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAccueil_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Accueil";
            pnlNav.Height = btAccueil.Height;
            pnlNav.Top = btAccueil.Top;
            pnlNav.Left = btAccueil.Left;
            btAccueil.BackColor = Color.FromArgb(46, 51, 73);
            // Appel du panel de chargement
            this.pnlChargement.Controls.Clear();
            Presentations.Accueil.Faccueil FAccueil = new Presentations.Accueil.Faccueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FAccueil.FormBorderStyle = FormBorderStyle.None;
            this.pnlChargement.Controls.Add(FAccueil);
            FAccueil.Show();
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        #endregion
        #region Lister
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btListe_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btListe.Height;
            pnlNav.Top = btListe.Top;
            btListe.BackColor = Color.FromArgb(46, 51, 73);
            montreSousMenu(pnlListeSousMenu);
        }
        //---------------------------------------------------------------------
        /// <summary>
        ///  Liste des Medicaments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btListeMedicament_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Lister";

            try
            {


                /*
                // Appel du panel de chargement
                this.pnlChargement.Controls.Clear();
                Presentation. FLister = new Presentation.() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                FLister.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(FLister);
                FLister.Show();
                //---------------------------------------------------------------
              */

                this.pnlChargement.Controls.Clear();
                DataTable mesMedicaments = Domain.Services.serviceMedicament.getInstance().ListeDesMedicament();
                Presentations.Liste.FlisterMedicament f = new Presentations.Liste.FlisterMedicament(mesMedicaments) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(f);
                f.Show();
                /*
                f.ShowDialog(); 
                */
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Lecture des medicaments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste des Composants du medicament
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btListeComposant_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Lister";
            try
            {


                /*
                // Appel du panel de chargement
                this.pnlChargement.Controls.Clear();
                Presentation. FLister = new Presentation.() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                FLister.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(FLister);
                FLister.Show();
                //---------------------------------------------------------------
              */

                this.pnlChargement.Controls.Clear();
                DataTable mesComposants = Domain.Services.serviceComposant.getInstance().ListeDesCompo();
                Presentations.Liste.FlisterComposant f = new Presentations.Liste.FlisterComposant(mesComposants) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(f);
                f.Show();
                /*
                f.ShowDialog(); 
                */
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Lecture des composants", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste des Rapports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btListerRapports_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Lister";

            try
            {


                /*
                // Appel du panel de chargement
                this.pnlChargement.Controls.Clear();
                Presentation. FLister = new Presentation.() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                FLister.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(FLister);
                FLister.Show();
                //---------------------------------------------------------------
              */

                this.pnlChargement.Controls.Clear();
                DataTable mesRapports = Domain.Services.serviceRapport.getInstance().ListeDesRapports();
                Presentations.Liste.FlisterRapport f = new Presentations.Liste.FlisterRapport(mesRapports) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(f);
                f.Show();
                /*
                f.ShowDialog(); 
                */
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Lecture des medicaments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        #endregion
        #region Recherche
        //------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bouton recherche un click permet d'afficher les boutons du sous menu recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRecherche_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btRecherche.Height; // Panel de navigation 
            pnlNav.Top = btRecherche.Top; // Panel de navigation
            btRecherche.BackColor = Color.FromArgb(46, 51, 73); 

            montreSousMenu(pnlRechercheSousMenu); // Appel de la méthode montreSousMenu qui a en parametre le panel de Recherche sous menu
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------
        private void btRechercheRapport_Click(object sender, EventArgs e)
        {
            try
            {
                lbTitre.Text = "Recherche";

                Presentations.Recherche.Rapport.FrechercheRapportSelection FRechercheRapportSelection = new Presentations.Recherche.Rapport.FrechercheRapportSelection();
                DialogResult retour = FRechercheRapportSelection.ShowDialog();
                if (retour == DialogResult.OK)
                {
                
                }
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();


        }
            
        //---------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRechercheComposants_Click(object sender, EventArgs e)
        {
            List<medicament> lesMedicaments = Domain.Services.serviceMedicament.getInstance().Listedemedicament();

            Presentations.Recherche.Composant.FrechercheComposantSelectionMedicament FRechercheComposantSelectionMedicament = new Presentations.Recherche.Composant.FrechercheComposantSelectionMedicament(lesMedicaments);
           
            this.Hide();
            DialogResult retour = FRechercheComposantSelectionMedicament.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRechercheMedicaments_Click(object sender, EventArgs e)
        {
            List<famille> lesFamilles = Domain.Services.serviceFamille.getInstance().Listedesfamilles();

            Presentations.Recherche.Medicament.FrechercheMedicamentSelectionFamille FRechercheMedicamentSelectionFamille = new Presentations.Recherche.Medicament.FrechercheMedicamentSelectionFamille(lesFamilles);
            this.Hide();
            DialogResult retour = FRechercheMedicamentSelectionFamille.ShowDialog();
            this.Close();
            if (retour == DialogResult.OK)
            {

            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------
        #endregion
        #region Ajouter
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjouter_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btAjouter.Height;
            pnlNav.Top = btAjouter.Top;
            btAjouter.BackColor = Color.FromArgb(46, 51, 73);
            montreSousMenu(pnlAjouterSousMenu);
        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjouterComposant_Click(object sender, EventArgs e)
        {
            try
            {
                lbTitre.Text = "Ajouter";
                constituer unConst = new constituer();
                List<medicament> mesMedicaments = Domain.Services.serviceMedicament.getInstance().Listedemedicament();
                List<composant> mesComposants = Domain.Services.serviceComposant.getInstance().ListeComposants();
                /*
                // Appel du panel de chargement
                this.pnlChargement.Controls.Clear();
                Presentation.Ajouter.FajouterComposant FAjouterComposant = new Presentation.Ajouter.FajouterComposant(mesMedicaments,mesComposants, unConst) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FAjouterComposant.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(FAjouterComposant);
                FAjouterComposant.Show();
                */

                Presentations.Ajouter.FajouterComposant FAjouterComposant = new Presentations.Ajouter.FajouterComposant(mesMedicaments, mesComposants, unConst);
                Console.WriteLine(unConst);
                DialogResult retour = FAjouterComposant.ShowDialog();
                if (retour == DialogResult.OK)
                {
                    /* unConst.qte_composant.Add(unConst);*/
                    /* serviceComposant.getInstance().AjouterComposant(unConst);*/
                    /*unConst.qte_composant.Add(unConst);*/
                    /* serviceComposant.getInstance().AjouterComposant(unConst);*/
                    Domain.Services.serviceConstituer.getInstance().AjouterConstituer(unConst);
                    Domain.Services.serviceConstituer.getInstance().MiseAjourDuModele();
                    Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
                    MessageBox.Show("Votre Composant a bien était ajouter", "Ajouter un Composant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                 
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjouterRapport_Click(object sender, EventArgs e)
        {
            try
            {
                lbTitre.Text = "Ajouter";
                rapport_visite unRapport = new rapport_visite();
                List<praticien> lesPraticiens = Domain.Services.servicePraticien.getInstance().ListedesPraticiens();
                List<visiteur> lesVisiteurs = Domain.Services.serviceAdministrateur.getInstance().GetListeVisiteur();
                // Appel du panel de chargement
                this.pnlChargement.Controls.Clear();
                Presentations.Ajouter.FajouterRapport FAjouterRapport = new Presentations.Ajouter.FajouterRapport(lesPraticiens, lesVisiteurs, unRapport)
                { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; 
                FAjouterRapport.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(FAjouterRapport);

                Presentations.Ajouter.FajouterRapport F = new Presentations.Ajouter.FajouterRapport (lesPraticiens, lesVisiteurs, unRapport);
                
                DialogResult retour = F.ShowDialog();
                if (retour == DialogResult.OK)
                {

                    unRapport.id_visiteur = unVisiteur.id_visiteur;

                    unVisiteur.rapport_visite.Add(unRapport);
                    //ServiceRapport.getInstance().Add<rapport_visite>(unRapport);
                    Domain.Services.serviceRapport.getInstance().AjouteRapportVisite(unRapport);
                    Domain.Services.serviceRapport.getInstance().MiseAjourDuModele();
                    Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
                    MessageBox.Show("Le rapport a était ajouter", "Ajout d'un rapport", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                }
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        #endregion
        #region Modifier
        //------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btModifier.Height;
            pnlNav.Top = btModifier.Top;
            btModifier.BackColor = Color.FromArgb(46, 51, 73);
            montreSousMenu(pnlModifierSousMenu);

        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifierComposant_Click(object sender, EventArgs e)
        {
            try
            {
                lbTitre.Text = "Modifier composant";
                List<medicament> mesMedicaments = Domain.Services.serviceMedicament.getInstance().Listedemedicament();
                
                /*
                // Appel du panel de chargement
                this.pnlChargement.Controls.Clear();
                Presentation.Modifier.FmodifierComposant FModifierComposant = new Presentation.Modifier.FmodifierComposant() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FModifierComposant.FormBorderStyle = FormBorderStyle.None;
                this.pnlChargement.Controls.Add(FModifierComposant);
                FModifierComposant.Show();
                */

                Presentations.Modifier.Composant.FmodifierSelectionMedicament FModifierSelectionComposant = new Presentations.Modifier.Composant.FmodifierSelectionMedicament(mesMedicaments);
                DialogResult retour = FModifierSelectionComposant.ShowDialog();
                if (retour == DialogResult.OK)
                {

                }
            }
            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Appel de la classe cacherSousMenu
            cacherSousMenu();
        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifierMedicamentOffert_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Modifier medicament";

            List<visiteur> mesVisiteurs = Domain.Services.serviceAdministrateur.getInstance().ListeDesVisiteurs();
            Presentations.Modifier.MedicamentOffert.FmodifierSelectionVisiteur FModifierSelectionVisiteur = new Presentations.Modifier.MedicamentOffert.FmodifierSelectionVisiteur(mesVisiteurs);
            DialogResult retour = FModifierSelectionVisiteur.ShowDialog();
            if (retour == DialogResult.OK)
            {

            }
        }
        #endregion
        #region Supprimer
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btSupprimer.Height;
            pnlNav.Top = btSupprimer.Top;
            btSupprimer.BackColor = Color.FromArgb(46, 51, 73);

            montreSousMenu(pnlSupprimerSousMenu);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimerComposant_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Supprimer";

            List<medicament> mesMedicaments = Domain.Services.serviceMedicament.getInstance().Listedemedicament();
            Presentations.Supprimer.FsupprimerSelectionComposant FSupprimerComposant = new Presentations.Supprimer.FsupprimerSelectionComposant(mesMedicaments);
            DialogResult retour = FSupprimerComposant.ShowDialog();
            if (retour == DialogResult.OK)
            {

            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimerMedicament_Click(object sender, EventArgs e)
        {
            lbTitre.Text = "Supprimer";

            List<visiteur> mesVisiteurs = Domain.Services.serviceAdministrateur.getInstance().ListeDesVisiteurs();
            Presentations.Supprimer.FsupprimerSelectionVisiteur FSupprimerVisiteur = new Presentations.Supprimer.FsupprimerSelectionVisiteur(mesVisiteurs);
            DialogResult retour = FSupprimerVisiteur.ShowDialog();
            if (retour == DialogResult.OK)
            {

            }

        }
        #endregion
        #region Parametre
        //----------------------------------------------------------------
        /// <summary>
        /// Acces au sous menu parametre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btParametre_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btParametre.Height;
            pnlNav.Top = btParametre.Top;
            btParametre.BackColor = Color.FromArgb(46, 51, 73);
            montreSousMenu(pnlParametreSousMenu);

        }
        //----------------------------------------------------------------
        /// <summary>
        /// Mise a jour du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMiseAJour_Click(object sender, EventArgs e)
        {
            
            List<visiteur> mesVisiteurs;
            try
            {

                mesVisiteurs = Domain.Services.serviceAdministrateur.getInstance().GetListeVisiteur();
                Byte[] selByte;
                Byte[] mdpByte;
                String sel;
                String mdp;
                foreach (visiteur unV in mesVisiteurs)
                {
                    selByte = motDePasseHash.GenerateSalt();
                    mdpByte = motDePasseHash.PasswordHashe("secret", selByte);
                    sel = motDePasseHash.BytesToString(selByte);
                    mdp = motDePasseHash.BytesToString(mdpByte);
                    unV.sel_visiteur = sel;
                    unV.pwd_visiteur = mdp;
                }

                Domain.Services.serviceAdministrateur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Mise à jour", "Mise à jour effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            btMiseAJour.BackColor = Color.FromArgb(19, 21, 29);
        }
        //----------------------------------------------------------------
        /// <summary>
        /// Connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnexion_Click(object sender, EventArgs e)
        {
            String[] Credential = new String[] { " ", " " };
            String login;
            String mdp;
            btConnexion.BackColor = Color.FromArgb(19, 21, 29);
            // Appel du panel de chargement
            lbTitre.Text = "Connexion";
            this.pnlChargement.Controls.Clear();    
            Presentations.Connexion.Fconnexion FConnexion = new Presentations.Connexion.Fconnexion(Credential) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FConnexion.FormBorderStyle = FormBorderStyle.None;
            this.pnlChargement.Controls.Add(FConnexion);

            Presentations.Connexion.Fconnexion FC = new Presentations.Connexion.Fconnexion(Credential);
            DialogResult res = FC.ShowDialog();
            if (res == DialogResult.OK)
            {
                //
                login = Credential[0];
                mdp = Credential[1];
                unVisiteur = Domain.Services.serviceConnexion.getInstance().RechercheUnVisiteur(login);
                // on controle le mot de passe
                try
                {
                    if (unVisiteur != null)
                    {
                        try
                        {
                            String sel = unVisiteur.sel_visiteur;
                            // on récupère le sel 
                            Byte[] salt = motDePasseHash.transformeEnBytes(sel);
                            // on génère le mot de passe 
                            Byte[] tempo = motDePasseHash.transformeEnBytes(unVisiteur.pwd_visiteur);
                            if (motDePasseHash.VerifyPassword(salt, mdp, tempo) == true)
                            {
                                lbLogin.Text = login;
                                lb_etat.Text = "Etat connecté";
                                lb_etat.ForeColor = Color.GreenYellow;

                                btAccueil.Enabled = true;
                                btListe.Enabled = true;
                                btAjouter.Enabled = true;
                                btModifier.Enabled = true;
                                btRecherche.Enabled = true;
                                btSupprimer.Enabled = true;
                                btParametre.Enabled = true;
                                btConnexion.Enabled = false;
                                btDeconnexion.Enabled = true;
                                //-------------------------------------------------------------------------------------------------------------------------------------------
                                lbTitre.Text = "Accueil";
                                MessageBox.Show("Vous etait connecter", "Connexion reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Presentations.Accueil.Faccueil FAccueil = new Presentations.Accueil.Faccueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                                FAccueil.FormBorderStyle = FormBorderStyle.None;
                                this.pnlChargement.Controls.Add(FAccueil);
                                FAccueil.Show();
                            }
                            else
                                MessageBox.Show("Erreur", "Erreur lors du contrôle  du mot de passe pour : " + Credential[0], MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Erreur", "Erreur lors du contrôle : " + err.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur", "Erreur  login erroné : " + Credential[0], MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (MonException er)
                {
                    MessageBox.Show("Erreur", "Erreur lors de l'authentification : " + er.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            }
            cacherSousMenu();
        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            
            unVisiteur = null;
            Init_Etat();

            lb_etat.Text = "Non connecté";
            lb_etat.ForeColor = Color.Red;

            btDeconnexion.BackColor = Color.FromArgb(19, 21, 29);
            cacherSousMenu();
        }
        //----------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
            cacherSousMenu();
        }
        //------------------------------------------------------------------
        #endregion
        #region Bouton Fenetre
        //-----------------------------------------------------------
        /// <summary>
        /// Bouton pour agrandir la taille de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMaximum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //------------------------------------------------------------
        /// <summary>
        /// Bouton minimiser la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //-------------------------------------------------------------
        /// <summary>
        /// Bouton pour Quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------------------------------
        #endregion
    }
}
