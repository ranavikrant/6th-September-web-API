using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Threading;

namespace WebApplication4.Helper
{
    public class LangHelper
    {
        protected HttpSessionState s;
       public LangHelper(HttpSessionState s)
        {
            this.s = s;
        }

        public static int currentculture
        {
            get
                {
                if (Thread.CurrentThread.CurrentUICulture.Name == "hi-IN")
                {
                    return 1;
                }
                else return 0;

                }
            set
            {
                if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hi-IN");
                }
                else Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            }

        }
    }
}