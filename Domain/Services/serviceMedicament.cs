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
    public class serviceMedicament
    {
        private static serviceMedicament instance;
        private static AppGsbEntities unService;
        #region Constructeur
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceMedicament getInstance()
        {
            if (serviceMedicament.instance == null)
            {
                serviceMedicament.instance = new serviceMedicament();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceMedicament.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceMedicament()
        {

        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lister les médicaments
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>
        public DataTable ListeDesMedicament()
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des medicament.", "Lecturemedicament");
            try
            {
                dt.Columns.Add("id de la famille", typeof(int));
                dt.Columns.Add("nom de la famille ", typeof(String));
                dt.Columns.Add("id du medicament", typeof(int));
                dt.Columns.Add("Dépot légal du médicament", typeof(String));
                dt.Columns.Add("Nom commercial du médicament", typeof(String));
                dt.Columns.Add("Effets", typeof(String));
                dt.Columns.Add("Contre indication", typeof(String));
                dt.Columns.Add("Prix echantillon", typeof(Decimal));


                var lesMedicaments = from m in unService.medicament
                                     join f in unService.famille on m.id_famille equals f.id_famille
                                     orderby f.lib_famille ascending
                                     select new
                                     {
                                         f.id_famille,
                                         f.lib_famille,
                                         m.id_medicament,
                                         m.depot_legal,
                                         m.nom_commercial,
                                         m.effets,
                                         m.contre_indication,
                                         m.prix_echantillon,

                                     };
                foreach (var res in lesMedicaments)
                {
                    dt.Rows.Add(res.id_famille, res.lib_famille, res.id_medicament, res.depot_legal, res.nom_commercial, res.effets, res.contre_indication, res.prix_echantillon);
                }
                return dt;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<medicament> Listedemedicament()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des états.", "LectureEtat");
            try
            {
                var lesMed = (from medicament in unService.medicament
                              select medicament);
                return lesMed.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        #region mise a jour du modele
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
        #endregion
    }
}
