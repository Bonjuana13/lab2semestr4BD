namespace lab2semestr4BD.codeFirstModel1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cage")]
    public partial class Cage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cage()
        {
            Animals = new HashSet<Animal>();
        }

        public int CageId { get; set; }

        [Required]
        [StringLength(80)]
        public string CageName { get; set; }

        public int CageCount { get; set; }

        public int? ZooZooId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal> Animals { get; set; }

        public virtual Zoo Zoo { get; set; }
    }
}
