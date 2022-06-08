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
    
    public partial class medicament
    {
        public medicament()
        {
            this.constituer = new HashSet<constituer>();
            this.formuler = new HashSet<formuler>();
            this.offrir = new HashSet<offrir>();
            this.prescrire = new HashSet<prescrire>();
            this.stats_prescriptions = new HashSet<stats_prescriptions>();
            this.medicament1 = new HashSet<medicament>();
            this.medicament2 = new HashSet<medicament>();
        }
    
        public int id_medicament { get; set; }
        public Nullable<int> id_famille { get; set; }
        public string depot_legal { get; set; }
        public string nom_commercial { get; set; }
        public string effets { get; set; }
        public string contre_indication { get; set; }
        public Nullable<decimal> prix_echantillon { get; set; }
    
        public virtual ICollection<constituer> constituer { get; set; }
        public virtual famille famille { get; set; }
        public virtual ICollection<formuler> formuler { get; set; }
        public virtual ICollection<offrir> offrir { get; set; }
        public virtual ICollection<prescrire> prescrire { get; set; }
        public virtual ICollection<stats_prescriptions> stats_prescriptions { get; set; }
        public virtual ICollection<medicament> medicament1 { get; set; }
        public virtual ICollection<medicament> medicament2 { get; set; }
    }
}