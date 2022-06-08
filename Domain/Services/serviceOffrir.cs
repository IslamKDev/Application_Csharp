using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain.Services
{
    public class serviceOffrir
    {
        private static serviceOffrir instance;
        private static AppGsbEntities unService;
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceOffrir getInstance()
        {
            if (serviceOffrir.instance == null)
            {
                serviceOffrir.instance = new serviceOffrir();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceOffrir.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceOffrir()
        {

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<offrir> ListedesOffrir()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var lesOff = (from offrir in unService.offrir
                              select offrir);
                return lesOff.ToList<offrir>();
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
        /// <param name="idMedicament"></param>
        /// <param name="idRapport"></param>
        /// <param name="idVisiteur"></param>
        /// <returns></returns>
        public offrir unOffrirParId(int idVisiteur, int idRapport, int idMedicament )
        {
            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "LectureComposant");

            try
            {
                var lesOffrirs = (from offrir in unService.offrir
                                    
                                     where offrir.id_medicament == idMedicament
                                     where offrir.id_rapport == idRapport
                                     where offrir.id_visiteur == idVisiteur
                                     select offrir).First();
                return lesOffrirs;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }


        public List<medicament> ListeDesOffrirParId(int idVisiteur, int idRapport)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "LectureComposant");

            try
            {
                var lesOffrirs = (from medicament in unService.medicament
                                  join offrir in unService.offrir on medicament.id_medicament equals offrir.id_medicament
                                  where offrir.id_rapport == idRapport
                                  where offrir.id_visiteur == idVisiteur
                                  select medicament);

                return lesOffrirs.ToList<medicament>();
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
        public void SupprimerMedicamentOffrir(offrir uneOffre)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un consitier.", "ajouteConstituer");
            try
            {
                unService.offrir.Remove(uneOffre);
            }
            catch (DbUpdateException ex)
            {
                DbEntityEntry entry = ex.Entries.First<DbEntityEntry>();
                switch (entry.State)
                {
                    case System.Data.EntityState.Added:
                        entry.State = System.Data.EntityState.Detached;
                        break;
                    case System.Data.EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = System.Data.EntityState.Unchanged;
                        break;
                    case System.Data.EntityState.Deleted:
                        entry.State = System.Data.EntityState.Unchanged;
                        break;
                }
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// mise à jour de la base de donnée
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
