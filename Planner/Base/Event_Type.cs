/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Event_Type.cs
 |  Purpose:    Define an event type and its members.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
namespace PlannerLib.Base{
    public class Event_Type{
        public int Event_Type_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
