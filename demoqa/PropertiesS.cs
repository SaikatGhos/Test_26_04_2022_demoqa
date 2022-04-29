//Saikat Ghosh
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqa
{
    enum PropertyType
    {
        Id,
        Name,
        Class,
        LinkText,
        Xpath
    }
    class PropertiesS
    {
        public static IWebDriver driver { get; set; }
        public static IAlert alert { get; set; }

        public static IJavaScriptExecutor js { get; set; }

        public static void GoToURL(string url)
        {
            PropertiesS.driver.Navigate().GoToUrl(url);
        }
        public static void MaxWindow()
        {
            PropertiesS.driver.Manage().Window.Maximize();
        }
        public static void Sleep(int time)
        {
            Thread.Sleep(time);
        }
        public static void VScroll(int yPixel)
        {
            try {
                IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesS.driver;
                var VS = String.Format("window.scrollTo(0, {0})", yPixel);
                js.ExecuteScript(VS);                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
        public static void HScroll(int xPixel)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesS.driver;
                var VS = String.Format("window.scrollTo({0}, 0)", xPixel);
                js.ExecuteScript(VS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void CombineScroll(int xPixel, int yPixel)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesS.driver;
                var VS = String.Format("window.scrollTo({0}, {1})", xPixel,yPixel);
                js.ExecuteScript(VS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}










































































































































































































































































































































































//Saikat Ghosh 26_04_22