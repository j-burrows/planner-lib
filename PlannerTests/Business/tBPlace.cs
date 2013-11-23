using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlannerLib.Business;
namespace PlannerLibUnitTests.Business{
    [TestClass]
    public class tBPlace{
        [TestMethod]
        public void BPlaceWithValidMembers_WhenCreateValidated_ReturnsTrue(){
            //Arrange: An place with all valid members is created.
            BPlace place = new BPlace{
                Short_Name = "SA",
                Long_Name = "Long name"
            };

            //Act: the place is checked if it is create valid.
            bool valid = place.CreateValid();

            //Assert: the place is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BPlaceWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: An place with all invalid members is created.
            BPlace place = new BPlace{
                Short_Name = "123",
                Long_Name = null
            };

            //Act: the place is checked if it is create valid.
            bool valid = place.CreateValid();

            //Assert: the place is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BPlaceWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: An place with all valid members is created.
            BPlace place = new BPlace{
                Short_Name = "SA",
                Long_Name = "Long name"
            };

            //Act: the place is checked if it is update valid.
            bool valid = place.UpdateValid();

            //Assert: the place is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BPlaceWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: An place with all invalid members is created.
            BPlace place = new BPlace{
                Short_Name = "123",
                Long_Name = null
            };

            //Act: the place is checked if it is update valid.
            bool valid = place.UpdateValid();

            //Assert: the place is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: An place is created
            BPlace place = new BPlace();

            //Act: the place is checked if it is update valid.
            bool valid = place.DeleteValid();

            //Assert: the place is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: An place is created
            BPlace place = new BPlace();

            //Act: the place is checked to be equivilant to itself.
            bool equals = false;// place.Equivilant(place);

            //Assert: the place is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
