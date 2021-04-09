using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmAppSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [1] application++
            if (Application["Count"] == null) {
                Application.Lock();
                Application["Count"] = 1;
                Application.UnLock();
            }
            else
            {
                Application["Count"] = (int)Application["Count"] + 1;
            }

            // [2] session++
            if (Session["Count"] == null) Session["Count"] = 1;
            else Session["Count"] = (int)Session["Count"] + 1;

            // [3] 출력
            // 누구나 1증가 
            this.lblApp.Text = Application["Count"].ToString();
            this.lblSession.Text = Session["Count"].ToString();
            this.lblSessionID.Text = Session.SessionID;
            this.lblTimeout.Text = Session.Timeout.ToString();

        }



    }
}