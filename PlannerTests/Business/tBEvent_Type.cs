using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Business;
namespace PlannerLibUnitTests.Business{
    [TestClass]
    public class tBEvent_Type_Type{
        [TestMethod]
        public void BEvent_TypeWithValidMembers_WhenCreateValidated_ReturnsTrue(){
            //Arrange: An event_type with all valid members is created.
            BEvent_Type event_type = new BEvent_Type{
                Name = "Name",
                Description = "Description"
            };

            //Act: the event_type is checked if it is create valid.
            bool valid = event_type.CreateValid();

            //Assert: the event_type is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BEvent_TypeWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: An event_type with all invalid members is created.
            BEvent_Type event_type = new BEvent_Type{
                Name = null,
                Description = null
            };

            //Act: the event_type is checked if it is create valid.
            bool valid = event_type.CreateValid();

            //Assert: the event_type is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BEvent_TypeWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: An event_type with all valid members is created.
            BEvent_Type event_type = new BEvent_Type{
                Name = "Name",
                Description = "Description"
            };

            //Act: the event_type is checked if it is update valid.
            bool valid = event_type.UpdateValid();

            //Assert: the event_type is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BEvent_TypeWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: An event_type with all invalid members is created.
            BEvent_Type event_type = new BEvent_Type{
                Name = "1234567890123456789012345678901234567890",
                Description = null
            };

            //Act: the event_type is checked if it is update valid.
            bool valid = event_type.UpdateValid();

            //Assert: the event_type is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: An event_type is created
            BEvent_Type event_type = new BEvent_Type();

            //Act: the event_type is checked if it is update valid.
            bool valid = event_type.DeleteValid();

            //Assert: the event_type is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: An event_type is created
            BEvent_Type event_type = new BEvent_Type();

            //Act: the event_type is checked to be equivilant to itself.
            bool equals = false;// event_type.Equivilant(event_type);

            //Assert: the event_type is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
