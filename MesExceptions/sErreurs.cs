using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesExceptions
{
    public class sErreurs
    {
        private String messageUtilisateur;
        private String messageApplication;

        public sErreurs(String mu, String ma)
        {
            this.messageUtilisateur = mu;
            this.messageApplication = ma;
        }
        public String MessageUtilisateur()
        {
            return (messageUtilisateur);
        }
        public String MessageApplication()
        {
            return (messageApplication);
        }
    }
}
