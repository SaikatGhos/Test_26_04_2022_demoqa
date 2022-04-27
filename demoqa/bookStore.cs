using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
    class login
    {
        public static void NewUserBtn(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//*[@id='newUser']");
            
        }
        public static void firstName(string firstName)
        {
            SeleniumSetMethod.SendKeys("Xpath", "//*[@id= 'firstname']", firstName);

        }
        public static void lastname(string lastname)
        {
            SeleniumSetMethod.SendKeys("Xpath", "//*[@id= 'lastname']", lastname);

        }
        public static void UserName(string userName)
        {
            SeleniumSetMethod.SendKeys("Xpath", "//*[@id= 'userName']", userName);
            
        }
        public static void Password(string password)
        {
            SeleniumSetMethod.SendKeys("Xpath", "//*[@id= 'password']", password);
            
        }

        public static void LoginBtn()
        {
            SeleniumSetMethod.Click("Xapth", "//*[@id= 'login']");
            SeleniumSetMethod.Click("Xapth", "//*[@id= 'register']");
            
        }
        public static void regisBtn()
        {           
            SeleniumSetMethod.Click("Xapth", "//*[@id= 'register']");

        }

        public static void loginRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][6]//child::li[1]");
            PropertiesS.Sleep(2000);
            NewUserBtn(js);
            PropertiesS.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            firstName("heven");
            PropertiesS.Sleep(2000);
            lastname("moly");
            PropertiesS.Sleep(2000);
            UserName("heven_moly");
            PropertiesS.Sleep(2000);
            Password("demoPass");
            PropertiesS.Sleep(2000);
            regisBtn();
        }
    }
    class bookStore
    {
        public static void bookstoreRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");            
            login.loginRunner(js);
        }
    }
}
