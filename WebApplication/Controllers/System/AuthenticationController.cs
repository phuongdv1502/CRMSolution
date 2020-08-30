using Common.Common;
using Common.Encrypt;
using Microsoft.AspNet.Identity;
using Model.Dao;
using Model.Ef;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Common.Common.SystemMessage;

namespace WebApplication.Controllers.System
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        CRMDataContext db = new CRMDataContext();
        // GET: Authentication
        public ActionResult login()
        {
            Session.RemoveAll();
            ViewBag.Title = "Đăng nhập hệ thống";
            return PartialView();
        }
        public async Task<ActionResult> _login(string username, string password)
        {
            sys_log logEntity = new sys_log();
            logEntity.moduleName = "AuthenticationController - login";
            logEntity.type = DbLogType.Login.ToString();
            User dao = new User();
            var resul = dao.Login(username);
            MessageLogin systemMessage = new MessageLogin();
            password = Encrypt.MD5Hash(password.Trim(), 16);

            if (resul == null)
            {
                systemMessage.IsSuccess = false;
                systemMessage.Message = SystemMessageConst.AccountNotExist;
                logEntity.result = false;
                logEntity.description = "Lỗi đăng nhập，" + systemMessage.Message;
            }
            else
            {
                if (resul.password != password)
                {
                    systemMessage.IsSuccess = false;
                    systemMessage.Message = SystemMessageConst.PasswordNotCorrect;
                    logEntity.result = false;
                    logEntity.description = "Lỗi đăng nhập，" + systemMessage.Message;
                }
                else
                {
                    var center = db.sys_center.FirstOrDefault(x => x.id == resul.id_center);
                    var department = db.sys_department.FirstOrDefault(x => x.id == resul.id_department);
                    var postion = db.sys_param.FirstOrDefault(x => x.code == resul.postion.ToString()&&x.type=="Postion");
                    SessionUser sessionUser = new SessionUser();
                    sessionUser.id = resul.id;
                    sessionUser.username = resul.username;
                    sessionUser.avartar = resul.avartar;
                    sessionUser.id_center = resul.id_center;
                    sessionUser.name_center = center.name;
                    sessionUser.name_department = department.name;
                    sessionUser.fullname = resul.fullname;
                    Session["session"] = sessionUser;
                    systemMessage.IsSuccess = true;
                    systemMessage.Message = "/Home/Index";

                    logEntity.account = resul.username;
                    logEntity.result = true;
                    logEntity.description = "Đăng nhập thành công";
                    new LogApp().WriteDbLog(logEntity);
                }
            }
            var t_result = await Task.FromResult(systemMessage);
            return Json(new
            {
                result = t_result
            }, JsonRequestBehavior.AllowGet);
        }
    }
}