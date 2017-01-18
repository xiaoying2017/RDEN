using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mzxxzy.master
{
    public partial class _Layout : System.Web.UI.MasterPage
    {
        protected string userName;
        protected bool logined;

        protected void Page_Load(object sender, EventArgs e)
        {
            logined = Logined();
            if (logined) userName = Session["UserName"].ToString();
        }

        protected bool Logined()
        {
            var username = Session["UserName"] == null ? string.Empty : Session["UserName"].ToString();
            return !string.IsNullOrEmpty(username);
        }
    }
}