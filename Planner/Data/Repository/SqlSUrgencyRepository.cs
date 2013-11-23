/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSUrgencyRepository.cs
 |  Purpose:    To define the stored procedures used by an Sql Server repository of urgency.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using PlannerLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace PlannerLib.Data.Repository{
    public class SqlSUrgencyRepository : SqlSRepository<DUrgency>{
        public SqlSUrgencyRepository() : base(){
            //Collection is filled with all urgencies stored in the database.
            string query = "EXEC Planner.Urgency_GetList;";
            FillRepository(query);
        }

        public SqlSUrgencyRepository(int Event_ID) : base(){
            //The collection is filled with all urgencies associated with a given event.
            string query = string.Format(
                @"EXEC Planner.Urgency_GetByEvent @Event_ID = '{0}';",
                Event_ID
            );
            FillRepository(query);
        }

        protected override void CreateEval(DUrgency creating){
            SqlCommand cmd = new SqlCommand("Planner.Urgency_Create");
            cmd.AddParam("Name", creating.Name);
            cmd.AddParam("Level", creating.Level);
            cmd.AddParam("Description", creating.Description);

            //The entry is made into the database.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is placed into main memory collection.
        }
        protected override void UpdateEval(DUrgency updating){
            SqlCommand cmd = new SqlCommand("Planner.Urgency_Update");
            cmd.AddParam("Urgency_ID", updating.Urgency_ID);
            cmd.AddParam("Name", updating.Name);
            cmd.AddParam("Level", updating.Level);
            cmd.AddParam("Description", updating.Description);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }
        protected override void DeleteEval(DUrgency deleting){
            SqlCommand cmd = new SqlCommand("Planner.Urgency_Delete");
            cmd.AddParam("Urgency_ID", deleting.Urgency_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
