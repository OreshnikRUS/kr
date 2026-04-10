namespace KR_akimov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            Defect = new HashSet<Defect>();
            Goods_at_Points = new HashSet<Goods_at_Points>();
            Sold_item = new HashSet<Sold_item>();
        }

        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public int? Price { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Defect> Defect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_at_Points> Goods_at_Points { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sold_item> Sold_item { get; set; }
    }
}
