namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_customer_bill_detail
    {
        public int id { get; set; }

        public int? id_bill { get; set; }

        public int? id_product { get; set; }

        public int? id_product_detail { get; set; }

        [StringLength(50)]
        public string product_code { get; set; }

        [StringLength(500)]
        public string product_name { get; set; }

        public int? quantity { get; set; }

        public double? price { get; set; }

        public double? discount { get; set; }

        public double? sale { get; set; }

        public double? total { get; set; }

        public int? unit { get; set; }

        [StringLength(50)]
        public string unit_name { get; set; }

        public int? number { get; set; }

        public int? used { get; set; }

        public int? rest { get; set; }
    }
}
