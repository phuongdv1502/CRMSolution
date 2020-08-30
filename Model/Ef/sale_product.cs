namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_product
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        public double? price { get; set; }

        public double? discount { get; set; }

        public double? sale { get; set; }

        public int? unit { get; set; }

        [StringLength(50)]
        public string unit_name { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        public int? number { get; set; }

        public int? extra { get; set; }
    }
}
