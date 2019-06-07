using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace LearningDotNet
{
   public static class SetMethods
    {

        public static void EnterText(this IWebElement element,string value)
        {
            element.SendKeys(value);
            //if (elementType == "Id") PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementType == "Name") PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            //if (elementType == "Css") PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            //if (elementType == "XPath") PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            //if (elementType == "ClassName") PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            //if (elementType == "LinkText") PropertiesCollection.driver.FindElement(By.LinkText(element)).SendKeys(value);
        }

        public static void CLick(this IWebElement element)
        {
            element.Click();
            //if (elementType == "Id") PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //if (elementType == "Name") PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            //if (elementType == "Css") PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            //if (elementType == "XPath") PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            //if (elementType == "ClassName") PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            //if (elementType == "LinkText") PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
            //if (elementType == "Id") new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementType == "Name")new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            //if (elementType == "Css")new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            //if (elementType == "XPath") new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            //if (elementType == "ClassName")new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
            //if (elementType == "LinkText")new SelectElement(PropertiesCollection.driver.FindElement(By.LinkText(element))).SelectByText(value);
        }

        public static void SubmitBtn(this IWebElement element)
        {
            element.Submit();
            //if (elementType == "Id") PropertiesCollection.driver.FindElement(By.Id(element)).Submit();
            //if (elementType == "Name") PropertiesCollection.driver.FindElement(By.Name(element)).Submit();
            //if (elementType == "Css") PropertiesCollection.driver.FindElement(By.CssSelector(element)).Submit();
            //if (elementType == "XPath") PropertiesCollection.driver.FindElement(By.XPath(element)).Submit();
            //if (elementType == "ClassName") PropertiesCollection.driver.FindElement(By.ClassName(element)).Submit();
            //if (elementType == "LinkText") PropertiesCollection.driver.FindElement(By.LinkText(element)).Submit();

        }

       
    }
}
