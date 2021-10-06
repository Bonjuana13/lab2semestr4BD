namespace lab2semestr4BD.codeFirstModel1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Animal")]
    public partial class Animal
    {
        public int AnimalId { get; set; }

        [Required]
        [StringLength(60)]
        public string AnimalName { get; set; }

        public byte AnimalAge { get; set; }

        public int? CageCageId { get; set; }

        public int? ClassClassId { get; set; }

        public virtual Cage Cage { get; set; }

        public virtual Class Class { get; set; }
    }
}
