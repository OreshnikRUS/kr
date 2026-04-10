using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KR_akimov.ModelEF
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF1")
        {
        }

        public virtual DbSet<Defect> Defect { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Goods_at_Points> Goods_at_Points { get; set; }
        public virtual DbSet<Outlets> Outlets { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<Sold_item> Sold_item { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goods>()
                .HasMany(e => e.Defect)
                .WithOptional(e => e.Goods)
                .HasForeignKey(e => e.ID_Good);

            modelBuilder.Entity<Goods>()
                .HasMany(e => e.Goods_at_Points)
                .WithOptional(e => e.Goods)
                .HasForeignKey(e => e.ID_Good);

            modelBuilder.Entity<Goods>()
                .HasMany(e => e.Sold_item)
                .WithOptional(e => e.Goods)
                .HasForeignKey(e => e.ID_Good);

            modelBuilder.Entity<Outlets>()
                .HasMany(e => e.Defect)
                .WithOptional(e => e.Outlets)
                .HasForeignKey(e => e.ID_Outlets);

            modelBuilder.Entity<Outlets>()
                .HasMany(e => e.Goods_at_Points)
                .WithOptional(e => e.Outlets)
                .HasForeignKey(e => e.ID_Outlets);

            modelBuilder.Entity<Outlets>()
                .HasMany(e => e.Sold_item)
                .WithOptional(e => e.Outlets)
                .HasForeignKey(e => e.ID_Outlets);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Defect)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.ID_Worker);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Shifts)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.ID_Workers);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Sold_item)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.ID_Worker);
        }
    }
}
