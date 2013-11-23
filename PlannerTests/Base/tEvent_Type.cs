using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Base;
namespace PlannerLibUnitTests.Base{
    [TestClass]
    public class tEvent_Type{
        [TestMethod]
        public void Event_Type_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: An event type pointer is declared.
            Event_Type event_type;

            //Act: The pointer is constructed without parameters.
            event_type = new Event_Type();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, event_type);
        }
    }
}
