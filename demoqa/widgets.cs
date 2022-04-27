using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
    class accordian
    {
        
        public static void Section1()
        {
            SeleniumSetMethod.Click("id", "section1Heading");
        }
        public static void Section2(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("id", "section2Heading"); 
        }
        public static void Section3()
        {
            SeleniumSetMethod.Click("id", "section3Heading");
            
        }
        public static void accordianRunner()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)(PropertiesS.driver);
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[1]");
            PropertiesS.Sleep(2000);
            Section1();
            PropertiesS.Sleep(2000);
            Section2(js);
            PropertiesS.Sleep(2000);
            Section3();
        }
    }
    class datePicker
    {
        public static void SelectDate()
        {
            SeleniumSetMethod.Click("id", "datePickerMonthYearInput");
            
        }
        public static void SelectYear()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--select']");
           
        }
        public static void PickYear()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__month-dropdown-container react-datepicker__month-dropdown-container--select']");
            
        }
        public static void SelectMonth()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__year-select']//child::option[96]");
            
        }
        public static void PickMonth()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__month-select']//child::option[6]");
           
        }
        public static void PickDay()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__week'][4]//child::div[4]");
           
        }

        public static void DateAndTimePickerInput()
        {
            SeleniumSetMethod.Click("id", "dateAndTimePickerInput");
            
        }

        public static void SelectYearDateTime()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'react-datepicker__year-read-view']");
          
        }

        public static void PickYearDateTime()
        {
            PropertiesS.driver.FindElement
                  (By.XPath
                  ("//*[@class = 'react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--scroll']" +
                  "//child::div[@class = 'react-datepicker__year-option'][10]"))
                .Click();
        }
        public static void PickTIme()
        {
            PropertiesS.driver.FindElement
                  (By.XPath("//*[@class = 'react-datepicker__time-box']//child::li[10]")).Click();
        }
        public static void dateTimeRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[3]");
            PropertiesS.Sleep(2000);
            SelectDate();
            PropertiesS.Sleep(2000);
            SelectYear();
            PropertiesS.Sleep(2000);
            PickYear();
            PropertiesS.Sleep(2000);
            SelectMonth();
            PropertiesS.Sleep(2000);
            PickMonth();
            PropertiesS.Sleep(2000);
            PickDay();
            PropertiesS.Sleep(2000);
            DateAndTimePickerInput();
            PropertiesS.Sleep(2000);
            SelectYearDateTime();
            PropertiesS.Sleep(2000);
            PickTIme();

        }
    }
    class slider
    {
        public static void ClickSlider()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'range-slider range-slider--primary']");
           
        }
        public static void MoveSlider(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                SeleniumSetMethod.SendKeys("Xpath", "//*[@class = 'range-slider range-slider--primary']", Keys.ArrowRight);
                
            }
        }
        public static void sliderRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[4]");
            PropertiesS.Sleep(2000);
            ClickSlider();
            PropertiesS.Sleep(2000);
            MoveSlider(40);
        }
    }
    class progressBar
    {
        public static void StartProgressBar()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@id= 'startStopButton']");
           
        }
        public static void StopProgressBar()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@id= 'startStopButton']");
            
        }
        public static void progessRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[5]");
            PropertiesS.Sleep(2000);
            StartProgressBar();
            PropertiesS.Sleep(5000);
            StartProgressBar();
        }
    }
    class tabs
    {
        public static void OriginTab()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@id= 'demo-tab-origin']");
           
        }
        public static void UseTab()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@id= 'demo-tab-use']");
           
        }
        public static void WhatTab()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@id= 'demo-tab-what']");
            
        }
        public static void tabRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[6]");
            PropertiesS.Sleep(2000);
            OriginTab();
            PropertiesS.Sleep(2000);
            UseTab();
            PropertiesS.Sleep(2000);
            WhatTab();
        }
    }
    class tooltip
    {
        
        public static void HoverButton(String javaScript)
        {
            IJavaScriptExecutor executor = PropertiesS.driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, PropertiesS.driver.FindElement
                (By.XPath("//*[@id= 'toolTipButton']")));
        }
        public static void HoverTextField(String javaScript)
        {
            IJavaScriptExecutor executor = PropertiesS.driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, PropertiesS.driver.FindElement
                (By.XPath("//*[@id= 'toolTipTextField']")));
        }
        public static void HoverText(String javaScript)
        {
            IJavaScriptExecutor executor = PropertiesS.driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, PropertiesS.driver.FindElement
                (By.XPath("//*[@id= 'texToolTopContainer']//child::a[1]")));
        }
        public static void HoverText2(String javaScript)
        {
            IJavaScriptExecutor executor = PropertiesS.driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, PropertiesS.driver.FindElement
                (By.XPath("//*[@id= 'texToolTopContainer']//child::a[2]")));
        }
        public static void tooltipRunner(IJavaScriptExecutor js)
        {
            String javaScript = "var evObj = document.createEvent('MouseEvents');" +
                 "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, " +
                 "false, false, false, false, 0, null);" +
                 "arguments[0].dispatchEvent(evObj);";

            js.ExecuteScript("window.scrollBy(0,500)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[7]");            
            PropertiesS.Sleep(2000);
            HoverButton(javaScript);
            PropertiesS.Sleep(2000);
            HoverTextField(javaScript);
            js.ExecuteScript("window.scrollBy(0,100)");
            PropertiesS.Sleep(2000);
            HoverText(javaScript);
            js.ExecuteScript("window.scrollBy(0,100)");
            PropertiesS.Sleep(2000);
            HoverText2(javaScript);

        }
    }
    class menu
    {
        public static void MainItem1()
        {
            SeleniumSetMethod.Click("LinkText", "Main Item 1");

        }
        public static void MainItem2()
        {
            SeleniumSetMethod.Click("LinkText", "Main Item 2");
            
        }
        public static void SubList()
        {
            SeleniumSetMethod.Click("Xpath", "//*[text() = 'SUB SUB LIST »']");
            
        }
        public static void SubItem2()
        {
            SeleniumSetMethod.Click("Xpath", "//*[text() = 'SUB SUB LIST »']");
            
        }
        public static void MainItem3()
        {
            SeleniumSetMethod.Click("LinkText", "Main Item 3");

        }
        public static void menuRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,800)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][4]//child::li[8]");
            PropertiesS.Sleep(2000);
            MainItem1();
            PropertiesS.Sleep(2000);
            MainItem2();
            PropertiesS.Sleep(2000);
            SubList();
            PropertiesS.Sleep(2000);
            SubItem2();
            PropertiesS.Sleep(2000);
            MainItem3();
        }
    }
     class widgets
    {
        public static void widgetRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            //accordian.accordianRunner();
            //datePicker.dateTimeRunner(js);
            //slider.sliderRunner(js);
            //progressBar.progessRunner(js);
            //tabs.tabRunner(js);
            //tooltip.tooltipRunner(js);
            menu.menuRunner(js);

        }
    }
}
