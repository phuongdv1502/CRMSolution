using Model.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Bussiness
{
    public class Center
    {
        CRMDataContext db = null;
        public Center()
        {
            db = new CRMDataContext();
        }
        public List<sys_center> GetAllCenterToList(int pageNo, int pageSize, string search, out int totalRecord)
        {
            try
            {
                var model = db.sys_center.Where(x => (x.name.Contains(search) || x.address.Contains(search)) && x.isdelete == false);
                totalRecord = model.Count();
                return model.OrderBy(x => x.id).Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();
            }
            catch (Exception ex)
            {
                totalRecord = 0;
                Common.Common.Util.write_log(ex.Message.ToLower(), "center.txt");
                return null;
            }
        }
        public int Insert(sys_center model)
        {
            try
            {
                db.sys_center.Add(model);
                db.SaveChanges();
                return model.id;
            }
            catch (Exception ex)
            {
                Common.Common.Util.write_log(ex.Message.ToLower(), "center.txt");
                return 0;
            }
        }
        public bool Update(sys_center model)
        {
            try
            {
                var ct = db.sys_center.Find(model.id);
                ct.name = model.name;
                ct.code = model.code;
                ct.brandname = model.brandname;
                ct.address = model.address;
                ct.update_at = DateTime.Now;
                ct.update_by = model.update_by;
                ct.director = model.director;
                ct.mobile = model.mobile;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.Common.Util.write_log(ex.Message.ToLower(), "center.txt");
                return false;
            }
        }
        public bool DisableCenter(int id, bool status, string user)
        {
            try
            {
                var model = db.sys_center.Find(id);
                model.isdelete = status;
                model.delete_by = user;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.Common.Util.write_log(ex.Message.ToLower(), "center.txt");
                return false;
            }
        }
        public sys_center GetByID(int id)
        {
            try
            {
                return db.sys_center.Find(id);
            }
            catch (Exception ex)
            {
                Common.Common.Util.write_log(ex.Message.ToLower(), "center.txt");
                return null;
            }
        }
        public List<sys_center> GetAllCenter(int id_center)
        {
            try
            {
                if (id_center == 1)
                {
                    return db.sys_center.Where(x => x.isdelete == false).ToList();
                }
                else
                {
                    return db.sys_center.Where(x => x.isdelete == false && x.id == id_center).ToList();
                }

            }
            catch (Exception ex)
            {

                Common.Common.Util.write_log(ex.Message.ToLower(), "center.txt");
                return null;
            }
        }
    }
}
