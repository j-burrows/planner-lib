/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BEvent.cs
 |  Purpose:    Define the business logical for an event.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Presentation;
using Repository.Business;
using Repository.Business.Protocols;
namespace PlannerLib.Business{
    public class BEvent : PEvent, IBusinessUnit{
        public readonly ProtocolStack username_Rules = ProtocolStack.ForUsername();
        public readonly ProtocolStack Event_ID_Rules = ProtocolStack.ForKey("Event_ID");
        public readonly ProtocolStack Date_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false}, "Date");
        public readonly ProtocolStack Start_Time_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false}, "Start_Time");
        public readonly ProtocolStack End_Time_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true}, "End_Time");
        public readonly ProtocolStack Urgency_ID_Rules = ProtocolStack.ForKey("Urgency_ID");
        public readonly ProtocolStack Place_ID_Rules = ProtocolStack.ForKey("Place_ID");
        public readonly ProtocolStack Event_Type_ID_Rules
            = ProtocolStack.ForKey("Event_Type_ID");
        public readonly ProtocolStack Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Name");
        public readonly ProtocolStack Description_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 256 }, "Description");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = username_Rules.Create.passes(username) && isValid;
            isValid = Event_ID_Rules.Create.passes(Event_ID) && isValid;
            isValid = Date_Rules.Create.passes(Date) && isValid;
            isValid = Start_Time_Rules.Create.passes(Start_Time) && isValid;
            isValid = End_Time_Rules.Create.passes(End_Time) && isValid;
            isValid = Urgency_ID_Rules.Create.passes(Urgency_ID) && isValid;
            isValid = Event_Type_ID_Rules.Create.passes(Event_Type_ID) && isValid;
            isValid = Name_Rules.Create.passes(Name) && isValid;
            isValid = Description_Rules.Create.passes(Description) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = username_Rules.Update.passes(username) && isValid;
            isValid = Event_ID_Rules.Update.passes(Event_ID) && isValid;
            isValid = Date_Rules.Update.passes(Date) && isValid;
            isValid = Start_Time_Rules.Update.passes(Start_Time) && isValid;
            isValid = End_Time_Rules.Update.passes(End_Time) && isValid;
            isValid = Urgency_ID_Rules.Update.passes(Urgency_ID) && isValid;
            isValid = Event_Type_ID_Rules.Update.passes(Event_Type_ID) && isValid;
            isValid = Name_Rules.Update.passes(Name) && isValid;
            isValid = Description_Rules.Update.passes(Description) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid(){
            return true;
        }

        public virtual bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            return false;
        }
    }
}
