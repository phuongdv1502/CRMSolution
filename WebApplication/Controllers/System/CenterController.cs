using Common.Common;
using Microsoft.Net.Http.Headers;
using Model.Bussiness;
using Model.Ef;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers.System
{
    public class CenterController : BaseController
    {
        Center ct = new Center();
        // GET: Center
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListCenter()
        {
            return PartialView();
        }
        public ActionResult _ListCenter()
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
            var result = ct.GetAllCenterToList(currentPage, maxRow, search, out total);

            return Content(JsonConvert.SerializeObject(new
            {
                data = result,
                draw = draw,
                recordsFiltered = total,
                recordsTotal = total
            }));
        }
        public ActionResult ModalInsertUpdate(int id)
        {
            sys_center model = new sys_center();
            if (id > 0)
            {
                model = ct.GetByID(id);
            }
            return PartialView(model);
        }
        public JsonResult Save(int id, string code, string name, string mobile, string director, string brandname, string address)
        {
            SystemMessage.MessageLogin message = new SystemMessage.MessageLogin();
            sys_center model = new sys_center();
            model.id = id;
            model.code = code;
            model.name = name;
            model.mobile = mobile;
            model.director = director;
            model.brandname = brandname;
            model.address = address;

            if (model.id == 0)
            {
                model.isdelete = false;
                model.created_at = DateTime.Now;
                model.created_by = Env.GetUser().username;
                int ids = ct.Insert(model);
                if (ids > 0)
                {
                    message.IsSuccess = true;
                    message.Message = SystemMessageConst.AddSuccess;
                }
                else
                {
                    message.IsSuccess = false;
                    message.Message = SystemMessageConst.AddError;
                }

            }
            else
            {
                model.update_at = DateTime.Now;
                model.update_by = Env.GetUser().username;
                if (ct.Update(model))
                {
                    message.IsSuccess = true;
                    message.Message = SystemMessageConst.UpdateSuccess;
                }
                else
                {
                    message.IsSuccess = false;
                    message.Message = SystemMessageConst.UpdateError;
                }

            }
            return Json(new
            {
                result = message
            }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteCenter(int id)
        {
            SystemMessage.MessageLogin message = new SystemMessage.MessageLogin();
            if (ct.DisableCenter(id, true, Env.GetUser().username))
            {
                message.IsSuccess = true;
                message.Message = SystemMessageConst.DeleteSuccess;
            }
            else
            {
                message.IsSuccess = false;
                message.Message = SystemMessageConst.UpdateError;
            }
            return Json(new
            {
                result = message
            }, JsonRequestBehavior.AllowGet);
        }
    }
}