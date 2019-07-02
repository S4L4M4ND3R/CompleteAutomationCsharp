using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dashboard
    {

        public static bool IsAt
        {
            get
            {
                var username = Driver.Instance.FindElements(By.ClassName("user-name"));
                if (username.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
