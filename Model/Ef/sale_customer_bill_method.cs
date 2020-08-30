namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_customer_bill_method
    {
        public int id { get; set; }

        public int? id_bill { get; set; }

        public int? id_method { get; set; }

        public double? price { get; set; }

        public double? discount { get; set; }

        public double? sale { get; set; }

        public double? total { get; set; }
    }
}
