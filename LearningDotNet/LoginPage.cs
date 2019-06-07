using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningDotNet
{
    class LoginPage : FirstTest
    {
        public static void Login(string compamyName,string userName, string password )
        {
            //SetMethods.EnterText( "Id", "CompanyName", compamyName); //Entering coompany name
            //SetMethods.EnterText( "Id", "UserName", userName);       //Entering UserName
            //SetMethods.EnterText( "Id", "Password", password);       //Entering Password
            //SetMethods.Submit( "XPath", "//button[@type='submit']"); //Clicling on LogIn Button
            
        }

        public static void LogOut()
        {
         //   SetMethods.JavaScriptExecutor( "//div[3]/h4", "click");
         //   SetMethods.JavaScriptExecutor( "//a[contains(text(),'Log Out')]", "click");
        }

    }

}
