using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNet
{
   public static class  GetMethods
    {
        public static string GetText(this IWebElement element)
        {

            if (element.Text == null) return element.GetAttribute("value");
            else return element.Text;

            //if (elementType == "Id") return driver.FindElement(By.Id(element)).GetAttribute("value");
            //if (elementType == "Name") return driver.FindElement(By.Name(element)).GetAttribute("value");
            //if (elementType == "Css") return driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            //if (elementType == "XPath") return driver.FindElement(By.XPath(element)).GetAttribute("value");
            //if (elementType == "ClassName") return driver.FindElement(By.ClassName(element)).GetAttribute("value");
            //if (elementType == "LinkText") return driver.FindElement(By.LinkText(element)).GetAttribute("value");

        }

        public static string GetDDText(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementType == "Id") return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementType == "Name") return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementType == "Css") return new SelectElement(driver.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementType == "XPath") return new SelectElement(driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementType == "ClassName") return new SelectElement(driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementType == "LinkText") return new SelectElement(driver.FindElement(By.LinkText(element))).AllSelectedOptions.SingleOrDefault().Text;
            //else return string.Empty;
        }
    }
}
