using System;
using ClassLibrary1;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmokeTest
{
    [TestClass]
    public class Login
    {
        
        [TestInitialize]
        public void InitDriver()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Test_User_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("qtester111@gmail.com").WithPassword("P@ssw0rd").Login();
            Assert.IsTrue(Dashboard.IsAt, "Failed to login");
            
        }

        [TestCleanup]
        public void CloseDriver()
        {
            Driver.Close();
        }
    }
}
