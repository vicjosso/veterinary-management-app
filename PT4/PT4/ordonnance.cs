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
    
    public partial class ordonnance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ordonnance()
        {
            this.produit = new HashSet<produit>();
        }
    
        public int idOrdonnance { get; set; }
        public int idAnimal { get; set; }
        public int idRdv_ { get; set; }
    
        public virtual animal animal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produit> produit { get; set; }
        public virtual rendez_vous rendez_vous { get; set; }
    }
}