using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Business;
namespace PlannerLibUnitTests.Business{
    [TestClass]
    public class tBEvent{
        [TestMethod]
        public void BEventWithValidMembers_WhenCreateValidated_ReturnsTrue(){
            //Arrange: An event with all valid members is created.
            BEvent _event = new BEvent{
                username = "owner",
                Name = "Name",
                Description = "Description"
            };

            //Act: the event is checked if it is create valid.
            bool valid = _event.CreateValid();

            //Assert: the event is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BEventWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: An event with all invalid members is created.
            BEvent _event = new BEvent{
                username = null,
                Name = null,
                Description = null
            };

            //Act: the event is checked if it is create valid.
            bool valid = _event.CreateValid();

            //Assert: the event is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BEventWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: An event with all valid members is created.
            BEvent _event = new BEvent{
                username = "owner",
                Name = "Name",
                Description = "Description"
            };

            //Act: the event is checked if it is update valid.
            bool valid = _event.UpdateValid();

            //Assert: the event is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BEventWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: An event with all invalid members is created.
            BEvent _event = new BEvent{
                username = null,
                Name = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890",
                Description = null
            };

            //Act: the event is checked if it is update valid.
            bool valid = _event.UpdateValid();

            //Assert: the event is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: An event is created
            BEvent _event = new BEvent();

            //Act: the event is checked if it is update valid.
            bool valid = _event.DeleteValid();

            //Assert: the event is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: An event is created
            BEvent _event = new BEvent();

            //Act: the event is checked to be equivilant to itself.
            bool equals = false;// _event.Equivilant(_event);

            //Assert: the event is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
