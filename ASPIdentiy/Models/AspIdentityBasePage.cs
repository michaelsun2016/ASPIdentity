using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPIdentiy.Models
{
    public class AspIdentityBasePage : System.Web.UI.Page
    {
        public AspIdentityBasePage() { }

        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (Context.Session != null)
            {
                if (Session.IsNewSession)
                {
                    string szCookieHeader = Request.Headers["Cookie"];
                    if ((null != szCookieHeader) && (szCookieHeader.IndexOf("ASP.NET_SessionId") >= 0))
                    {
                        Response.Redirect("~/Account/Login.aspx");
                    }  
                }
            }
        }
    }
}