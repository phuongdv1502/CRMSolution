namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_center
    {
        public int id { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        [StringLength(150)]
        public string name { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        [StringLength(50)]
        public string brandname { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(150)]
        public string director { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime? update_at { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public bool? isdelete { get; set; }

        [StringLength(50)]
        public string delete_by { get; set; }
        public bool isparent { get; set; }
    }
}
