using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
  public  class SessionUser
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string avartar { get; set; }
        public int? id_center { get; set; }
        public int? id_department { get; set; }
        public string name_center { get; set; }
        public string name_department { get; set; }
        public string postion_name { get; set; }
        public int postion { get; set; }
        public string username { get; set; }
    }
}
