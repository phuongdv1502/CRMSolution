using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class AppointmentViewModel
    {
        public int id { get; set; }
        public int id_center { get; set; }
        public string fullname { get; set; }
        public int id_telesale { get; set; }
        public string name_telesale { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string app_date { get; set; }
        public int status { get; set; }
        public string status_name { get; set; }
        public string frame { get; set; }
        public string name_center { get; set; }
        public string date_come { get; set; }
        public string source { get; set; }
        public string male { get; set; }

    }
}
