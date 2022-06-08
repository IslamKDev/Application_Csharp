using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;
using Utilitaires;

namespace Domain.Services
{
    public class serviceComposant
    {
        private static serviceComposant instance;
        private static AppGsbEntities unService;
        #region Constructeur
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceComposant getInstance()
        {
            if (serviceComposant.instance == null)
            {
                serviceComposant.instance = new serviceComposant();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceComposant.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceComposant()
        {

        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lister les médicaments
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public DataTable ListeDesCompo()
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des medicament.", "Lecturemedicament");
            try
            {
                dt.Columns.Add("Dépot légal du medicament", typeof(String));
                dt.Columns.Add("Nom commercial du medicament", typeof(String));
                dt.Columns.Add("Effets du medicament", typeof(String));
                dt.Columns.Add("Contre indication du medicament", typeof(String));
                dt.Columns.Add("Nom du composant", typeof(String));
                dt.Columns.Add("Quantite du composant", typeof(Decimal));
                dt.Columns.Add("Prix echantillon du medicament", typeof(Decimal));

                var lesComposants = from medica in unService.medicament
                                     join consti in unService.constituer on medica.id_medicament equals consti.id_medicament
                                     join compo in unService.composant on consti.id_composant equals compo.id_composant

                                     select new
                                     {
                                         medica.depot_legal,
                                         medica.nom_commercial,
                                         medica.effets,
                                         medica.contre_indication,
                                         compo.lib_composant,
                                         consti.qte_composant,
                                         medica.prix_echantillon,

                                     };
                foreach (var res in lesComposants)
                {
                    dt.Rows.Add(res.depot_legal, res.nom_commercial, res.effets, res.contre_indication, res.lib_composant, res.qte_composant, res.prix_echantillon);
                }
                return dt;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<composant> ListeDesComposants(decimal idMedicament)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var lesComposants = from c in unService.composant
                                        /*where !(
                                                from comp in unService.composant
                                                join cons in unService.constituer on comp.id_composant equals cons.id_composant
                                                join medi in unService.medicament on cons.id_medicament equals medi.id_medicament
                                                select c.id_composant)
                                                .Contains(idMedicament)

                                        select c;*/
                                        /*where !(
                                                from cons in unService.constituer
                                                join medi in unService.medicament on cons.id_medicament equals medi.id_medicament
                                                where cons.id_medicament == idMedicament
                                                select c.id_composant)
                                                .Contains(idMedicament)
                                                */
                                    select c;
                return lesComposants.ToList<composant>();

                //var lesComposants = (from c in unService.composant
                //                   select c);
                //return lesComposants.ToList<composant>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #region Table des composants par médicament
        /// <summary>
        /// Table de donnée des composants par médicament
        /// </summary>
        /// <param name="IdMedicament"></param>
        /// <returns></returns>
        public DataTable ListeDesComposantsParMedicaments(int IdMedicament)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des dates.", "LectureDesDatezs");

            try
            {
                dt.Columns.Add("Depot legal", typeof(String));
                dt.Columns.Add("Nom commercial", typeof(String));
                dt.Columns.Add("Effets", typeof(String));
                dt.Columns.Add("Contre indication", typeof(String));
                dt.Columns.Add("Prix echantillon", typeof(String));
                dt.Columns.Add("libelle composant", typeof(String));
                dt.Columns.Add("Quantité composant", typeof(String));

                var lesComposants = from compos in unService.composant
                                  join consti in unService.constituer on compos.id_composant equals consti.id_composant             
                                  join medica in unService.medicament on consti.id_medicament equals medica.id_medicament
                                  where medica.id_medicament == IdMedicament
                                  select new
                                  {
                                      medica.depot_legal,
                                      medica.nom_commercial,
                                      medica.effets,
                                      medica.contre_indication,
                                      medica.prix_echantillon,
                                      compos.lib_composant,
                                      consti.qte_composant,

                                  };
                foreach (var res in lesComposants)
                {
                    dt.Rows.Add(res.depot_legal, res.nom_commercial, res.effets, res.contre_indication, res.prix_echantillon, res.lib_composant, res.qte_composant);
                }
                return dt;


            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<composant> ListeComposants()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var lesMed = (from composant in unService.composant
                              select composant);
                return lesMed.ToList<composant>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        #region Liste pour la combobox suppresion composant avec id medicament
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idMedicament"></param>
        /// <returns></returns>

        public List<composant> ListeComposantsParId(int idMedicament)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "LectureDesComposants");
            try
            {
                var lesComposants = (from compos in unService.composant
                                     join consti in unService.constituer on compos.id_composant equals consti.id_composant
                                     join medica in unService.medicament on consti.id_medicament equals medica.id_medicament
                                     where medica.id_medicament == idMedicament
                                     select compos);
                return lesComposants.ToList<composant>();
            }
            catch(Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        #endregion
        #region Ajout
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ajouter un composant
        /// </summary>
        /// <param name="r"></param>
        public void AjouterComposant(composant r)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un frais.", "ajouteFrais");
            try
            {
                unService.composant.Add(r);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
#endregion
        #region suppression
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Suppresion d'un composant par medicament
        /// </summary>
        /// <param name="r"></param>
        public void SupprimerComposant(composant r)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un frais.", "ajouteFrais");
            try
            {
                unService.composant.Remove(r);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
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
