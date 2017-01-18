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
                case "user_list":
                    user_list(context);
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

        private static void user_list(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            var pageIndex = Convert.ToInt32(context.Request["page"]);
            var pageSize = Convert.ToInt32(context.Request["pageSize"]);
            if (pageIndex <= 0) pageIndex = 1;
            if (pageSize <= 0) pageSize = 10;
            var bll = new BLL.Account.User();
            var list = bll.GetUserList(pageIndex, pageSize);
            var data = new { list = list, total = list.Count };

            // TODO: 增加json序列化方法，将data序列化后再输出
            context.Response.Write(data.ToString());

            context.Response.End();
        }

        public bool IsReusable => false;
    }
}