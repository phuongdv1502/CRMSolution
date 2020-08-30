namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_menu
    {
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(250)]
        public string menu { get; set; }

        public string url { get; set; }

        public string icon { get; set; }

        public int? parent_id { get; set; }
    }
}
