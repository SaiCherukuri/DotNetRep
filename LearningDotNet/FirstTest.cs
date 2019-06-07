using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LearningDotNet
{
    [TestClass]
    public class FirstTest 
    {
        LoginPageObject pageobj;

       [SetUp]
        public void Initilize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Opened Browser");
            PropertiesCollection.driver.Navigate().GoToUrl("http://tts.anblicks.com//tts.client-dev/");
            Console.WriteLine("Opened TSS Page");
            pageobj = new LoginPageObject();
        }

        [Test]
        public void ExecuteScript()
        {
            pageobj.LoginTTS("show2", "show2", "show2");
            
            
            //LoginPage.Login("show2", "show2", "show2");
            //Console.WriteLine("Logged In");
            //if (PropertiesCollection.driver.FindElement(By.XPath("//h4[@class='user-name']")).Text.Equals("SHOW2"))
            //{
            //    Console.WriteLine("user verified");
            //    SetMethods.ExpWait("//a/span");
            //    Console.WriteLine("wait completed");
            //    SetMethods.JavaScriptExecutor( "//div[1]/div/a/span", "click");
            //    Console.WriteLine("Clicked on Orders");
            //}
            //else
            //{
            //    Console.WriteLine("Logging Unsuccessfull");
            //}

        }

        [TearDown]
        public void KillBrowser()
        {
            pageobj.LogOut();
            PropertiesCollection.driver.Close();
            PropertiesCollection.driver.Quit();
            Console.WriteLine("Closed Browser");
        }
    }
}
