using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace StateManagementApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Visit"] = 0;
            Application["Now"] = DateTime.Now;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Now"] = DateTime.Now;
            Application.Lock();
            Application["Visit"] = Convert.ToInt32(Application["Visit"]) + 1;
            Application.UnLock();
        }
        protected void Application_End(object sender, EventArgs e)
        {
            // 응용 프로그램 종료 시 실행
            Application["Visit"] = null;
        }
        
        protected void Session_End(object sender, EventArgs e)
        {
            // 세션 종료 시 실행
            // Web.config 파일에서 sessionstate 모드가 
            // Inproc으로 설정 되어 있는 경우에만 발생
            Application.Lock();
            Application["Visit"] = Convert.ToInt32(Application["Visit"]) - 1;
            Application.UnLock();
        }
    }
}