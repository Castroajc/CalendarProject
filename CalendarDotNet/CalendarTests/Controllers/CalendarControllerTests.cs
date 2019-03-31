using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarDotNet.Model;
using CalendarDotNet.Controller;

namespace CalendarTests
{

    [TestClass]
    public class CalendarControllerTests
    {
        private Calendar model;
        private CalendarController controller;
        [TestInitialize]
        public void CalendarControllerTestsInitalize()
        {
            model = new Calendar();
            controller = new CalendarController();
            controller.SetModel(model);
        }
        //start of tests
        [TestMethod]
        //the StartCalendar method should set the day and month to one
        //when the website launches it should start on the first month and day
        public void ControllerSetCalendarTest() 
        {
            controller.StartCalendar();
            Assert.AreEqual(1, model.GetDay());
            Assert.AreEqual(1, model.GetMonth());
            
        }
        [TestMethod]
        public void CalendarChangeToPreviousMonthTest()
        {
            model.SetMonth(2); //initalizing the month to 2
            controller.ChangeToPreviousMonth(); //this should set the month to 1
            Assert.AreEqual(1, model.GetMonth());
            //now testing when the month is one, it should roll over to 12
            controller.ChangeToPreviousMonth(); //should set the month to 12
            Assert.AreEqual(12, model.GetMonth());
        }
        [TestMethod]
        public void CalendarChangeToNextMonthTest()
        {
            model.SetMonth(11);
            controller.ChangeToNextMonth();
            Assert.AreEqual(12, model.GetMonth());
            //now testing when the month is 12, this should roll over to 1
            controller.ChangeToNextMonth();
            Assert.AreEqual(1, model.GetMonth());
        }
    }
}
