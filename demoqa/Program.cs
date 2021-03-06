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
    internal class Program : SeleniumSetMethod
    {
        static void Main(string[] args)
        {

            driver = new ChromeDriver();

            GoToURL("https://demoqa.com/");
            MaxWindow();
            
           VScroll(200);
            Sleep(1000);
            Click(PropertyType.Xpath, "//*[@id='app']/div/div/div[2]/div/div[1]/div/div[3]");
            Sleep(3000);

            Elements.elementsRunner();
            //PropertiesS.VScroll(700);
            //ALert_Frame_Window.alert_frame_windowRunner();
            VScroll(700);
            //widgets.widgetRunner();
            Interaction.interactionRun();
            //practicalForm.practicalformRunner(js);

            //bookStore.bookstoreRunner(js);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();            
        }
    }
}
