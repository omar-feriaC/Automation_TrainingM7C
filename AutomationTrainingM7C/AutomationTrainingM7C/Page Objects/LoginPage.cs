using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using AutomationTrainingM7C.Base_Files;

namespace AutomationTrainingM7C.Page_Objects
{
    class LoginPage:BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/
        private static readonly string STR_USERNAME_TEXTFIELD = "userName";
        private static readonly string STR_PASSWORD_TEXTFIELD = "password";
        private static readonly string STR_LOGIN_BUTTON = "//input[@name='login']";

        public LoginPage(IWebDriver objDriver)
        {
            _objDriver = objDriver;
        }

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objUserNameInput => _objDriver.FindElement(By.Name(STR_USERNAME_TEXTFIELD));


    }
}
