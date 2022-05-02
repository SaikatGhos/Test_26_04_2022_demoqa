using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
    class accordian:SeleniumSetMethod
    {

        public static void Section1()
        {
            Click(PropertyType.Id, "section1Heading");
        }
        public static void Section2()
        {
            VScroll(200);
            Click(PropertyType.Id, "section2Heading");
        }
        public static void Section3()
        {
            Click(PropertyType.Id, "section3Heading");

        }
        public static void accordianRunner()
        {

            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[1]");
            Sleep(2000);
            Section1();
            Sleep(2000);
            Section2();
            Sleep(2000);
            Section3();
        }
    }
    class datePicker : SeleniumSetMethod
    {
        public static void SelectDate()
        {
            Click(PropertyType.Id, "datePickerMonthYearInput");

        }
        public static void SelectYear()
        {
            Click(PropertyType.Xpath, "//*[@class='react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--select']");

        }
        public static void PickYear()
        {
            Click(PropertyType.Xpath, "//*[@class='react-datepicker__month-dropdown-container react-datepicker__month-dropdown-container--select']");

        }
        public static void SelectMonth()
        {
            Click(PropertyType.Xpath, "//*[@class='react-datepicker__year-select']//child::option[96]");

        }
        public static void PickMonth()
        {
            Click(PropertyType.Xpath, "//*[@class='react-datepicker__month-select']//child::option[6]");

        }
        public static void PickDay()
        {
            Click(PropertyType.Xpath, "//*[@class='react-datepicker__week'][4]//child::div[4]");

        }

        public static void DateAndTimePickerInput()
        {
            Click(PropertyType.Id, "dateAndTimePickerInput");

        }

        public static void SelectYearDateTime()
        {
            Click(PropertyType.Xpath, "//*[@class = 'react-datepicker__year-read-view']");

        }

        public static void PickYearDateTime()
        {
            driver.FindElement
                  (By.XPath
                  ("//*[@class = 'react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--scroll']" +
                  "//child::div[@class = 'react-datepicker__year-option'][10]"))
                .Click();
        }
        public static void PickTIme()
        {
            driver.FindElement
                  (By.XPath("//*[@class = 'react-datepicker__time-box']//child::li[10]")).Click();
        }
        public static void dateTimeRunner()
        {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[3]");
            Sleep(2000);
            SelectDate();
            Sleep(2000);
            SelectYear();
            Sleep(2000);
            PickYear();
            Sleep(2000);
            SelectMonth();
            Sleep(2000);
            PickMonth();
            Sleep(2000);
            PickDay();
            Sleep(2000);
            DateAndTimePickerInput();
            Sleep(2000);
            SelectYearDateTime();
            Sleep(2000);
            PickTIme();

        }
    }
    class slider : SeleniumSetMethod
    {
        public static void ClickSlider()
        {
            Click(PropertyType.Xpath, "//*[@class = 'range-slider range-slider--primary']");

        }
        public static void MoveSlider(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                SendKeys(PropertyType.Xpath, "//*[@class = 'range-slider range-slider--primary']", Keys.ArrowRight);

            }
        }
        public static void sliderRunner()
        {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[4]");
            Sleep(2000);
            ClickSlider();
            Sleep(2000);
            MoveSlider(40);
        }
    }
    class progressBar : SeleniumSetMethod
    {
        public static void StartProgressBar()
        {
            Click(PropertyType.Xpath, "//*[@id= 'startStopButton']");

        }
        public static void StopProgressBar()
        {
            Click(PropertyType.Xpath, "//*[@id= 'startStopButton']");

        }
        public static void progessRunner()
        {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[5]");
            Sleep(2000);
            StartProgressBar();
            Sleep(5000);
            StartProgressBar();
        }
    }
    class tabs : SeleniumSetMethod
    {
        public static void OriginTab()
        {
            Click(PropertyType.Xpath, "//*[@id= 'demo-tab-origin']");

        }
        public static void UseTab()
        {
            Click(PropertyType.Xpath, "//*[@id= 'demo-tab-use']");

        }
        public static void WhatTab()
        {
            Click(PropertyType.Xpath, "//*[@id= 'demo-tab-what']");

        }
        public static void tabRunner(IJavaScriptExecutor js)
        {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[6]");
            Sleep(2000);
            OriginTab();
            Sleep(2000);
            UseTab();
            Sleep(2000);
            WhatTab();
        }
    }
    class tooltip : SeleniumSetMethod
    {

        public static void HoverButton(String javaScript)
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, driver.FindElement
                (By.XPath("//*[@id= 'toolTipButton']")));
        }
        public static void HoverTextField(String javaScript)
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, driver.FindElement
                (By.XPath("//*[@id= 'toolTipTextField']")));
        }
        public static void HoverText(String javaScript)
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, driver.FindElement
                (By.XPath("//*[@id= 'texToolTopContainer']//child::a[1]")));
        }
        public static void HoverText2(String javaScript)
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, driver.FindElement
                (By.XPath("//*[@id= 'texToolTopContainer']//child::a[2]")));
        }
        public static void tooltipRunner()
        {
            String javaScript = "var evObj = document.createEvent('MouseEvents');" +
                 "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, " +
                 "false, false, false, false, 0, null);" +
                 "arguments[0].dispatchEvent(evObj);";

            VScroll(500);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[7]");
            Sleep(2000);
            HoverButton(javaScript);
            Sleep(2000);
            HoverTextField(javaScript);
            VScroll(100);
            Sleep(2000);
            HoverText(javaScript);
            VScroll(100);
            Sleep(2000);
            HoverText2(javaScript);

        }
    }
    class menu : SeleniumSetMethod
    {
        public static void MainItem1()
        {
            Click(PropertyType.LinkText, "Main Item 1");

        }
        public static void MainItem2()
        {
            Click(PropertyType.LinkText, "Main Item 2");

        }
        public static void SubList()
        {
            Click(PropertyType.Xpath, "//*[text() = 'SUB SUB LIST »']");

        }
        public static void SubItem2()
        {
            Click(PropertyType.Xpath, "//*[text() = 'SUB SUB LIST »']");

        }
        public static void MainItem3()
        {
            Click(PropertyType.LinkText, "Main Item 3");

        }
        public static void menuRunner()
        {
            VScroll(800);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][4]//child::li[8]");
            Sleep(2000);
            MainItem1();
            Sleep(2000);
            MainItem2();
            Sleep(2000);
            SubList();
            Sleep(2000);
            SubItem2();
            Sleep(2000);
            MainItem3();
        }
    }
    class widgets : SeleniumSetMethod
    {
        public static void widgetRunner()
        {
            VScroll(200);
            //accordian.accordianRunner();
            datePicker.dateTimeRunner();
            slider.sliderRunner();
            progressBar.progessRunner();
            //tabs.tabRunner(js);
            tooltip.tooltipRunner();
            menu.menuRunner();

        }
    }
}
