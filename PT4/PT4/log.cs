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
    
    public partial class log
    {
        public int idLog { get; set; }
        public int idSalarie { get; set; }
        public System.DateTime date { get; set; }
        public string action { get; set; }
        public string objet_action { get; set; }
        public Nullable<int> idObjet { get; set; }
    
        public virtual salarie salarie { get; set; }
    }
}
