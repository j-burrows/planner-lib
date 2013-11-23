/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BPlace.cs
 |  Purpose:    Define the business logical for a physical place.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace PlannerLib.Business{
    public class BPlace : PlannerLib.Presentation.PPlace, IBusinessUnit{
        public readonly ProtocolStack Place_ID_Rules = ProtocolStack.ForKey("Place_ID");
        public readonly ProtocolStack Long_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Long_Name");
        public readonly ProtocolStack Short_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 2 }, "Short_Name");

        public virtual bool CreateValid(){
            bool isValid = true;
            isValid = Place_ID_Rules.Create.passes(Place_ID) && isValid;
            isValid = Long_Name_Rules.Create.passes(Long_Name) && isValid;
            isValid = Short_Name_Rules.Create.passes(Short_Name) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Place_ID_Rules.Update.passes(Place_ID) && isValid;
            isValid = Long_Name_Rules.Update.passes(Long_Name) && isValid;
            isValid = Short_Name_Rules.Update.passes(Short_Name) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid(){
            return true;
        }

        public virtual bool Equivilant(IBusinessUnit comparing){
            return false;
        }
    }
}
