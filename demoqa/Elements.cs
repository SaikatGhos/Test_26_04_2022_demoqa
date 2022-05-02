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
    
        
        class textBox :SeleniumSetMethod
        {
            public static void FullName(string fullName)
            {
                SendKeys(PropertyType.Id, "userName", fullName);
            }

            public static void Email(string email)
            {
                SendKeys(PropertyType.Id, "userEmail", email);
            }

            public static void CurrentAddress(string currentAddress)
            {
                SendKeys(PropertyType.Id, "currentAddress", currentAddress);

            }

            public static void PermanentAddress(string permanentAddress)
            {
                SendKeys(PropertyType.Id, "permanentAddress", permanentAddress);
            }

            public static void SubmitButton()
            {
            VScroll(300);            
            Click(PropertyType.Xpath, "//button[@class='btn btn-primary']");
            }
            public static void textboxRunner()
            {
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[1]");
                Sleep(2000);
                FullName("Charls");
                Sleep(500);
                Email("c@gmail.com");
                Sleep(500);
                PermanentAddress("Kolakta");
                Sleep(500);
                CurrentAddress("Delhi");
                Sleep(500);
                SubmitButton();
                VScroll(200);
            }
        }
        class checkBox:SeleniumSetMethod
        {
            public static void ToggleHome()
            {
                Click(PropertyType.Xpath, "//*[@aria-label='Toggle']");
                
            }
            public static void ToggleDownloads()
            {
                Click(PropertyType.Xpath, "//*[@id='tree-node']//descendant::button[@aria-label='Toggle'][4]");
                
            }
            public static void CheckBoxDownloads()
            {
                Click(PropertyType.Xpath, "//*[@id='tree-node']//descendant::span[@class='rct-checkbox'][4]");                
            }

            public static void CollapseAll()
            {
                Click(PropertyType.Xpath, "//*[@aria-label='Collapse all']");                
            }
            public static void checkBoxRunner()
            {
            
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[2]");
             Sleep(2000);
                ToggleHome();
             Sleep(2000);
                ToggleDownloads();
             Sleep(2000);
                CheckBoxDownloads();
             Sleep(2000);
                CollapseAll();
            }
        }
        class radioButton:SeleniumSetMethod
        {
           
            public static void PressYesButton()
            {
                Click(PropertyType.Xpath, "//*[@class='custom-control custom-radio custom-control-inline'][1]");
                
            }
            public static void PressImpressiveButton()
            {
                Click(PropertyType.Xpath, "//*[@class='custom-control custom-radio custom-control-inline'][2]");

            }
            public static void radioButtonRunner()
            {
                Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[3]");
                Sleep(2000);
                PressYesButton();
                Sleep(2000);
                PressImpressiveButton();
            }
        }
       
        class webTables:SeleniumSetMethod
        {
            public static void AddNewRecordButton()
            {
                Click(PropertyType.Id, "addNewRecordButton");                
            }
            public static void FirstName(string firstName)
            {
                SendKeys(PropertyType.Id, "firstName", firstName);                
            }
            public static void LastName(string lastName)
            {
                SendKeys(PropertyType.Id, "lastName", lastName);
                
            }
            public static void Email(string email)
            {
               SendKeys(PropertyType.Id, "userEmail", email);
                
            }
            public static void Age(string age)
            {
                SendKeys(PropertyType.Id, "age", age);
                
            }
            public static void Salary(string salary)
            {
                SendKeys(PropertyType.Id, "salary", salary);
                
            }
            public static void Department(string department)
            {
                SendKeys(PropertyType.Id, "department", department);
                
            }
            public static void SubmitBtn()
            {
                Click(PropertyType.Id, "submit");                
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
                    Sleep(2000);
                    AddNewRecordButton();
                    Sleep(1000);
                    FirstName(firstName[i]);
                    Sleep(1000);
                    LastName(lastName[i]);
                    Sleep(1000);
                    Email(email[i]);
                    Sleep(1000);
                    Age(age[i]);
                    Sleep(1000);
                    Salary(sal[i]);
                    Sleep(1000);
                    Department(dept[i]);
                    Sleep(1000);
                    SubmitBtn();
                }
            VScroll(700);            
                Sleep(2000);
                Click(PropertyType.Xpath, "//button[text()='Next']");
                Sleep(2000);
               Click(PropertyType.Xpath, "//button[text()='Previous']");
            }
            public static void DeleteRecord()
            {
                Click(PropertyType.Id, "delete-record-1");                
            }

            public static void SearchBox(string searchBox)
            {
                SendKeys(PropertyType.Id, "searchBox", searchBox);                
            }

            public static void EditRecord()
            {
                Click(PropertyType.Id, "edit-record-4");               
            }

            public static void ClearSalary()
            {
                Clear(PropertyType.Id, "salary");                
            }

            public static void EditSalary(string salary)
            {
                SendKeys(PropertyType.Id, "salary",salary);                
            }

            public static void SubmitBtnEdit()
            {
                Click(PropertyType.Id, "submit");               
            }
            public static void EditArecord()
            {
                EditRecord();
                Sleep(2000);
                ClearSalary();
                Sleep(2000);
                EditSalary("3000");
                Sleep(2000);
                SubmitBtnEdit();
            }
            public static void webtableRunner()
            {
                Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[4]");
                Sleep(2000);
                add10Records();
                Sleep(2000);
                SearchBox("Vega");
                Sleep(2000);
                EditArecord();
                Sleep(2000);
                DeleteRecord();
            }
        }
        class button:SeleniumSetMethod
        {
            public static void doubleClick()
            {
            VScroll(50);
            
                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(By.XPath("//button[@id='doubleClickBtn']")))
                    .DoubleClick().Build().Perform();
                
            VScroll(150);
            Sleep(2000);
            }
            public static void rightClick()
            {
            VScroll(50);
            
                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(By.XPath("//button[@id='rightClickBtn']")))
                    .ContextClick().Build().Perform();
           VScroll(150);
            Sleep(5000);
            }
            public static void dynamicClick()
            {
            VScroll(200);
            
                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(By.XPath("//button[text()='Click Me']")))
                    .Click().Build().Perform();
            VScroll(150);
            
                Sleep(3000);
            }
            public static void buttonRunner()
            {
            VScroll(150);
            
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[5]");
                Sleep(3000);
                doubleClick();
                Sleep(2000);
                rightClick();
                Sleep(2000);
                dynamicClick();
            VScroll(200);
            
        }
        }
        #region Links
        class links:SeleniumSetMethod
        {
            public static void openNew()
            {
            VScroll(500);
            
                Click(PropertyType.Id, "item-5");
                Sleep(3000);
                Click(PropertyType.Id, "simpleLink");
                Sleep(3000);                
                driver.Navigate().GoToUrl("https://demoqa.com/links");
                Sleep(2000);
                Click(PropertyType.Id, "dynamicLink");                
            }
            public static void callApi()
            {
            VScroll(500);
            
                
                Click(PropertyType.Xpath, "//a[@id='created']");
               
                Sleep(2000);
            VScroll(200);
            
                Click(PropertyType.Xpath, "//a[@id='no-content']");
                
                Sleep(2000);
            VScroll(200);
            Click(PropertyType.Xpath, "//a[@id='moved']");
                
                Sleep(2000);
            VScroll(200);
            Click(PropertyType.Xpath, "//a[@id='bad-request']");
                
                Sleep(2000);
            VScroll(200);
            Click(PropertyType.Xpath, "//a[@id='unauthorized']");
                
                Sleep(2000);
            VScroll(200);
            Click(PropertyType.Xpath, "//a[@id='forbidden']");
                
                Sleep(2000);
            VScroll(200);
            Click(PropertyType.Xpath, "//a[@id='invalid-url']");
              
                Sleep(2000);
            }
                public static void linksRunner()
            {
                Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[6]");
                Sleep(3000);
                openNew();
                Sleep(5000);
                callApi();

            }
        }
        #endregion
        class brokenLinks:SeleniumSetMethod
        {
            public static void ValidLink()
            {
                Click(PropertyType.Xpath, "//*[@class='col-12 mt-4 col-md-6']//child::div[a]//child::a[1]");                
            }
            public static void BrokenLink()
            {
                Click(PropertyType.Xpath, "//*[@class='col-12 mt-4 col-md-6']//child::div[a]//child::a[2]");                
            }
            public static void brokenLinksRunner(IJavaScriptExecutor js)
            {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[7]");
                ValidLink();
                Sleep(2000);
                BrokenLink();
            }
        }
        class upLoad_dnload:SeleniumSetMethod
        {
            public static void download()
            {
                try
                {
                VScroll(500);
                
                    Click(PropertyType.Xpath, "//a[@id='downloadButton']");
                    Sleep(2000);
                    ChromeOptions opt = new ChromeOptions();
                    opt.AddUserProfilePreference("download.default_directory", @"C:\Users\SAIKAT\Downloads");
                    driver = new ChromeDriver(@"C:\Users\SAIKAT\Downloads", opt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The Error is" + e.ToString());
                }
            }
            public static void upload()
            {
            VScroll(500);
            
                SendKeys(PropertyType.Xpath, "//input[@type='file']", "E:\\5thSem_admitcard.pdf");
                Sleep(3000);
                
            }
            public static void upLoad_dnloadRunner()
            {
            VScroll(400);
            
                Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[8]");
                Sleep(2000);
                download();
                Sleep(7000);
                upload();
            }
        }
        class dynamicProp:SeleniumSetMethod
        {
            public static void EnableBtn()
            {
                Click(PropertyType.Id, "enableAfter");                
            }
            public static void ChangeColorBtn()
            {
                Click(PropertyType.Id, "colorChange");                
            }
            public static void VisibleAfterBtn()
            {
                Click(PropertyType.Id, "visibleAfter");                
            }
            public static void dynamicPropRunner()
            {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][1]//child::li[9]");
                Sleep(2000);
                EnableBtn();
                Sleep(5000);
            VScroll(200);
            ChangeColorBtn();
                Sleep(7000);
                VisibleAfterBtn();
                Sleep(7000);
        }
        }
    class Elements:SeleniumSetMethod
    {
        public static void elementsRunner()
        {
            textBox.textboxRunner();
            Sleep(10000);
            checkBox.checkBoxRunner();
            Sleep(10000);
            radioButton.radioButtonRunner();
            Sleep(10000);
            VScroll(200);
            
            webTables.webtableRunner();
            Sleep(10000);
            VScroll(200);
            
            button.buttonRunner();
            Sleep(10000);
            //links.linksRunner(js);
            Sleep(10000);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //brokenLinks.BrokenLink();
            Sleep(10000);
            VScroll(200);
            
            upLoad_dnload.upLoad_dnloadRunner();
            Sleep(10000);
            VScroll(200);
            
            dynamicProp.dynamicPropRunner();
            
        }
    }
}
