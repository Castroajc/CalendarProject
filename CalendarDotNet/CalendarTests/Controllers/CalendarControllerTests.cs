using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarDotNet.Model;

namespace CalendarTests
{

    [TestClass]
    public class CalendarControllerTests
    {
        private Calendar model;
        [TestInitialize]
        public void CalendarControllerTestsInitalize()
        {
            model = new Calendar();
        }
        [TestMethod]
        public void CalendarDayTest()
        {
            model.SetDay(12);
            Assert.AreEqual(12, model.GetDay());
        }
    }
}
