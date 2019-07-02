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
            IWebElement emailInput = Driver.Instance.FindElement(By.Id("usernameOrEmail"));
            emailInput.SendKeys(email);

            var submitButton = Driver.Instance.FindElement(By.CssSelector("[type='submit']"));
            submitButton.Click();

            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var passwordInput = Driver.Instance.FindElement(By.Id("password"));
            passwordInput.SendKeys(password);

            submitButton.Click();

        }
    }
}
