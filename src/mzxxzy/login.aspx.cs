﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mzxxzy
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserName"] != null && !string.IsNullOrEmpty(Session["UserName"].ToString()))
            {
                Response.Redirect("/");
            }
        }
    }
}