using Model.Bussiness;
using Model.Ef;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers.System
{
    public class CommonController : Controller
    {
        SessionUser user = Env.GetUser();
        CRMDataContext db = new CRMDataContext();
        Center ct = new Center();
        // GET: Common
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllCenter(string id, bool hasAll = false, int idSelected = -1, bool isDisable = false)
        {
            // int roleid = user.roleid;
            int? idcenter = user.id_center;
            ViewBag.id = id;
            ViewBag.hasAll = hasAll;
            ViewBag.idSelected = idcenter;
            var checkBrandch = db.sys_center.FirstOrDefault(m => m.id == idcenter);
            if (checkBrandch.isparent == true)
            {
                isDisable = false;
            }
            else
            {
                isDisable = true;
            }
            ViewBag.isDisable = isDisable;
            var result = ct.GetAllCenter(int.Parse(idcenter.ToString()));
            return PartialView(result);
        }
    }
}