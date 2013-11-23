/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Urgency.cs
 |  Purpose:    Define an urgency (level) and its members.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
namespace PlannerLib.Base{
    public class Urgency{
        public int Urgency_ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
    }
}
