/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PPlace.cs
 |  Purpose:    Defines a formatting function to place so it may be rendered on screen.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Presentation;
namespace PlannerLib.Presentation{
    public class PPlace : PlannerLib.Base.Place, IPresentationUnit{
        public virtual void Format(){
            //Any nullable members are replaced with empty ones.
            if(Long_Name == null){
                Long_Name = string.Empty;
            }
            if(Short_Name == null){
                Short_Name = string.Empty;
            }
        }
    }
}
