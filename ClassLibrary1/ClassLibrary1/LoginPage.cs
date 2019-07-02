using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1
{
    public class LoginPage
    {

        public static void GoTo() => Driver.Instance.Navigate().GoToUrl("https://wordpress.com/log-in");

        public static LoginCommand LoginAs(String email)
        {
            return new LoginCommand(email);
        }
    }

    public class LoginCommand
    {

        private readonly String email;
        private string password;

        public LoginCommand(String email)
        {
            this.email = email;
        }

        public LoginCommand WithPassword(String password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var emailInput = Driver.Instance.FindElement(By.Id("usernameOrEmail"));
            emailInput.SendKeys(email);

            var submitButton = Driver.Instance.FindElement(By.ClassName("button form-button is-primary"));
            submitButton.Click();

            var passwordID = "password";
            if (Driver.waitForElementToAppear(passwordID) == true)
            {
                var passwordInput = Driver.Instance.FindElement(By.Id(passwordID));
                passwordInput.SendKeys(password);

                submitButton.Click();
            }
            


        }
    }
}
