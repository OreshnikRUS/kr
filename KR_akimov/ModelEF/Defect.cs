namespace KR_akimov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Defect")]
    public partial class Defect
    {
        public int ID { get; set; }

        public int? ID_Good { get; set; }

        public int? ID_Outlets { get; set; }

        public DateTime? Return_date { get; set; }

        public int? ID_Worker { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public string Description { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual Outlets Outlets { get; set; }

        public virtual Workers Workers { get; set; }
    }
}
