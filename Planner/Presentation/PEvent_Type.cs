/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PEvent_Type.cs
 |  Purpose:    Defines a formatting function to event type so it may be rendered on screen.
 |  Author:     Jonathan Burrows
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Base;
using Repository.Presentation;

namespace PlannerLib.Presentation{
    public class PEvent_Type : Event_Type, IPresentationUnit{
        public virtual void Format(){
            //Any nullable members are replaced with empty ones.
            if(Name == null){
                Name = string.Empty;
            }
            if(Description == null){
                Description = string.Empty;
            }
        }
    }
}
