using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace mzxxzy.tools
{
    /// <summary>
    /// Summary description for submit_ajax
    /// </summary>
    public class submit_ajax : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            var action = context.Request["action"];
            switch (action)
            {
                case "user_login":
                    user_login(context);
                    break;
            }
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="context"></param>
        private static void user_login(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            var bll = new BLL.Account.User();

            var username = context.Request["username"];
            var password = context.Request["password"];
            var vcode = context.Request["vcode"];
            var turl = HttpContext.Current.Session["ReturnUrl"] == null ? "/login.aspx" : HttpContext.Current.Session["ReturnUrl"].ToString();

            if (string.IsNullOrEmpty(username))
            {
                context.Response.Write("{\"status\":\"error\",\"msg\":\"用户名不能为空！\"}");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                context.Response.Write("{\"status\":\"error\",\"msg\":\"密码不能为空！\"}");
                return;
            }
            if (string.IsNullOrEmpty(vcode))
            {
                context.Response.Write("{\"status\":\"error\",\"msg\":\"验证码不能为空！\"}");
                return;
            }
            if (HttpContext.Current.Session["ValidateNum"] == null || !string.Equals(vcode, HttpContext.Current.Session["ValidateNum"].ToString(), StringComparison.CurrentCultureIgnoreCase))
            {
                context.Response.Write("{\"status\":\"error\",\"msg\":\"验证码错误！\"}");
                return;
            }

            var result = bll.Login(username, password);
            if (!result)
            {
                context.Response.Write("{\"status\":\"error\",\"msg\":\"用户名或密码不正确！\"}");
                return;
            }
            if (string.IsNullOrEmpty(turl)) turl = "/";
            HttpContext.Current.Session["UserName"] = username;
            context.Response.Write("{\"status\":\"success\",\"msg\":\"登录成功！\",\"turl\":\"" + turl + "\"}");
            context.Response.End();
        }

        public bool IsReusable => false;
    }
}