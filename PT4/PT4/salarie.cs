//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT4
{
    using System;
    using System.Collections.Generic;
    
    public partial class salarie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public salarie()
        {
            this.log = new HashSet<log>();
        }
    
        public int idCompte { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }
        public string mail { get; set; }
        public string adresse { get; set; }
        public string telephone { get; set; }
        public Nullable<System.DateTime> date_naissance_ { get; set; }
        public Nullable<bool> admin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log> log { get; set; }
    }
}
