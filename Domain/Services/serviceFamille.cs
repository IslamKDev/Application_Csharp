using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using MesExceptions;
using Utilitaires;

namespace Domain.Services
{
    public class serviceFamille
    {

        private static serviceFamille instance;
        private static AppGsbEntities unService;
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static serviceFamille getInstance()
        {
            if (serviceFamille.instance == null)
            {
                serviceFamille.instance = new serviceFamille();
                // on définit un contexte commun à toutes les requêtes
                unService = new AppGsbEntities();
            }
            return serviceFamille.instance;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Le constructeur devient privé
        private serviceFamille()
        {

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<famille> Listedesfamilles()
        {
            sErreurs er = new sErreurs("Erreur sur lecture des familles.", "LectureFamille");
            try
            {
                var lesFamilles = (from famille in unService.famille
                              select famille);
                return lesFamilles.ToList<famille>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        public DataTable TableFamille(int IdFamille)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur sur lecture des dates.", "LectureDesDatezs");

            try
            {
                dt.Columns.Add("Depot Legal", typeof(String));
                dt.Columns.Add("Nom commercial", typeof(String));
                dt.Columns.Add("Effets", typeof(String));
                dt.Columns.Add("Contre indication", typeof(String));
                dt.Columns.Add("Libelle famille", typeof(String));
                dt.Columns.Add("Prix echantillon", typeof(String));
               
                var lesFamilles = from medica in unService.medicament
                                  join famil in unService.famille on medica.id_famille equals famil.id_famille   
                                  where famil.id_famille == IdFamille
                                  select new
                                  {
                                      medica.depot_legal,
                                      medica.nom_commercial,
                                      medica.effets,
                                      medica.contre_indication,
                                      famil.lib_famille,
                                      medica.prix_echantillon,

                                  };
                foreach (var res in lesFamilles)
                {
                    dt.Rows.Add(res.depot_legal, res.nom_commercial, res.effets, res.contre_indication, res.lib_famille, res.prix_echantillon);
                }
                return dt;


            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
