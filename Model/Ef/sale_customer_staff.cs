namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sale_customer_staff
    {
        public int id { get; set; }

        public int? id_customer { get; set; }

        public int? id_user { get; set; }

        public int? postion { get; set; }

        [StringLength(150)]
        public string name_user { get; set; }

        [StringLength(50)]
        public string code_user { get; set; }

        public DateTime? created_date { get; set; }
    }
}
