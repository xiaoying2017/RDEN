using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mzxxzy.tools
{
    /// <summary>
    /// Summary description for admin_ajax
    /// </summary>
    public class admin_ajax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var action = context.Request["action"];
            switch (action)
            {
                case "user_list":
                    user_list(context);
                    break;
            }
        }

        private static void user_list(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            var pageIndex = Convert.ToInt32(context.Request["page"]);
            var pageSize = Convert.ToInt32(context.Request["pageSize"]);
            if (pageIndex <= 0) pageIndex = 1;
            if (pageSize <= 0) pageSize = 10;
            var bll = new BLL.Account.User();
            var list = bll.GetUserList(pageIndex, pageSize).Select(o => new {
                id = o.user_id,
                name = o.user_admin,
                pwd = o.user_psw,
                tel = o.user_tel,
                date = $"{o.user_date:yyyy-MM-dd}"
            }).ToList();
            var data = new { rows = list, total = list.Count };

            // TODO: 增加json序列化方法，将data序列化后再输出
            context.Response.Write(SerializerHelper.ToJson(data));

            context.Response.End();
        }

        public bool IsReusable => false;
    }
}