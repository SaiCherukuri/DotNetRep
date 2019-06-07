using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace LearningDotNet
{
    
  public  static class PropertiesCollection
    {
        public static IWebDriver driver;

        public static void ExpWait(string Xpath)
        {
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(Xpath)));
        }

        public static void JavaScriptExecutor(this IWebElement locator, string action)
        {
            //=====================================================Iwebelement locator======================================
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
            if (action == "click") js.ExecuteScript("arguments[0].click()", locator);
            if (action == "scroll") js.ExecuteScript("arguments[0].scrollIntoView(true);", locator);

            //===============================================================String Locator====================================================
            //IWebElement element = PropertiesCollection.driver.FindElement(By.XPath(locator));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
            //if (action == "click") js.ExecuteScript("arguments[0].click()", element);
            //if (action == "scroll") js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

            //if (action == "click") js.ExecuteScript("arguments[0].click()", locator);
            //if (action == "scroll") js.ExecuteScript("arguments[0].scrollIntoView(true);", locator);
        }

    }

}
