//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ligne_fraisforfait
    {
        public int id_frais { get; set; }
        public int id_fraisforfait { get; set; }
        public Nullable<int> quantite_ligne { get; set; }
    
        public virtual frais frais { get; set; }
        public virtual fraisforfait fraisforfait { get; set; }
    }
}