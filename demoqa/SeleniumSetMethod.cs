using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
     class SeleniumSetMethod : PropertiesS
    {
        public static void SendKeys(PropertyType elementType, string element, string value)
        {
            if (elementType == PropertyType.Id)
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == PropertyType.Class)
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementType == PropertyType.Xpath)
                driver.FindElement(By.XPath(element)).SendKeys(value);
        }
        public static void Click(PropertyType elementType, string element)
        {
            if (elementType == PropertyType.Id)
                driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                driver.FindElement(By.Name(element)).Click();
            if (elementType == PropertyType.Class)
                driver.FindElement(By.ClassName(element)).Click();
            if (elementType == PropertyType.Xpath)
                driver.FindElement(By.XPath(element)).Click();
            if (elementType == PropertyType.LinkText)
                driver.FindElement(By.LinkText(element)).Click();
        }
        public static void Clear(PropertyType elementType, string element)
        {
            if (elementType == PropertyType.Id)
                driver.FindElement(By.Id(element)).Clear();
            if (elementType == PropertyType.Name)
                driver.FindElement(By.Name(element)).Clear();
            if (elementType == PropertyType.Class)
                driver.FindElement(By.ClassName(element)).Clear();
            if (elementType == PropertyType.Xpath)
                driver.FindElement(By.XPath(element)).Clear();
        }
        public static void DropDown(PropertyType elementType, string element)
        {
            if (elementType == PropertyType.Xpath)
                new SelectElement(driver.FindElement(By.XPath(element)));            
        }
    }
}
