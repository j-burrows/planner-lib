/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSUrgencyRepository.cs
 |  Purpose:    Define the stored procedures used by an Sql Server repository of event types
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using PlannerLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace PlannerLib.Data.Repository{
    public class SqlSEvent_TypeRepository : SqlSRepository<DEvent_Type>{
        public SqlSEvent_TypeRepository() : base() {
            //Collection is filled with every single event type stored in database.
            string query = "EXEC Planner.Event_Type_GetList;";
            FillRepository(query);
        }

        public SqlSEvent_TypeRepository(int Event_ID) : base(){
            //Collection is filled with all event types specific to a single event.
            string query = string.Format(
                @"EXEC Planner.Event_Type_GetByUser @Event_ID = '{0}';",
                Event_ID
            );
            FillRepository(query);
        }

        protected override void CreateEval(DEvent_Type creating){
            SqlCommand cmd = new SqlCommand("Planner.Event_Type_Create");
            cmd.AddParam("Name", creating.Name);
            cmd.AddParam("Description", creating.Description);

            //The entry is made into the database.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is placed into main memory collection.
        }

        protected override void UpdateEval(DEvent_Type updating){
            SqlCommand cmd = new SqlCommand("Planner.Event_Type_Update");
            cmd.AddParam("Event_Type_ID", updating.Event_Type_ID);
            cmd.AddParam("Name", updating.Name);
            cmd.AddParam("Description", updating.Description);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }

        protected override void DeleteEval(DEvent_Type deleting){
            SqlCommand cmd = new SqlCommand("Planner.Event_Type_Delete");
            cmd.AddParam("Event_Type_ID", deleting.Event_Type_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
