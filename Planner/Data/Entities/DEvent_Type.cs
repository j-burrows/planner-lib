/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DEvent_Type.cs
 |  Purpose:    Define the data layer logic for an event type.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Business;
using Repository.Data;
using Repository.Helpers;
namespace PlannerLib.Data.Entities{
    public class DEvent_Type : BEvent_Type, IDataUnit{
        //Primary key to be used as index in database.
        public int key {
            get { return Event_Type_ID; }
            set { Event_Type_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(System.Data.DataRow row){
            //A row from the database is parsed into the entity.
            Event_Type_ID = row["Event_Type_ID"].ToInt();
            Name = row["Name"].ToStr();
            Description = row["Description"].ToStr();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DEvent_Type>(comparing);
        }

        public void Scrub(){
            //All string members are cleared of possible html/sql injection.
            Name = Name.Scrub();
            Description = Description.Scrub();
        }
    }
}
