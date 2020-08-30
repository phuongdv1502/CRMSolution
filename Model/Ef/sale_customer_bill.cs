namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_customer_bill
    {
        public int id { get; set; }

        public int? id_center { get; set; }

        [StringLength(150)]
        public string code { get; set; }

        public DateTime? date_sale { get; set; }

        public double? price { get; set; }

        public double? discount { get; set; }

        public double? sale { get; set; }

        public double? total { get; set; }

        public int? method { get; set; }

        public int? status { get; set; }

        public int? ispay { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}
