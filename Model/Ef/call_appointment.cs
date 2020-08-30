namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class call_appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? id_center { get; set; }

        public int? id_data { get; set; }

        public int? id_source { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(150)]
        public string fullname { get; set; }

        [StringLength(10)]
        public string mobile { get; set; }

        [StringLength(250)]
        public string note { get; set; }

        [StringLength(250)]
        public string address { get; set; }
    }
}
