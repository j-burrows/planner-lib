/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DPlace.cs
 |  Purpose:    Define the data layer logic for a physical place.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Data;
using Repository.Helpers;
namespace PlannerLib.Data.Entities{
    public class DPlace : PlannerLib.Business.BPlace, IDataUnit{
        //Primary key to be used as index in database.
        public int key{
            get { return Place_ID; }
            set { Place_ID = value; }
        }

        public string dataError { get; set; }
        
        public void InitFromRow(System.Data.DataRow row){
            //A row from the database is parsed into the entity.
            Place_ID = row["Place_ID"].ToInt();
            Long_Name = row["Long_Name"].ToStr();
            Short_Name = row["Short_Name"].ToStr();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DPlace>(comparing);
        }

        public void Scrub(){
            //All string members are cleared of possible html/sql injection.
            Long_Name = Long_Name.Scrub();
            Short_Name = Short_Name.Scrub();
        }
    }
}
