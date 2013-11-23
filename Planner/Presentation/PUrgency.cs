/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PUrgency.cs
 |  Purpose:    Defines a formatting function to urgency so it may be rendered on screen.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Base;
using Repository.Presentation;
namespace PlannerLib.Presentation{
    public class PUrgency : Urgency, IPresentationUnit{
        public virtual void Format() { 
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
