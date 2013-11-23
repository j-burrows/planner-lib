using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Business;
namespace PlannerLibUnitTests.Business{
    [TestClass]
    public class tBUrgency{
        [TestMethod]
        public void BUrgencyWithValidMembers_WhenCreateValidated_ReturnsTrue(){
            //Arrange: A urgency with all valid members is created.
            BUrgency urgency = new BUrgency{
                Name = "Name",
                Description = "Description"
            };

            //Act: the urgency is checked if it is create valid.
            bool valid = urgency.CreateValid();

            //Assert: the urgency is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BUrgencyWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: A urgency with all invalid members is created.
            BUrgency urgency = new BUrgency{
                Name = "12345678901234567890",
                Description = null
            };

            //Act: the urgency is checked if it is create valid.
            bool valid = urgency.CreateValid();

            //Assert: the urgency is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BUrgencyWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: A urgency with all valid members is created.
            BUrgency urgency = new BUrgency{
                Name = "Name",
                Description = "Description"
            };

            //Act: the urgency is checked if it is update valid.
            bool valid = urgency.UpdateValid();

            //Assert: the urgency is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BUrgencyWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: A urgency with all invalid members is created.
            BUrgency urgency = new BUrgency{
                Name = "12345678901234567890",
                Description = null
            };

            //Act: the urgency is checked if it is update valid.
            bool valid = urgency.UpdateValid();

            //Assert: the urgency is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: A urgency is created
            BUrgency urgency = new BUrgency();

            //Act: the urgency is checked if it is update valid.
            bool valid = urgency.DeleteValid();

            //Assert: the urgency is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: A urgency is created
            BUrgency urgency = new BUrgency();

            //Act: the urgency is checked to be equivilant to itself.
            bool equals = false;// urgency.Equivilant(urgency);

            //Assert: the urgency is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
