using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
    
        
        class textBox
        {
            public static void FullName(string fullName)
            {
                SeleniumSetMethod.SendKeys("id", "userName", fullName);
            }

            public static void Email(string email)
            {
                SeleniumSetMethod.SendKeys("id", "userEmail", email);

            }

            public static void CurrentAddress(string currentAddress)
            {
                SeleniumSetMethod.SendKeys("id", "currentAddress", currentAddress);

            }

            public static void PermanentAddress(string permanentAddress)
            {
                SeleniumSetMethod.SendKeys("id", "permanentAddress", permanentAddress);

            }

            public static void SubmitButton()
            {
            PropertiesS.VScroll(300);            
                SeleniumSetMethod.Click("Xpath", "//button[@class='btn btn-primary']");
            }
            public static void textboxRunner()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[1]");
                PropertiesS.Sleep(2000);
                FullName("Charls");
                PropertiesS.Sleep(500);
                Email("c@gmail.com");
                PropertiesS.Sleep(500);
                PermanentAddress("Kolakta");
                PropertiesS.Sleep(500);
                CurrentAddress("Delhi");
                PropertiesS.Sleep(500);
                SubmitButton();
                PropertiesS.VScroll(200);
            }
        }
        class checkBox
        {
            public static void ToggleHome()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@aria-label='Toggle']");
                
            }
            public static void ToggleDownloads()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@id='tree-node']//descendant::button[@aria-label='Toggle'][4]");
                
            }
            public static void CheckBoxDownloads()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@id='tree-node']//descendant::span[@class='rct-checkbox'][4]");                
            }

            public static void CollapseAll()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@aria-label='Collapse all']");                
            }
            public static void checkBoxRunner()
            {
            
            PropertiesS.VScroll(300);
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[2]");
                PropertiesS.Sleep(2000);
                ToggleHome();
                PropertiesS.Sleep(2000);
                ToggleDownloads();
                PropertiesS.Sleep(2000);
                CheckBoxDownloads();
                PropertiesS.Sleep(2000);
                CollapseAll();
            }
        }
        class radioButton
        {
           
            public static void PressYesButton()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class='custom-control custom-radio custom-control-inline'][1]");
                
            }
            public static void PressImpressiveButton()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class='custom-control custom-radio custom-control-inline'][2]");

            }
            public static void radioButtonRunner()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[3]");
                PropertiesS.Sleep(2000);
                PressYesButton();
                PropertiesS.Sleep(2000);
                PressImpressiveButton();
            }
        }
       
        class webTables
        {
            public static void AddNewRecordButton()
            {
                SeleniumSetMethod.Click("id", "addNewRecordButton");                
            }
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
            public static void Age(string age)
            {
                SeleniumSetMethod.SendKeys("id", "age", age);
                
            }
            public static void Salary(string salary)
            {
                SeleniumSetMethod.SendKeys("id", "salary", salary);
                
            }
            public static void Department(string department)
            {
                SeleniumSetMethod.SendKeys("id", "department", department);
                
            }
            public static void SubmitBtn()
            {
                SeleniumSetMethod.Click("id", "submit");                
            }
            public static void add10Records()
            {
                string[] firstName = { "Charles","Robert","Anderson","David","Frank","Martin","Dean","Green","Chris","Palmer"};
                string[] lastName = { "SurCharles", "SurRobert", "SurAnderson", "SurDavid", "SurFrank", "SurMartin", "SurDean", "SurGreen", "SurChris", "SurPalmer" };
                string[] email = {"a@gmail.com", "b@gmail.com", "c@gmail.com", "d@gmail.com", "e@gmail.com", "f@gmail.com", "g@gmail.com", "h@gmail.com", "i@gmail.com", "j@gmail.com", };
                string[] age = {"20","25","23", "27", "18", "30", "32", "38", "21", "16", };
                string[] sal = {"2000","2500","2300", "2700", "1800", "3000", "3200", "3800", "2100", "1600", };
                string[] dept = { "phy", "chem", "cs", "ca", "math", "bios", "pols", "polity", "goe", "hist", };
               for(int i = 0; i < 10; i++)
                {
                    PropertiesS.Sleep(2000);
                    AddNewRecordButton();
                    PropertiesS.Sleep(1000);
                    FirstName(firstName[i]);
                    PropertiesS.Sleep(1000);
                    LastName(lastName[i]);
                    PropertiesS.Sleep(1000);
                    Email(email[i]);
                    PropertiesS.Sleep(1000);
                    Age(age[i]);
                    PropertiesS.Sleep(1000);
                    Salary(sal[i]);
                    PropertiesS.Sleep(1000);
                    Department(dept[i]);
                    PropertiesS.Sleep(1000);
                    SubmitBtn();
                }
            PropertiesS.VScroll(700);            
                PropertiesS.Sleep(2000);
                SeleniumSetMethod.Click("Xpath", "//button[text()='Next']");
                PropertiesS.Sleep(2000);
                SeleniumSetMethod.Click("Xpath", "//button[text()='Previous']");
            }
            public static void DeleteRecord()
            {
                SeleniumSetMethod.Click("id", "delete-record-1");                
            }

            public static void SearchBox(string searchBox)
            {
                SeleniumSetMethod.SendKeys("id", "searchBox", searchBox);                
            }

            public static void EditRecord()
            {
                SeleniumSetMethod.Click("id", "edit-record-4");               
            }

            public static void ClearSalary()
            {
                SeleniumSetMethod.Clear("id", "salary");                
            }

            public static void EditSalary(string salary)
            {
                SeleniumSetMethod.SendKeys("id", "salary",salary);                
            }

            public static void SubmitBtnEdit()
            {
                SeleniumSetMethod.Click("id", "submit");               
            }
            public static void EditArecord()
            {
                EditRecord();
                PropertiesS.Sleep(2000);
                ClearSalary();
                PropertiesS.Sleep(2000);
                EditSalary("3000");
                PropertiesS.Sleep(2000);
                SubmitBtnEdit();
            }
            public static void webtableRunner()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[4]");
                PropertiesS.Sleep(2000);
                add10Records();
                PropertiesS.Sleep(2000);
                SearchBox("Vega");
                PropertiesS.Sleep(2000);
                EditArecord();
                PropertiesS.Sleep(2000);
                DeleteRecord();
            }
        }
        class button
        {
            public static void doubleClick()
            {
            PropertiesS.VScroll(50);
            
                Actions action = new Actions(PropertiesS.driver);
                action.MoveToElement(PropertiesS.driver.FindElement(By.XPath("//button[@id='doubleClickBtn']")))
                    .DoubleClick().Build().Perform();
                
            PropertiesS.VScroll(150);
            PropertiesS.Sleep(2000);
            }
            public static void rightClick()
            {
            PropertiesS.VScroll(50);
            
                Actions action = new Actions(PropertiesS.driver);
                action.MoveToElement(PropertiesS.driver.FindElement(By.XPath("//button[@id='rightClickBtn']")))
                    .ContextClick().Build().Perform();
            PropertiesS.VScroll(150);
            PropertiesS.Sleep(5000);
            }
            public static void dynamicClick()
            {
            PropertiesS.VScroll(200);
            
                Actions action = new Actions(PropertiesS.driver);
                action.MoveToElement(PropertiesS.driver.FindElement(By.XPath("//button[text()='Click Me']")))
                    .Click().Build().Perform();
            PropertiesS.VScroll(150);
            
                PropertiesS.Sleep(3000);
            }
            public static void buttonRunner()
            {
            PropertiesS.VScroll(150);
            
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[5]");
                PropertiesS.Sleep(3000);
                doubleClick();
                PropertiesS.Sleep(2000);
                rightClick();
                PropertiesS.Sleep(2000);
                dynamicClick();
            PropertiesS.VScroll(200);
            
        }
        }
        #region Links
        class links
        {
            public static void openNew(IJavaScriptExecutor js)
            {
            PropertiesS.VScroll(500);
            
                SeleniumSetMethod.Click("id", "item-5");
                PropertiesS.Sleep(3000);
                SeleniumSetMethod.Click("id", "simpleLink");
                PropertiesS.Sleep(3000);                
                PropertiesS.driver.Navigate().GoToUrl("https://demoqa.com/links");
                PropertiesS.Sleep(2000);
                SeleniumSetMethod.Click("id", "dynamicLink");                
            }
            public static void callApi(IJavaScriptExecutor js)
            {
            PropertiesS.VScroll(500);
            
                
                SeleniumSetMethod.Click("Xpath", "//a[@id='created']");
               
                PropertiesS.Sleep(2000);
            PropertiesS.VScroll(200);
            
                SeleniumSetMethod.Click("Xpath", "//a[@id='no-content']");
                
                PropertiesS.Sleep(2000);
            PropertiesS.VScroll(200);
            SeleniumSetMethod.Click("Xpath", "//a[@id='moved']");
                
                PropertiesS.Sleep(2000);
            PropertiesS.VScroll(200);
            SeleniumSetMethod.Click("Xpath", "//a[@id='bad-request']");
                
                PropertiesS.Sleep(2000);
            PropertiesS.VScroll(200);
            SeleniumSetMethod.Click("Xpath", "//a[@id='unauthorized']");
                
                PropertiesS.Sleep(2000);
            PropertiesS.VScroll(200);
            SeleniumSetMethod.Click("Xpath", "//a[@id='forbidden']");
                
                PropertiesS.Sleep(2000);
            PropertiesS.VScroll(200);
            SeleniumSetMethod.Click("Xpath", "//a[@id='invalid-url']");
              
                PropertiesS.Sleep(2000);
            }
                public static void linksRunner(IJavaScriptExecutor js)
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[6]");
                PropertiesS.Sleep(3000);
                openNew(js);
                PropertiesS.Sleep(5000);
                callApi(js);

            }
        }
        #endregion
        class brokenLinks
        {
            public static void ValidLink()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class='col-12 mt-4 col-md-6']//child::div[a]//child::a[1]");                
            }
            public static void BrokenLink()
            {
                SeleniumSetMethod.Click("Xpath", "//*[@class='col-12 mt-4 col-md-6']//child::div[a]//child::a[2]");                
            }
            public static void brokenLinksRunner(IJavaScriptExecutor js)
            {
            PropertiesS.VScroll(300);
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[7]");
                ValidLink();
                PropertiesS.Sleep(2000);
                BrokenLink();
            }
        }
        class upLoad_dnload
        {
            public static void download()
            {
                try
                {
                PropertiesS.VScroll(500);
                
                    SeleniumSetMethod.Click("Xpath", "//a[@id='downloadButton']");
                    PropertiesS.Sleep(2000);
                    ChromeOptions opt = new ChromeOptions();
                    opt.AddUserProfilePreference("download.default_directory", @"C:\Users\SAIKAT\Downloads");
                    PropertiesS.driver = new ChromeDriver(@"C:\Users\SAIKAT\Downloads", opt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The Error is" + e.ToString());
                }
            }
            public static void upload()
            {
            PropertiesS.VScroll(500);
            
                SeleniumSetMethod.SendKeys("Xpath", "//input[@type='file']", "E:\\5thSem_admitcard.pdf");
                PropertiesS.Sleep(3000);
                
            }
            public static void upLoad_dnloadRunner()
            {
            PropertiesS.VScroll(400);
            
                SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[8]");
                PropertiesS.Sleep(2000);
                download();
                PropertiesS.Sleep(7000);
                upload();
            }
        }
        class dynamicProp
        {
            public static void EnableBtn()
            {
                SeleniumSetMethod.Click("id", "enableAfter");                
            }
            public static void ChangeColorBtn()
            {
                SeleniumSetMethod.Click("id", "colorChange");                
            }
            public static void VisibleAfterBtn()
            {
                SeleniumSetMethod.Click("id", "visibleAfter");                
            }
            public static void dynamicPropRunner()
            {
            PropertiesS.VScroll(300);
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][1]//child::li[9]");
                PropertiesS.Sleep(2000);
                EnableBtn();
                PropertiesS.Sleep(5000);
            PropertiesS.VScroll(200);
            ChangeColorBtn();
                PropertiesS.Sleep(7000);
                VisibleAfterBtn();
                PropertiesS.Sleep(7000);
        }
        }
    class Elements
    {
        public static void elementsRunner()
        {
            textBox.textboxRunner();
            PropertiesS.Sleep(10000);
            checkBox.checkBoxRunner();
            PropertiesS.Sleep(10000);
            radioButton.radioButtonRunner();
            PropertiesS.Sleep(10000);
            PropertiesS.VScroll(200);
            
            webTables.webtableRunner();
            PropertiesS.Sleep(10000);
            PropertiesS.VScroll(200);
            
            button.buttonRunner();
            PropertiesS.Sleep(10000);
            //links.linksRunner(js);
            PropertiesS.Sleep(10000);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //brokenLinks.BrokenLink();
            PropertiesS.Sleep(10000);
            PropertiesS.VScroll(200);
            
            upLoad_dnload.upLoad_dnloadRunner();
            PropertiesS.Sleep(10000);
            PropertiesS.VScroll(200);
            
            dynamicProp.dynamicPropRunner();
            
        }
    }
}
