using Model;
using Model.Ef;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication.Controllers.System
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext ctx)
        {
            var entity = new CRMDataContext();

            SessionUser user = GetSessionBusiness.GetUser();

            if (user.id == 0)
            {
                ctx.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Authentication", action = "login" })
                );
                return;
            }
            else
            {

                int userid = user.id;
               // int roleiduser = user.roleid;
                int? branchId = user.id_center;


                string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
                string controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();



                if (controllerName != "Authentication" && controllerName != "SiMenuBar")
                {
                    var checkNewPass = entity.sys_user.FirstOrDefault(m => m.id == userid);
                    if (checkNewPass != null && checkNewPass.status_password.ToString() == "1")
                    {
                        ctx.Result = new RedirectToRouteResult(
                            new RouteValueDictionary(new { controller = "Authentication", action = "ChangePassword" })
                        );
                        return;
                    }
                }

                string TitleWeb = "";
                var menu = entity.sys_menu.FirstOrDefault(m => m.url == controllerName);
                if (menu != null)
                {
                    if (!string.IsNullOrEmpty(menu.parent_id.ToString()))
                    {
                        int id_parent = 0;
                        int.TryParse(menu.parent_id.ToString(), out id_parent);

                        var parent = entity.sys_menu.FirstOrDefault(m => m.id == id_parent);

                        TitleWeb = parent.menu + " > " + menu.menu;
                        //user.UrlParent = parent.url;
                        //user.UrlChil = menu.url;
                    }
                    else
                    {
                        TitleWeb += " > " + menu.menu;

                        //user.UrlParent = menu.menu;
                    }

                    //user.TitleWeb = TitleWeb;

                    //var check = entity.MenuPermission.FirstOrDefault(m =>
                    //    (m.UserId == null || m.UserId == userid) && m.RoleId == roleiduser && m.MenuId == menu.Id &&
                    //    m.IsRead == true);

                    //if (check == null)
                    //{
                    //    ctx.Result = new RedirectToRouteResult(
                    //        new RouteValueDictionary(new { controller = "NotFound", action = "Index" })
                    //    );
                    //    return;
                    //}
                }
            }
        }
    }
}