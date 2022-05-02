using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa
{
    #region Sortable
    class sortable:SeleniumSetMethod
    {
        public static void sortablerunner(IJavaScriptExecutor js)
        {
            DragSixOnOne(js);
            Sleep(2000);
            DragTwoOnFour(js);
            Sleep(2000);
            Grid();
            Sleep(2000);
            DragThreeToSeven(js);
        }
        public static void DragSixOnOne(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(driver);
            action.ClickAndHold
                (driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[6]"))).
                MoveToElement
                (driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[1]"))).
                Release().Build().Perform();
        }
        public static void DragTwoOnFour(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(driver);
            action.ClickAndHold
                (driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[2]"))).
                MoveToElement
                (driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[4]"))).
                Release().Build().Perform();
        }
        public static void Grid()
        {
            driver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']")).Click();
        }

        public static void DragThreeToSeven(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(driver);
            action.ClickAndHold
                  (driver.FindElement(By.XPath("//*[@class= 'create-grid']//child::div[3]"))).
                  MoveToElement
                  (driver.FindElement(By.XPath("//*[@class= 'create-grid']//child::div[7]"))).
                  Release().Build().Perform();
        }
    }
    #endregion

    #region Selectable
    class selectable : SeleniumSetMethod
    {
        public static void ListTwo()
        {
            driver.FindElement(By.XPath("//*[@class = 'tab-content']//child::li[2]")).Click();
        }
        public static void ListFour()
        {
            driver.FindElement(By.XPath("//*[@class = 'tab-content']//child::li[4]")).Click();
        }
        public static void Grid()
        {
            driver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']")).Click();
        }
        public static void GridFive()
        {
            driver.FindElement(By.XPath("//*[@id= 'demo-tabpane-grid']//child::div[2]//child::li[2]")).Click();
        }
        public static void GridNine()
        {
            driver.FindElement(By.XPath("//*[@id= 'demo-tabpane-grid']//child::div[3]//child::li[3]")).Click();
        }
        public static void selectablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            driver.FindElement(By.XPath("//*[@class = 'element-group'][5]//child::li[2]")).Click();
            Sleep(3000);
            ListTwo();
            Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            ListFour();
            Sleep(2000);
            Grid();
            Sleep(2000);
            GridFive();
            Sleep(2000);
            GridNine();
        }
    }
    #endregion

    #region Resizable
    class resizable : SeleniumSetMethod
    {
        public static void ResizableBoxinFrame(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(driver);
            action.ClickAndHold(driver.FindElement(By.XPath("//*[@class = 'constraint-area']//child::span"))).
                MoveByOffset(100, 20).Release().Build().Perform();
        }
        public static void ResizableBoxOutFrame(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,700)");
            Actions action = new Actions(driver);
            action.ClickAndHold(driver.FindElement(By.XPath("//*[@class = 'resizable-nolimit mt-4']//child::span"))).
                MoveByOffset(300, 200).Release().Build().Perform();
        }
        public static void resizablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][5]//child::li[3]");
            Sleep(3000);
            ResizableBoxinFrame(js);
            Sleep(2000);
            ResizableBoxOutFrame(js);
        }
    }
    #endregion

    #region Dropable
    class dropable : SeleniumSetMethod
    {
        public static void SimpleDropBox(IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id][1]")),
                driver.FindElement(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void AcceptTab(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-accept']")).Click();
            string aa = null;
        }
        public static void AcceptableDropBox(IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id][1]")),
               driver.FindElement(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id = 'droppable']"))).Release().Build().Perform();
        }
        public static void PreventTab(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-preventPropogation']")).Click();
        }
        public static void PreventDropBoxOuter(IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']")),
                driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='notGreedyDropBox']"))).Release().Build().Perform();
        }
        public static void PreventDropBoxOuterDrop(IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']")),
               driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='greedyDropBox']"))).Release().Build().Perform();
        }
        public static void RevertTab(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-revertable']")).Click();
        }
        public static void WillRevert(IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='revertable']")),
                driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void NotRevert(IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='notRevertable']")),
                driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void dropablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][5]//child::li[4]");
            Sleep(3000);
            SimpleDropBox(js);
            Sleep(3000);
            AcceptTab(js);
            Sleep(3000);
            AcceptableDropBox(js);
            Sleep(3000);
            PreventTab(js);
            Sleep(3000);
            PreventDropBoxOuter(js);
            Sleep(3000);
            PreventDropBoxOuterDrop(js);
            Sleep(3000);
            RevertTab(js);
            Sleep(3000);
            WillRevert(js);
            Sleep(3000);
            NotRevert(js);

        }

    }
    #endregion

    #region Draggable
    class draggable : SeleniumSetMethod
    {
        public static void SimpleDropBox(int x, int y)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@class= 'tab-content']//child::div[@id='dragBox']")),
               x, y).Release().Build().Perform();
        }

        public static void AxisTab()
        {
            driver.FindElement(By.XPath("//*[@id= 'draggableExample-tab-axisRestriction']")).Click();
        }

        public static void XDrag(int x)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@id= 'restrictedX']")),
               x, 0).Release().Build().Perform();
        }
        public static void YDrag(int y, IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(0,200)");
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@id= 'restrictedY']")),
               0, y).Release().Build().Perform();
        }
        public static void ContainerTab()
        {
            driver.FindElement(By.XPath("//*[@id= 'draggableExample-tab-containerRestriction']")).Click();
        }

        public static void ContainerBox(int x, int y, IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(0,200)");
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']")),
               x, y).Release().Build().Perform();
        }
        public static void ContainerParent(int x, int y, IJavaScriptExecutor js)
        {
            Actions action = new Actions(driver);
            js.ExecuteScript("window.scrollBy(0,-200)");
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@class='ui-widget-header ui-draggable ui-draggable-handle']")),
               x, y).Release().Build().Perform();
        }

        public static void draggablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,500)");
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][5]//child::li[5]");
            Sleep(3000);
            SimpleDropBox(100, 50);
            Sleep(3000);
            AxisTab();
            Sleep(3000);
            XDrag(100);
            Sleep(3000);
            YDrag(50, js);
            Sleep(3000);
            ContainerTab();
            Sleep(3000);
            ContainerBox(100, 150, js);
            Sleep(3000);
            ContainerParent(100, 50, js);
        }
    }
    #endregion
    class Interaction : SeleniumSetMethod
    {
        public static void interactionRun(IJavaScriptExecutor js)
        {

            sortable.sortablerunner(js);
            Sleep(3000);
            selectable.selectablerunner(js);
            Sleep(3000);
            resizable.resizablerunner(js);
            Sleep(3000);
            dropable.dropablerunner(js);
            Sleep(3000);
            draggable.draggablerunner(js);

        }
    }
}
