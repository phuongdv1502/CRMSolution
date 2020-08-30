namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_product_detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? id_product { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        public int? unit { get; set; }

        [StringLength(50)]
        public string unit_name { get; set; }

        public double? price { get; set; }

        public double? sale { get; set; }
    }
}
