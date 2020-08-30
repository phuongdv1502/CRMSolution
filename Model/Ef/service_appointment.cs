namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class service_appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? id_customer { get; set; }

        public int? id_center { get; set; }

        public int? id_bill { get; set; }

        public int? id_bill_detail { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        public DateTime? date_call { get; set; }

        public DateTime? app_date { get; set; }

        public DateTime? date_come { get; set; }

        public int? treatment_number { get; set; }

        public int? treatment_type { get; set; }

        public int? frame { get; set; }

        [StringLength(150)]
        public string frame_name { get; set; }

        public int? isdoctor { get; set; }

        [StringLength(500)]
        public string note { get; set; }

        public DateTime? checkin_time { get; set; }

        [StringLength(50)]
        public string checkin_by { get; set; }

        public DateTime? checkout_time { get; set; }

        public DateTime? checkout_by { get; set; }

        public int? call_status { get; set; }

        public int? status { get; set; }

        public DateTime? created_at { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime? update_at { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public int? room_id { get; set; }

        [StringLength(150)]
        public string room_name { get; set; }
    }
}
