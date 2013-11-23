using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Base;
namespace PlannerLibUnitTests.Base{
    [TestClass]
    public class tPlace{
        [TestMethod]
        public void Place_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A place pointer is declared.
            Place place;

            //Act: The pointer is constructed without parameters.
            place = new Place();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, place);
        }
    }
}
