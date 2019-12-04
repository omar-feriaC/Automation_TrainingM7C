using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7C.Base_Files;
using AutomationTrainingM7C.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationTrainingM7C.Test_Cases
{
    class Newtours_Loginpage:BaseTest
    {
        [Test]
        public void fnLogin()
        {
            //IWebElement username = driver.FindElement(By.Name("userName"));
            //username.SendKeys(ConfigurationManager.AppSettings.Get("user"));

            //IWebElement password = driver.FindElement(By.Name("password"));
            //password.SendKeys(ConfigurationManager.AppSettings.Get("password"));

            //IWebElement loginBtn = driver.FindElement(By.Name("login"));
            //loginBtn.Click();

            LoginPage pgLogin = new LoginPage(driver);

            pgLogin.fnEnterUserName(ConfigurationManager.AppSettings.Get("user"));
            pgLogin.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            pgLogin.fnClickLogin();
            Assert.AreEqual("Sign-on: Mercury Tours", driver.Title);

            //IWebElement objUserNameTextField = pgLogin.GetUserNameField();
        }
    }
}
