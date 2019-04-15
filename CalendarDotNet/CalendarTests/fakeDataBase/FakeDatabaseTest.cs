using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarDotNet.Controller;
using CalendarDotNet.Model;
using CalendarDotNet.Persistence;

namespace CalendarProjectTests.fakeDataBase
{
    [TestClass]
    public class FakeDatabaseTest
    {
        FakeDatabase fake;
        [TestInitialize]
        public void FakeDatabaseInitalize()
        {
            //starts up all the variables
            fake = new FakeDatabase();
        }
        [TestMethod]
        public void AddEventTest()
        {
            fake.AddEvent(2, 3, "Test Title", "Description", "3:00pm");
            List<Days> testList = fake.LoadEvent(2);
            Assert.AreEqual(3, testList[0].GetyDayId() );
            Assert.AreEqual("Test Title",testList[0].GetTitle());
            Assert.AreEqual("Description", testList[0].GetDescription());
            Assert.AreEqual("3:00pm", testList[0].GetStartTime());

        }
        [TestMethod]
        public void LoadEventsTest()
        {
            List<Days> daysTest = fake.LoadEvent(0);
            Assert.AreEqual("Clever Title", daysTest[0].GetTitle());
        }

    }
}
