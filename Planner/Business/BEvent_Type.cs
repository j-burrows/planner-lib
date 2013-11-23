/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BEvent_Type.cs
 |  Purpose:    Define the business logical for an event type.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Presentation;
using Repository.Business;
using Repository.Business.Protocols;
namespace PlannerLib.Business{
    public class BEvent_Type : PEvent_Type, IBusinessUnit{
        public readonly ProtocolStack Event_Type_ID_Rules = ProtocolStack.ForKey("Event_Type_ID");
        public readonly ProtocolStack Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Name");
        public readonly ProtocolStack Description_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 16 }, "Description");

        public virtual bool CreateValid(){
            bool isValid = true;
            isValid = Event_Type_ID_Rules.Create.passes(Event_Type_ID) && isValid;
            isValid = Name_Rules.Create.passes(Name) && isValid;
            isValid = Description_Rules.Create.passes(Description) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Event_Type_ID_Rules.Update.passes(Event_Type_ID) && isValid;
            isValid = Name_Rules.Update.passes(Name) && isValid;
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
