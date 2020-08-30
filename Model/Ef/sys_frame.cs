namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_frame
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string start { get; set; }

        [StringLength(50)]
        public string end { get; set; }
    }
}
