using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab2semestr4BD.codeFirstModel1
{
    public partial class Model1CodeFirstTest : DbContext
    {
        public Model1CodeFirstTest()
            : base("name=Model1CodeFirstTest")
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Cage> Cages { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Zoo> Zoos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
