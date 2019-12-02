using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace AutomationTrainingM7C.Base_Files
{
    class BaseTest
    {
        public IWebDriver driver = new ChromeDriver();

        public string url = ConfigurationManager.AppSettings.Get("url");

        
    }
}
