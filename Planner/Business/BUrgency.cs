/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BUrgency.cs
 |  Purpose:    Define the business logical for an urgency.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Presentation;
using Repository.Business;
using Repository.Business.Protocols;
namespace PlannerLib.Business{
    public class BUrgency : PUrgency, IBusinessUnit{
        public readonly ProtocolStack Urgency_ID_Rules = ProtocolStack.ForKey("Urgency_ID");
        public readonly ProtocolStack Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Name");
        public readonly ProtocolStack Level_Rules = ProtocolStack.WithPremise(
            new Premise { numeric = true, minValue = 0, maxValue = 7, stepValue = 0.5}, "Level");
        public readonly ProtocolStack Description_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Description");

        public virtual bool CreateValid(){
            bool isValid = true;
            isValid = Urgency_ID_Rules.Create.passes(Urgency_ID) && isValid;
            isValid = Name_Rules.Create.passes(Name) && isValid;
            isValid = Level_Rules.Create.passes(Level) && isValid;
            isValid = Description_Rules.Create.passes(Description) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Urgency_ID_Rules.Update.passes(Urgency_ID) && isValid;
            isValid = Name_Rules.Update.passes(Name) && isValid;
            isValid = Level_Rules.Update.passes(Level) && isValid;
            isValid = Description_Rules.Update.passes(Description) && isValid;
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
