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
    
    public partial class Messagerie
    {
        public int IdMessagerie { get; set; }
        public int IdExpediteur { get; set; }
        public int IdDestinataire { get; set; }
        public string Messages { get; set; }
        public System.DateTime Date { get; set; }
        public bool Statut { get; set; }
    }
}