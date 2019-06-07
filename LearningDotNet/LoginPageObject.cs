using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace LearningDotNet
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //============================================Logging In ======================================================================

        [FindsBy(How = How.Id, Using = "CompanyName")] public IWebElement txtCompanyName;
        [FindsBy(How = How.Id, Using = "UserName")] public IWebElement txtUserName;
        [FindsBy(How = How.Id, Using = "Password")] public IWebElement txtPassword;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")] public IWebElement btnLoginButton;
        [FindsBy(How=How.XPath, Using = "//h4[@class='user-name']")] public IWebElement verifyUser;

        public void LoginTTS(string companyName, string userName, string password)
        {
            //=========================================================using this IWEBDRIVER instead of passing wedriver as parameter===================================================
            txtCompanyName.EnterText(companyName);
            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            btnLoginButton.SubmitBtn();
            
            //SetMethods.EnterText(txtCompanyName,companyName);
            //SetMethods.EnterText(txtUserName, userName);
            //SetMethods.EnterText(txtPassword, password);
            //SetMethods.Submit(btnLoginButton);
            
            if (verifyUser.GetText().ToLower().Equals(userName)) Console.WriteLine("Logged in Suucccefully");

            //txtCompanyName.SendKeys(companyName);
            //txtUserName.SendKeys(userName);
            //txtPassword.SendKeys(password);
            //btnLoginButton.Click();
            //if (verifyUser.Text.Equals(userName)) Console.WriteLine("Logged in Suucccefully");
        }

        //==========================================Logging Out==========================================================================

        [FindsBy(How = How.XPath, Using = "//div[3]/h4")] public IWebElement profileLogo;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Log Out')]")] public  IWebElement btnLogOut;

        public void LogOut()
        {
            // PropertiesCollection.JavaScriptExecutor(profileLogo , "click");
            //PropertiesCollection.JavaScriptExecutor(btnLogOut , "click");

            //=============================using this IWebELement=====================================================================================
            profileLogo.JavaScriptExecutor("click");
            btnLogOut.JavaScriptExecutor("click");

            //=========================================================================String locator======================================
            //PropertiesCollection.JavaScriptExecutor("//div[3]/h4", "click");
            //PropertiesCollection.JavaScriptExecutor("//a[contains(text(),'Log Out')]", "click");

            Console.WriteLine("LoggedOut Successfully ");
        }
    }
}
