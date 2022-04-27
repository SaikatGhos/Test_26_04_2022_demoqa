using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
     class SeleniumSetMethod
    {
        public static void SendKeys(string elementType, string element, string value)
        {
            if (elementType == "id")
                PropertiesS.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                PropertiesS.driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "Class")
                PropertiesS.driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementType == "Xpath")
                PropertiesS.driver.FindElement(By.XPath(element)).SendKeys(value);
        }
        public static void Click(string elementType, string element)
        {
            if (elementType == "id")
                PropertiesS.driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                PropertiesS.driver.FindElement(By.Name(element)).Click();
            if (elementType == "Class")
                PropertiesS.driver.FindElement(By.ClassName(element)).Click();
            if (elementType == "Xpath")
                PropertiesS.driver.FindElement(By.XPath(element)).Click();
            if (elementType == "LinkText")
                PropertiesS.driver.FindElement(By.LinkText(element)).Click();
        }
        public static void Clear(string elementType, string element)
        {
            if (elementType == "id")
                PropertiesS.driver.FindElement(By.Id(element)).Clear();
            if (elementType == "Name")
                PropertiesS.driver.FindElement(By.Name(element)).Clear();
            if (elementType == "Class")
                PropertiesS.driver.FindElement(By.ClassName(element)).Clear();
            if (elementType == "Xpath")
                PropertiesS.driver.FindElement(By.XPath(element)).Clear();
        }
        public static void DropDown(string elementType, string element)
        {
            if (elementType == "Xpath")
                new SelectElement(PropertiesS.driver.FindElement(By.XPath(element)));            
        }
    }
}
