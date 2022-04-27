using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PropertiesS.driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesS.driver;
            PropertiesS.driver.Navigate().GoToUrl("https://demoqa.com/login");
            PropertiesS.driver.Manage().Window.Maximize();

            IAlert alert;
            Thread.Sleep(2000);

            Elements.elementsRunner(js);
            ALert_Frame_Window.alert_frame_windowRunner(js);
            widgets.widgetRunner(js);
            Interaction.interactionRun(js);

            //bookStore.bookstoreRunner(js);
            Thread.Sleep(5000);
            PropertiesS.driver.Close();
            PropertiesS.driver.Quit();
            

        }
    }
}
