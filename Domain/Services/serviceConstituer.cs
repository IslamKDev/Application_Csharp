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
    public class serviceConstituer
    {
        private static serviceConstituer instance;
        private static AppGsbEntities unService;
        #region constructeur de la classe serviceConstituer
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceConstituer getInstance()
        {
            if (serviceConstituer.instance == null)
            {
                serviceConstituer.instance = new serviceConstituer();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceConstituer.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceConstituer()
        {

        }
        #endregion
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<constituer> ListeConstituer()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "LectureComposant");
            try
            {
                var lesComposants = (from constit in unService.constituer
                              select constit);
                return lesComposants.ToList<constituer>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public constituer ConstituerParId(int idMedicament, int idComposant)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "LectureComposant");
            try
            {
                var lesComposants = (from constit in unService.constituer
                                     where constit.id_medicament == idMedicament
                                     where constit.id_composant ==  idComposant
                                    select constit).First();
                return lesComposants;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        #region Ajout
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// AjouterConstituer
        /// </summary>
        /// <param name="r"></param>
        public void AjouterConstituer(constituer r)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un consitier.", "ajouteConstituer");
            try
            {
                unService.constituer.Add(r);
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
        #endregion
        #region suppression
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public void SupprimerConstituer(constituer r)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un consitier.", "ajouteConstituer");
            try
            {
                unService.constituer.Remove(r);
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
        #endregion
        #region Mise a jour du modele
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
        #endregion
    }
}
