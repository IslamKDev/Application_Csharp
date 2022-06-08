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
    public class serviceRapport
    {

        private static serviceRapport instance;
        private static AppGsbEntities unService;
        #region Constructeur
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceRapport getInstance()
        {
            if (serviceRapport.instance == null)
            {
                serviceRapport.instance = new serviceRapport();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceRapport.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceRapport()
        {

        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<rapport_visite> ListeRapport()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des rapport.", "LectureRapport");
            try
            {
                var lesRap = (from rapport in unService.rapport_visite
                              select rapport);
                return lesRap.ToList<rapport_visite>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lister les médicaments
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public DataTable ListeDesRapports()
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des medicament.", "Lecturemedicament");
            try
            {
                dt.Columns.Add("numero du rapport", typeof(int));
                dt.Columns.Add("nom du praticien", typeof(String));
                dt.Columns.Add("prenom du praticien", typeof(String));
                dt.Columns.Add("nom du visiteur", typeof(String));
                dt.Columns.Add("prenom duvisiteur", typeof(String));
                dt.Columns.Add("date du rapport", typeof(String));
                dt.Columns.Add("bilan du rapport", typeof(String));
                dt.Columns.Add("motif du rapport", typeof(String));


                var lesRapports = from r in unService.rapport_visite
                                     join p in unService.praticien on r.id_praticien equals p.id_praticien
                                     join v in unService.visiteur on r.id_visiteur equals v.id_visiteur
                                     orderby r.date_rapport ascending
                                     select new
                                     {
                                         r.id_rapport,
                                         p.nom_praticien,
                                         p.prenom_praticien,
                                         v.nom_visiteur,
                                         v.prenom_visiteur,
                                         r.date_rapport,
                                         r.bilan,
                                         r.motif,

                                     };
                foreach (var res in lesRapports)
                {
                    dt.Rows.Add(res.id_rapport, res.nom_praticien, res.prenom_praticien, res.nom_visiteur, res.prenom_visiteur, res.date_rapport, res.bilan, res.motif);
                }
                return dt;

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
        /// <param name="idVisiteur"></param>
        /// <returns></returns>
        public List<rapport_visite> ListeDesRapportsParId(int idVisiteur)
        {
            sErreurs er = new sErreurs("Erreur sur lecture des composants.", "LectureDesComposants");
            try
            {
                var lesRapports = (from rapport_visite in unService.rapport_visite
                                     join visiteur in unService.visiteur on rapport_visite.id_visiteur equals visiteur.id_visiteur
                                     where visiteur.id_visiteur == idVisiteur
                                     select rapport_visite);
                return lesRapports.ToList<rapport_visite>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public DataTable ListeDesRapportsParDate(DateTime Date)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des dates.", "LectureDesDatezs");

            try
            {
                dt.Columns.Add("numero du rapport", typeof(int));
                dt.Columns.Add("nom du praticien", typeof(String));
                dt.Columns.Add("prenom du praticien", typeof(String));
                dt.Columns.Add("nom du visiteur", typeof(String));
                dt.Columns.Add("prenom duvisiteur", typeof(String));
                dt.Columns.Add("date du rapport", typeof(String));
                dt.Columns.Add("bilan du rapport", typeof(String));
                dt.Columns.Add("motif du rapport", typeof(String));

               

                var lesRapports = from r in unService.rapport_visite
                                  join p in unService.praticien on r.id_praticien equals p.id_praticien
                                  join v in unService.visiteur on r.id_visiteur equals v.id_visiteur
                                  where r.date_rapport == Date 
                                  select new
                                  {
                                      r.id_rapport,
                                      p.nom_praticien,
                                      p.prenom_praticien,
                                      v.nom_visiteur,
                                      v.prenom_visiteur,
                                      r.date_rapport,
                                      r.bilan,
                                      r.motif,

                                  };
                foreach (var res in lesRapports)
                {
                    dt.Rows.Add(res.id_rapport, res.nom_praticien, res.prenom_praticien, res.nom_visiteur, res.prenom_visiteur, res.date_rapport, res.bilan, res.motif);
                }
                return dt;

                
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DataTable ListeDesRapportsParPraticien (int idPraticien)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des dates.", "LectureDesDatezs");

            try
            {
                dt.Columns.Add("numero du rapport", typeof(int));
                dt.Columns.Add("nom du praticien", typeof(String));
                dt.Columns.Add("prenom du praticien", typeof(String));
                dt.Columns.Add("nom du visiteur", typeof(String));
                dt.Columns.Add("prenom duvisiteur", typeof(String));
                dt.Columns.Add("date du rapport", typeof(String));
                dt.Columns.Add("bilan du rapport", typeof(String));
                dt.Columns.Add("motif du rapport", typeof(String));



                var lesRapports = from r in unService.rapport_visite
                                  join p in unService.praticien on r.id_praticien equals p.id_praticien
                                  join v in unService.visiteur on r.id_visiteur equals v.id_visiteur
                                  where p.id_praticien == idPraticien
                                  select new
                                  {
                                      r.id_rapport,
                                      p.nom_praticien,
                                      p.prenom_praticien,
                                      v.nom_visiteur,
                                      v.prenom_visiteur,
                                      r.date_rapport,
                                      r.bilan,
                                      r.motif,

                                  };
                foreach (var res in lesRapports)
                {
                    dt.Rows.Add(res.id_rapport, res.nom_praticien, res.prenom_praticien, res.nom_visiteur, res.prenom_visiteur, res.date_rapport, res.bilan, res.motif);
                }
                return dt;


            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<rapport_visite> ListeDate()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des dates.", "LectureDesDates");
            try
            {
                var lesDates = (from rapport_visite in unService.rapport_visite
                                select rapport_visite).Distinct();
                return lesDates.Distinct<rapport_visite>().ToList<rapport_visite>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ajout d'un rapport de visite
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public void AjouteRapportVisite(rapport_visite r)
        {
            sErreurs er = new sErreurs("Erreur  sur l'ajout d'un rapport de visite.", "ajouteRapportVisite");
            try
            {
                unService.rapport_visite.Add(r);
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












































