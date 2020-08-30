namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_room_treatment
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        public int? id_center { get; set; }

        [StringLength(150)]
        public string name { get; set; }

        public int? status { get; set; }

        public bool? isactive { get; set; }
    }
}
