//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab2semestr4BD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public byte AnimalAge { get; set; }
        public Nullable<int> CageCageId { get; set; }
        public Nullable<int> ClassClassId { get; set; }
    
        public virtual Cage Cage { get; set; }
        public virtual Class Class { get; set; }
    }
}
