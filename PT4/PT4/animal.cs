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
    
    public partial class animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public animal()
        {
            this.maladie_liee = new HashSet<maladie_liee>();
            this.ordonnance = new HashSet<ordonnance>();
        }
    
        public int idAnimal { get; set; }
        public int idClient { get; set; }
        public string nomEspece { get; set; }
        public string nomRace { get; set; }
        public string nomAnimal { get; set; }
        public Nullable<System.DateTime> dateNaissance { get; set; }
        public int taille { get; set; }
        public int poids { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<maladie_liee> maladie_liee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordonnance> ordonnance { get; set; }
        public virtual client client { get; set; }
    }
}
