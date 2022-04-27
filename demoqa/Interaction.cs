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
    class sortable
    {
        public static void sortablerunner(IJavaScriptExecutor js)
        {
            DragSixOnOne(js);
            PropertiesS.Sleep(2000);
            DragTwoOnFour(js);
            PropertiesS.Sleep(2000);
            Grid();
            PropertiesS.Sleep(2000);
            DragThreeToSeven(js);
        }
        public static void DragSixOnOne(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(PropertiesS.driver);
            action.ClickAndHold
                (PropertiesS.driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[6]"))).
                MoveToElement
                (PropertiesS.driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[1]"))).
                Release().Build().Perform();
        }
        public static void DragTwoOnFour(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(PropertiesS.driver);
            action.ClickAndHold
                (PropertiesS.driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[2]"))).
                MoveToElement
                (PropertiesS.driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[4]"))).
                Release().Build().Perform();
        }
        public static void Grid()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']")).Click();
        }

        public static void DragThreeToSeven(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(PropertiesS.driver);
            action.ClickAndHold
                  (PropertiesS.driver.FindElement(By.XPath("//*[@class= 'create-grid']//child::div[3]"))).
                  MoveToElement
                  (PropertiesS.driver.FindElement(By.XPath("//*[@class= 'create-grid']//child::div[7]"))).
                  Release().Build().Perform();
        }
    }
    #endregion

    #region Selectable
    class selectable
    {
        public static void ListTwo()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@class = 'tab-content']//child::li[2]")).Click();
        }
        public static void ListFour()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@class = 'tab-content']//child::li[4]")).Click();
        }
        public static void Grid()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']")).Click();
        }
        public static void GridFive()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@id= 'demo-tabpane-grid']//child::div[2]//child::li[2]")).Click();
        }
        public static void GridNine()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@id= 'demo-tabpane-grid']//child::div[3]//child::li[3]")).Click();
        }
        public static void selectablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            PropertiesS.driver.FindElement(By.XPath("//*[@class = 'element-group'][5]//child::li[2]")).Click();
            PropertiesS.Sleep(3000);
            ListTwo();
            PropertiesS.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            ListFour();
            PropertiesS.Sleep(2000);
            Grid();
            PropertiesS.Sleep(2000);
            GridFive();
            PropertiesS.Sleep(2000);
            GridNine();
        }
    }
    #endregion

    #region Resizable
    class resizable
    {
        public static void ResizableBoxinFrame(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,300)");
            Actions action = new Actions(PropertiesS.driver);
            action.ClickAndHold(PropertiesS.driver.FindElement(By.XPath("//*[@class = 'constraint-area']//child::span"))).
                MoveByOffset(100, 20).Release().Build().Perform();
        }
        public static void ResizableBoxOutFrame(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,700)");
            Actions action = new Actions(PropertiesS.driver);
            action.ClickAndHold(PropertiesS.driver.FindElement(By.XPath("//*[@class = 'resizable-nolimit mt-4']//child::span"))).
                MoveByOffset(300, 200).Release().Build().Perform();
        }
        public static void resizablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][5]//child::li[3]");
            PropertiesS.Sleep(3000);
            ResizableBoxinFrame(js);
            PropertiesS.Sleep(2000);
            ResizableBoxOutFrame(js);
        }
    }
    #endregion

    #region Dropable
    class dropable
    {
        public static void SimpleDropBox(IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            action.DragAndDrop(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id][1]")),
                PropertiesS.driver.FindElement(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void AcceptTab(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            PropertiesS.driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-accept']")).Click();
            string aa = null;
        }
        public static void AcceptableDropBox(IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            action.DragAndDrop(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id][1]")),
               PropertiesS.driver.FindElement(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id = 'droppable']"))).Release().Build().Perform();
        }
        public static void PreventTab(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            PropertiesS.driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-preventPropogation']")).Click();
        }
        public static void PreventDropBoxOuter(IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            action.DragAndDrop(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']")),
                PropertiesS.driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='notGreedyDropBox']"))).Release().Build().Perform();
        }
        public static void PreventDropBoxOuterDrop(IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            action.DragAndDrop(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']")),
               PropertiesS.driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='greedyDropBox']"))).Release().Build().Perform();
        }
        public static void RevertTab(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            PropertiesS.driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-revertable']")).Click();
        }
        public static void WillRevert(IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            action.DragAndDrop(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='revertable']")),
                PropertiesS.driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void NotRevert(IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(200,200)");
            PropertiesS.Sleep(500);
            action.DragAndDrop(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='notRevertable']")),
                PropertiesS.driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void dropablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,200)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][5]//child::li[4]");
            PropertiesS.Sleep(3000);
            SimpleDropBox(js);
            PropertiesS.Sleep(3000);
            AcceptTab(js);
            PropertiesS.Sleep(3000);
            AcceptableDropBox(js);
            PropertiesS.Sleep(3000);
            PreventTab(js);
            PropertiesS.Sleep(3000);
            PreventDropBoxOuter(js);
            PropertiesS.Sleep(3000);
            PreventDropBoxOuterDrop(js);
            PropertiesS.Sleep(3000);
            RevertTab(js);
            PropertiesS.Sleep(3000);
            WillRevert(js);
            PropertiesS.Sleep(3000);
            NotRevert(js);

        }

    }
    #endregion

    #region Draggable
    class draggable
    {
        public static void SimpleDropBox(int x, int y)
        {
            Actions action = new Actions(PropertiesS.driver);
            action.DragAndDropToOffset(PropertiesS.driver.FindElement(By.XPath("//*[@class= 'tab-content']//child::div[@id='dragBox']")),
               x, y).Release().Build().Perform();
        }

        public static void AxisTab()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@id= 'draggableExample-tab-axisRestriction']")).Click();
        }

        public static void XDrag(int x)
        {
            Actions action = new Actions(PropertiesS.driver);
            action.DragAndDropToOffset(PropertiesS.driver.FindElement(By.XPath("//*[@id= 'restrictedX']")),
               x, 0).Release().Build().Perform();
        }
        public static void YDrag(int y,IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(0,200)");
            action.DragAndDropToOffset(PropertiesS.driver.FindElement(By.XPath("//*[@id= 'restrictedY']")),
               0, y).Release().Build().Perform();
        }
        public static void ContainerTab()
        {
            PropertiesS.driver.FindElement(By.XPath("//*[@id= 'draggableExample-tab-containerRestriction']")).Click();
        }

        public static void ContainerBox(int x, int y, IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(0,200)");
            action.DragAndDropToOffset(PropertiesS.driver.FindElement(By.XPath("//*[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']")),
               x, y).Release().Build().Perform();
        }
        public static void ContainerParent(int x, int y, IJavaScriptExecutor js)
        {
            Actions action = new Actions(PropertiesS.driver);
            js.ExecuteScript("window.scrollBy(0,-200)");
            action.DragAndDropToOffset(PropertiesS.driver.FindElement(By.XPath("//*[@class='ui-widget-header ui-draggable ui-draggable-handle']")),
               x, y).Release().Build().Perform();
        }

        public static void draggablerunner(IJavaScriptExecutor js)
        {
            js.ExecuteScript("window.scrollBy(0,500)");
            SeleniumSetMethod.Click("Xpath", "//*[@class = 'element-group'][5]//child::li[5]");
            PropertiesS.Sleep(3000);
            SimpleDropBox(100, 50);
            PropertiesS.Sleep(3000);
            AxisTab();
            PropertiesS.Sleep(3000);
            XDrag(100);
            PropertiesS.Sleep(3000);
            YDrag(50,js);
            PropertiesS.Sleep(3000);
            ContainerTab();
            PropertiesS.Sleep(3000);
            ContainerBox(100, 150,js);
            PropertiesS.Sleep(3000);
            ContainerParent(100, 50,js);
        }
    }
    #endregion
    class Interaction
    {  
       public static void interactionRun(IJavaScriptExecutor js)
        {

            sortable.sortablerunner(js);
            PropertiesS.Sleep(3000);
            selectable.selectablerunner(js);
            PropertiesS.Sleep(3000);
            resizable.resizablerunner(js);
            PropertiesS.Sleep(3000);
            dropable.dropablerunner(js);
            PropertiesS.Sleep(3000);
            draggable.draggablerunner(js);

        }
    }
}
