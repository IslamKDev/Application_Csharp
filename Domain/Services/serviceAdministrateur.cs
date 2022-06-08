using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain.Services
{
    public class serviceAdministrateur
    {
        private static serviceAdministrateur instance;
        private static AppGsbEntities unService;
        #region Constructeur
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Constructeur
        /// </summary>
        public static serviceAdministrateur getInstance()
        {
            if (serviceAdministrateur.instance == null)
            {
                serviceAdministrateur.instance = new serviceAdministrateur();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceAdministrateur.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceAdministrateur()
        {

        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public List<visiteur> GetListeVisiteur()
        {

            sErreurs er = new sErreurs("Erreur liste des visiteurs.", "GetListeVisiteur()");

            try
            {

                var mesVisiteurs = (from v in unService.visiteur
                                    select v);


                return mesVisiteurs.ToList<visiteur>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// contrôle du login d'un visiteur
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public visiteur RechercheUnAdministrateur(Int32 numV)
        {

            sErreurs er = new sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
            visiteur unVisiteur;
            try
            {

                unVisiteur = (from v in unService.visiteur
                              where v.id_visiteur == numV
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// On recherche les états
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public List<famille> ListeDesFamilles()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var mesEtats = (from e in unService.famille
                                select e);
                return mesEtats.ToList<famille>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<visiteur> ListeDesVisiteurs()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var lesVisiteur = (from visiteur in unService.visiteur
                              select visiteur);
                return lesVisiteur.ToList<visiteur>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ajout d'un frais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AjoutComposant(composant c)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un composant.", "ajoutComposant");
            try
            {
                unService.composant.Add(c);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// mise à jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MiseAjourDuModele()
        {
            sErreurs er = new sErreurs("Erreur  sur la mise à jour du modèle", "MiseAjourDuModele()");

            try
            {
                unService.SaveChanges();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
    }
}
