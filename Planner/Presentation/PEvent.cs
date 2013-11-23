/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PEvent.cs
 |  Purpose:    Defines a formatting function to event so it may be rendered on screen.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System;
using PlannerLib.Base;
using Repository.Presentation;
namespace PlannerLib.Presentation{
    public class PEvent : Event, IPresentationUnit{
        public virtual void Format(){
            //Any nullable members are replaced with empty ones.
            if(Date == null){
                Date = DateTime.MinValue;
            }
            if(Start_Time == null){
                Start_Time = DateTime.MinValue;
            }
            if(End_Time == null){
                End_Time = DateTime.MinValue;
            }
            if(urgency == null){
                urgency = new Urgency();
            }
            if(place == null){
                place = new Place();
            }
            if(Name == null){
                Name = string.Empty;
            }
            if(Description == null){
                Description = string.Empty;
            }
        }
    }
}
