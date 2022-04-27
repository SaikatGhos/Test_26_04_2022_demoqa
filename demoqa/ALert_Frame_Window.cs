using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demoqa
{
    class BrowserWindow
    {
        public static void NewTab()
        {
            SeleniumSetMethod.Click("Id", "tabButton");
            
        }
        public static void NewWindow()
        {
            SeleniumSetMethod.Click("Id", "windowButton");
            
        }
        public static void NewWindowMessage()
        {
            SeleniumSetMethod.Click("Id", "messageWindowButton");            
        }
        public static void windowRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[1]");
            PropertiesS.Sleep(2000);
            NewTab();
            PropertiesS.Sleep(2000);
            NewWindow();
            PropertiesS.Sleep(2000);
            NewWindowMessage();

        }
    }
    class modal
    {
        public static void SmallModal()
        {
            SeleniumSetMethod.Click("id", "showSmallModal");
            
        }
        public static void CloseSmall()
        {
            SeleniumSetMethod.Click("id", "closeSmallModal");
           
        }
        public static void LargeModal()
        {
            SeleniumSetMethod.Click("id", "showLargeModal");
            
        }
        public static void CloseLarge()
        {
            SeleniumSetMethod.Click("id", "closeLargeModal");
            
        }
        public static void modalRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[5]");
            PropertiesS.Sleep(2000);
            SmallModal();
            PropertiesS.Sleep(2000);
            CloseSmall();
            PropertiesS.Sleep(2000);
            LargeModal();
            PropertiesS.Sleep(2000);
            CloseLarge();
        }
    }
 
    class frame
    {
        

        public static void AlertFrames(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,400)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[3]");
            
        }
        public static void AlertNestedFrames()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[4]");
            
        }
        public static void AlertModealDialogs()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[5]");
            
        }
        public static void frameRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,400)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[3]");
            PropertiesS.Sleep(2000);
            AlertFrames(js);
        }
    }
    class alert
    {
        #region Alert

        public static void Simplealert()
        {
            SeleniumSetMethod.Click("Xpath", "//button[@id='alertButton']");
            PropertiesS.alert = PropertiesS.driver.SwitchTo().Alert();
            PropertiesS.alert.Accept();
            PropertiesS.Sleep(2000);
            PropertiesS.driver.SwitchTo().DefaultContent();
        }
        public static void alert2()
        {
            SeleniumSetMethod.Click("Xpath", "//button[@id='timerAlertButton']");
            PropertiesS.Sleep(5000);
            PropertiesS.alert = PropertiesS.driver.SwitchTo().Alert();
            PropertiesS.Sleep(2000);
            PropertiesS.alert.Accept();
            PropertiesS.driver.SwitchTo().DefaultContent();
        }
        public static void alert3()
        {
            SeleniumSetMethod.Click("Xpath", "//button[@id='confirmButton']");
            PropertiesS.alert = PropertiesS.driver.SwitchTo().Alert();
            PropertiesS.alert.Accept();
            PropertiesS.Sleep(5000);
            PropertiesS.driver.SwitchTo().DefaultContent();
            PropertiesS.Sleep(2000);
            SeleniumSetMethod.Click("Xpath", "//button[@id='confirmButton']");
            PropertiesS.alert = PropertiesS.driver.SwitchTo().Alert();
            PropertiesS.alert.Dismiss();
            PropertiesS.Sleep(5000);
            PropertiesS.driver.SwitchTo().DefaultContent();
        }
        public static void alert4(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//button[@id='promtButton']");
            PropertiesS.alert = PropertiesS.driver.SwitchTo().Alert();
            PropertiesS.Sleep(2000);
            PropertiesS.alert.SendKeys("Abc");
            PropertiesS.Sleep(2000);
            PropertiesS.alert.Accept();
            PropertiesS.Sleep(5000);
            PropertiesS.driver.SwitchTo().DefaultContent();
            PropertiesS.Sleep(2000);
            SeleniumSetMethod.Click("Xpath", "//button[@id='promtButton']");
            PropertiesS.alert = PropertiesS.driver.SwitchTo().Alert();
            PropertiesS.Sleep(2000);
            PropertiesS.alert.Dismiss();
            PropertiesS.Sleep(5000);
            PropertiesS.driver.SwitchTo().DefaultContent();
        }
        #endregion Alert
        public static void alertRunner(IJavaScriptExecutor js)
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][3]//child::li[2]");
            PropertiesS.Sleep(2000);
            Simplealert();
            PropertiesS.Sleep(2000);
            alert2();
            PropertiesS.Sleep(2000);
            alert3();
            PropertiesS.Sleep(2000);
            alert4(js);
        }

    }
    class ALert_Frame_Window
    {

        public static void alert_frame_windowRunner(IJavaScriptExecutor js)
        {
            BrowserWindow.windowRunner(js);
            PropertiesS.Sleep(5000);
            alert.alertRunner(js);
            PropertiesS.Sleep(5000);
            frame.frameRunner(js);
            PropertiesS.Sleep(5000);
            modal.modalRunner(js);
        }
    }
}
