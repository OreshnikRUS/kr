namespace KR_akimov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shifts
    {
        public int ID { get; set; }

        public int? ID_Workers { get; set; }

        public DateTime? Shift_Start { get; set; }

        public DateTime? Shift_End { get; set; }

        public virtual Workers Workers { get; set; }
    }
}
