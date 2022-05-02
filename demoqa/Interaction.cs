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
        public static void sortablerunner( )
        {
            DragSixOnOne();
            Sleep(2000);
            DragTwoOnFour();
            Sleep(2000);
            Grid();
            Sleep(2000);
            DragThreeToSeven();
        }
        public static void DragSixOnOne( )
        {
            VScroll(300);
            Actions action = new Actions(driver);
            action.ClickAndHold
                (driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[6]"))).
                MoveToElement
                (driver.FindElement(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[1]"))).
                Release().Build().Perform();
        }
        public static void DragTwoOnFour( )
        {
            VScroll(300);            
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

        public static void DragThreeToSeven( )
        {
            VScroll(300);
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
        public static void selectablerunner( )
        {
            VScroll(300);
            driver.FindElement(By.XPath("//*[@class = 'element-group'][5]//child::li[2]")).Click();
            Sleep(3000);
            ListTwo();
            Sleep(2000);
            VScroll(300);
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
        public static void ResizableBoxinFrame( )
        {
            VScroll(300);
            Actions action = new Actions(driver);
            action.ClickAndHold(driver.FindElement(By.XPath("//*[@class = 'constraint-area']//child::span"))).
                MoveByOffset(100, 20).Release().Build().Perform();
        }
        public static void ResizableBoxOutFrame( )
        {
            VScroll(300);
            Actions action = new Actions(driver);
            action.ClickAndHold(driver.FindElement(By.XPath("//*[@class = 'resizable-nolimit mt-4']//child::span"))).
                MoveByOffset(300, 200).Release().Build().Perform();
        }
        public static void resizablerunner( )
        {
            VScroll(300);
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][5]//child::li[3]");
            Sleep(3000);
            ResizableBoxinFrame();
            Sleep(2000);
            ResizableBoxOutFrame();
        }
    }
    #endregion

    #region Dropable
    class dropable : SeleniumSetMethod
    {
        public static void SimpleDropBox( )
        {
            Actions action = new Actions(driver);
            CombineScroll(200, 200);            
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id][1]")),
                driver.FindElement(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void AcceptTab( )
        {
            CombineScroll(200, 200);            
            Sleep(500);
            driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-accept']")).Click();
            string aa = null;
        }
        public static void AcceptableDropBox( )
        {
            Actions action = new Actions(driver);
            CombineScroll(200, 200);
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id][1]")),
               driver.FindElement(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id = 'droppable']"))).Release().Build().Perform();
        }
        public static void PreventTab( )
        {
            CombineScroll(200, 200);
            Sleep(500);
            driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-preventPropogation']")).Click();
        }
        public static void PreventDropBoxOuter( )
        {
            Actions action = new Actions(driver);
            CombineScroll(200, 200);
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']")),
                driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='notGreedyDropBox']"))).Release().Build().Perform();
        }
        public static void PreventDropBoxOuterDrop( )
        {
            Actions action = new Actions(driver);
            CombineScroll(200, 200);
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']")),
               driver.FindElement(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='greedyDropBox']"))).Release().Build().Perform();
        }
        public static void RevertTab( )
        {
            CombineScroll(200, 200);
            Sleep(500);
            driver.FindElement(By.XPath("//*[@id = 'droppableExample-tab-revertable']")).Click();
        }
        public static void WillRevert( )
        {
            Actions action = new Actions(driver);
            CombineScroll(200, 200);
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='revertable']")),
                driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void NotRevert( )
        {
            Actions action = new Actions(driver);
            CombineScroll(200, 200);
            Sleep(500);
            action.DragAndDrop(driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='notRevertable']")),
                driver.FindElement(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']"))).Release().Build().Perform();
        }
        public static void dropablerunner( )
        {
            VScroll(200);            
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][5]//child::li[4]");
            Sleep(3000);
            SimpleDropBox();
            Sleep(3000);
            AcceptTab();
            Sleep(3000);
            AcceptableDropBox();
            Sleep(3000);
            PreventTab();
            Sleep(3000);
            PreventDropBoxOuter();
            Sleep(3000);
            PreventDropBoxOuterDrop();
            Sleep(3000);
            RevertTab();
            Sleep(3000);
            WillRevert();
            Sleep(3000);
            NotRevert();

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
        public static void YDrag(int y  )
        {
            Actions action = new Actions(driver);
            VScroll(200);
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@id= 'restrictedY']")),
               0, y).Release().Build().Perform();
        }
        public static void ContainerTab()
        {
            driver.FindElement(By.XPath("//*[@id= 'draggableExample-tab-containerRestriction']")).Click();
        }

        public static void ContainerBox(int x, int y  )
        {
            Actions action = new Actions(driver);
            VScroll(200);
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']")),
               x, y).Release().Build().Perform();
        }
        public static void ContainerParent(int x, int y  )
        {
            Actions action = new Actions(driver);
            VScroll(200);
            action.DragAndDropToOffset(driver.FindElement(By.XPath("//*[@class='ui-widget-header ui-draggable ui-draggable-handle']")),
               x, y).Release().Build().Perform();
        }

        public static void draggablerunner( )
        {
            VScroll(500);            
            Click(PropertyType.Xpath, "//*[@class = 'element-group'][5]//child::li[5]");
            Sleep(3000);
            SimpleDropBox(100, 50);
            Sleep(3000);
            AxisTab();
            Sleep(3000);
            XDrag(100);
            Sleep(3000);
            YDrag(50 );
            Sleep(3000);
            ContainerTab();
            Sleep(3000);
            ContainerBox(100, 150);
            Sleep(3000);
            ContainerParent(100, 50);
        }
    }
    #endregion
    class Interaction : SeleniumSetMethod
    {
        public static void interactionRun( )
        {

            sortable.sortablerunner();
            Sleep(3000);
            selectable.selectablerunner();
            Sleep(3000);
            resizable.resizablerunner();
            Sleep(3000);
            dropable.dropablerunner();
            Sleep(3000);
            draggable.draggablerunner();

        }
    }
}
