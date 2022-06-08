using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain.Services
{
    public class serviceConnexion
    {
        private static serviceConnexion instance;
        private static AppGsbEntities unService;
        private visiteur unVisiteur;

        public visiteur UnVisiteur { get => unVisiteur; set => unVisiteur = value; }

        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceConnexion getInstance()
        {
            if (serviceConnexion.instance == null)
            {
                serviceConnexion.instance = new serviceConnexion();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceConnexion.instance;
        }
        // Le constructeur devient privé
        private serviceConnexion()
        {

        }

        public visiteur RechercheUnVisiteur(String login)
        {
            sErreurs er = new sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
            visiteur unVisiteur;
            try
            {
                unVisiteur = (from v in unService.visiteur
                              where v.login_visiteur == login && v.type_visiteur == "A"
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch (Exception e)
            {

                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
