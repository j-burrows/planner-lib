using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Base;
namespace PlannerLibUnitTests.Base{
    [TestClass]
    public class tEvent{
        [TestMethod]
        public void Event_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: An event pointer is declared.
            Event _event;

            //Act: The pointer is constructed without parameters.
            _event = new Event();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, _event);
        }
    }
}
