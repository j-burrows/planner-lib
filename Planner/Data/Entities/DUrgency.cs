/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DUrgency.cs
 |  Purpose:    Define the data layer logic for an urgency.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using PlannerLib.Business;
using Repository.Data;
using Repository.Helpers;
namespace PlannerLib.Data.Entities{
    public class DUrgency : BUrgency, IDataUnit{
        //Primary key to be used as index in database.
        public int key {
            get { return Urgency_ID; }
            set { Urgency_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(System.Data.DataRow row) {
            //A row from the database is parsed into the entity.
            Urgency_ID = row["Urgency_ID"].ToInt();
            Name = row["Name"].ToStr();
            Level = row["Level"].ToInt();
            Description = row["Description"].ToStr();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DUrgency>(comparing);
        }

        public void Scrub(){
            //All string members are cleared of possible html/sql injection.
            Name = Name.Scrub();
            Description = Description.Scrub();
        }
    }
}
