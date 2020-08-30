namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_user
    {
        public int id { get; set; }

        public int? id_center { get; set; }

        public int? id_department { get; set; }

        [StringLength(20)]
        public string code { get; set; }

        [StringLength(150)]
        public string fullname { get; set; }

        public int? postion { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        [StringLength(10)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(150)]
        public string password { get; set; }

        [StringLength(50)]
        public string extend { get; set; }

        public int? role { get; set; }

        public bool? isactive { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        public string avartar { get; set; }

        public int? status_password { get; set; }
    }
}
