namespace KR_akimov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods_at_Points
    {
        public int ID { get; set; }

        public int? ID_Good { get; set; }

        public int? Amount { get; set; }

        public int? ID_Outlets { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual Outlets Outlets { get; set; }
    }
}
