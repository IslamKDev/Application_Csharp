using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain.Services
{
    public class servicePraticien
    {
        private static servicePraticien instance;
        private static AppGsbEntities unService;
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static servicePraticien getInstance()
        {
            if (servicePraticien.instance == null)
            {
                servicePraticien.instance = new servicePraticien();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return servicePraticien.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private servicePraticien()
        {

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lister les médicaments
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public List<praticien> ListedesPraticiens()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var lesPraticiens = (from e in unService.praticien
                                     select e);
                return lesPraticiens.ToList<praticien>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
    }
}
