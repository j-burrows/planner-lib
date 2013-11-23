/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DEvent.cs
 |  Purpose:    Define the data layer logic for an event.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System;
using PlannerLib.Business;
using PlannerLib.Factory;
using Repository.Data;
using Repository.Helpers;
using System.Linq;
namespace PlannerLib.Data.Entities{
    public class DEvent : BEvent, IDataUnit{
        //Primary key to be used as index in database.
        public int key {
            get { return Event_ID; }
            set { Event_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(System.Data.DataRow row){
            //A row from the database is parsed into the entity.
            username = row["username"].ToStr();
            Event_ID = row["Event_ID"].ToInt();
            Date = row["Date"].ToDateTime();
            Start_Time = row["Start_Time"].ToDateTime();
            End_Time = row["End_Time"].ToDateTime();
            Urgency_ID = row["Urgency_ID"].ToInt();
            Place_ID = row["Place_ID"].ToInt();
            Event_Type_ID = row["Event_Type_ID"].ToInt();
            Name = row["Name"].ToStr();
            Description = row["Description"].ToStr();

            //Collection members are created from database repositories.
            place = RepositoryFactory.Instance.Construct<DPlace>().FirstOrDefault();
            urgency = RepositoryFactory.Instance.Construct<DUrgency>().FirstOrDefault();
            event_type = RepositoryFactory.Instance.Construct<DEvent_Type>().FirstOrDefault();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DEvent>(comparing);
        }

        public void Scrub() {
            //All string members are cleared of possible html/sql injection.
            Name = Name.Scrub();
            Description = Description.Scrub();
        }
    }
}
