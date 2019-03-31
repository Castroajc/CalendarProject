using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarDotNet.Model;

namespace CalendarTests
{

    [TestClass]
    public class CalendarTests
    {
        private Calendar model;
        [TestInitialize]
        public void CalendarTestsInitalize()
        {
            model = new Calendar();
        }
        [TestMethod]
        public void CalendarDayTests()
        {
            model.SetDay(12);
            Assert.AreEqual(12, model.GetDay());
        }
        [TestMethod]
        public void CalendarMonthTests()
        {
            model.SetMonth(2);
            Assert.AreEqual(2, model.GetMonth());
        }
    }
}
