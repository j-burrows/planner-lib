/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Event.cs
 |  Purpose:    Define an event and its members.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System;
namespace PlannerLib.Base{
    public class Event{
        public string username { get; set; }
        public int Event_ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public Urgency urgency { get; set; }
        public int Urgency_ID { get; set; }
        public Place place { get; set; }
        public int Place_ID { get; set; }
        public Event_Type event_type { get; set; }
        public int Event_Type_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
