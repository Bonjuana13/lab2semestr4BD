namespace lab2semestr4BD.codeFirstModel1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zoo")]
    public partial class Zoo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zoo()
        {
            Cages = new HashSet<Cage>();
        }

        public int ZooId { get; set; }

        [Required]
        [StringLength(60)]
        public string ZooName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cage> Cages { get; set; }
    }
}
