namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_department
    {
        public int id { get; set; }

        public int? id_brand { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
