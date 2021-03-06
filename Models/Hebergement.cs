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
    
    public partial class Hebergement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hebergement()
        {
            this.DispoHebergements = new HashSet<DispoHebergement>();
            this.Favoris = new HashSet<Favori>();
            this.Reservations = new HashSet<Reservation>();
            this.Saisons = new HashSet<Saison>();
        }
    
        public int IdHebergement { get; set; }
        public int IdAdresse { get; set; }
        public int IdClient { get; set; }
        public string NomHebergement { get; set; }
        public string Photo { get; set; }
        public string TypeHebergement { get; set; }
        public string Description { get; set; }
        public decimal PrixDeBase { get; set; }
        public Nullable<bool> Etat { get; set; }
        public string Departement { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispoHebergement> DispoHebergements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favori> Favoris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saison> Saisons { get; set; }
    }
}
