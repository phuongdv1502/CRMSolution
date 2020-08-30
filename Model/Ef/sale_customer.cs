namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_customer
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        public int? id_center { get; set; }

        [StringLength(150)]
        public string name_center { get; set; }

        [StringLength(150)]
        public string fullname { get; set; }

        [StringLength(50)]
        public string id_card { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birtday { get; set; }

        public bool? male { get; set; }

        [StringLength(10)]
        public string mobile { get; set; }

        [StringLength(10)]
        public string mobile_orther { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        public DateTime? date_come { get; set; }

        public int? type { get; set; }

        public int? status { get; set; }

        public int? room_id { get; set; }

        [StringLength(150)]
        public string room_name { get; set; }

        public int? id_customer_relation { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        public bool? isdelete { get; set; }

        [StringLength(50)]
        public string delete_by { get; set; }
    }
}
