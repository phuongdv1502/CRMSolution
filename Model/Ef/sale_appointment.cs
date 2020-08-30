namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_appointment
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        public int? id_center { get; set; }

        public int? id_telesale { get; set; }

        [StringLength(50)]
        public string extend { get; set; }

        public DateTime? app_date { get; set; }

        public DateTime? date_come { get; set; }

        [StringLength(150)]
        public string fullname { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        public int? status { get; set; }

        [StringLength(250)]
        public string note { get; set; }

        public int? type { get; set; }

        public int? frame { get; set; }

        public int? room_id { get; set; }

        [StringLength(150)]
        public string room_name { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        public bool? isdelete { get; set; }

        [StringLength(50)]
        public string delete_by { get; set; }
        public bool male { get; set; }
    }
}
