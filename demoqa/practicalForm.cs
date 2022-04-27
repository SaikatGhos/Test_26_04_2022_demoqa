using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
    class form
    {
        public static void FirstName(string firstName)
        {
            SeleniumSetMethod.SendKeys("id", "firstName", firstName);
            
        }
        public static void LastName(string lastName)
        {
            SeleniumSetMethod.SendKeys("id", "lastName", lastName);            
        }
        public static void Email(string email)
        {
            SeleniumSetMethod.SendKeys("id", "userEmail", email);            
        }
        public static void PressMaleButton()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='custom-control custom-radio custom-control-inline'][1]");            
        }
        public static void MobileNumber(string number)
        {
            SeleniumSetMethod.SendKeys("id", "userNumber", number);            
        }
        public static void DateOfBirth()
        {
            SeleniumSetMethod.Click("id", "dateOfBirthInput");            
        }
        public static void YearOfBirth()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--select']");            
        }
        public static void PickYear()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__year-select']//child::option[96]");           
        }
        public static void MonthOfBirth()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__month-dropdown-container react-datepicker__month-dropdown-container--select']");            
        }
        public static void PickMonth()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__month-select']//child::option[6]");
            
        }
        public static void PickDay()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class='react-datepicker__week'][4]//child::div[4]");            
        }

        /* public void Subject(string subject)
         {
             wait.Until(ExpectedConditions.ElementIsVisible(By.Id("subjectsContainer"))).SendKeys(subject);
         }
         public void SubjectEnter()
         {
             wait.Until(ExpectedConditions.ElementIsVisible(By.Id("subjectsContainer"))).SendKeys(Keys.Enter);
         }*/
        public static void Hobbies()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'custom-control custom-checkbox custom-control-inline']//descendant::label[1]");            
        }
        public static void SubmitBtn()
        {
            SeleniumSetMethod.Click("Xpath", "//*[@id= 'submit']");            
        }
        public static void fromBuilder(IJavaScriptExecutor js)
        {
            FirstName("Charlie");
            PropertiesS.Sleep(1000);
            LastName("Mess");
            PropertiesS.Sleep(1000);
            Email("c@gmail.com");
            PropertiesS.Sleep(1000);
            PressMaleButton();
            PropertiesS.Sleep(1000);
            MobileNumber("9574124578");
            PropertiesS.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300)");
            DateOfBirth();
            PropertiesS.Sleep(1000);
            YearOfBirth();
            PropertiesS.Sleep(1000);
            PickYear();
            PropertiesS.Sleep(1000);
            MonthOfBirth();
            PropertiesS.Sleep(1000);
            PickMonth();
            PropertiesS.Sleep(1000);
            PickDay();
            PropertiesS.Sleep(1000);
            Hobbies();
            PropertiesS.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300)");
            SubmitBtn();
        }
        public static void formRunner(IJavaScriptExecutor js)
        {
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][2]//child::li[1]");
            PropertiesS.Sleep(2000);
            fromBuilder(js);
        }
    }
    class practicalForm
    {
        public static void practicalformRunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,500)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][2]");
            PropertiesS.Sleep(2000);            
            form.formRunner(js);
        }
    }
}
