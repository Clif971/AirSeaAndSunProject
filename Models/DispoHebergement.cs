//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirSeaAndSunProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DispoHebergement
    {
        public int IdDispo { get; set; }
        public int IdHebergement { get; set; }
        public System.DateTime DateDebut { get; set; }
        public System.DateTime DateFin { get; set; }
        public decimal Prix { get; set; }
    
        public virtual Hebergement Hebergement { get; set; }
    }
}
