using Model.Bussiness;
using Model.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers.Sale
{
    public class ReceptionController : Controller
    {
        Reception rp = new Reception();
        SessionUser user = Env.GetUser();
        // GET: Reception
        public ActionResult Index()
        {
            ViewBag.id_center = user.id_center;
            return View();
        }
        public ActionResult ListAppointment()
        {
            return PartialView();
        }
        public ActionResult _ListAppointment(int id_center,string startdate,string enddate)
        {
            int minRow = 0;
            int maxRow = 0;
            int.TryParse(HttpContext.Request["start"], out minRow);
            int length = 10;
            int.TryParse(HttpContext.Request["length"], out length);
            maxRow = length;
            int draw = 0;
            int.TryParse(HttpContext.Request["draw"], out draw);
            string search = HttpContext.Request["search[value]"].Trim();
            int currentPage = (minRow / 10) + 1;
            int total;
            var result = rp.GetListAppointmetByOffset(id_center,startdate,enddate,search,currentPage, maxRow, out total);

            return Content(JsonConvert.SerializeObject(new
            {
                data = result,
                draw = draw,
                recordsFiltered = total,
                recordsTotal = total
            }));
        }
    }
}