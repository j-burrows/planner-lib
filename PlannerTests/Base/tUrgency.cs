using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Base;
namespace PlannerLibUnitTests.Base{
    [TestClass]
    public class tUrgency{
        [TestMethod]
        public void Urgency_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: An ugency pointer is declared.
            Urgency ugency;

            //Act: The pointer is constructed without parameters.
            ugency = new Urgency();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, ugency);
        }
    }
}
