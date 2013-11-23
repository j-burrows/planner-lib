/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSEventRepository.cs
 |  Purpose:    To define the stored procedures used by an Sql Server repository of events.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PlannerLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace PlannerLib.Data.Repository{
    class SqlSEventRepository : SqlSRepository<DEvent>{
        public SqlSEventRepository(string username) : base() {
            //Collection is filled with all eventy associated with a given user.
            string query = string.Format(
                @"EXEC Planner.Event_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DEvent creating){
            SqlCommand cmd = new SqlCommand("Planner.Event_Create");
            cmd.AddParams(
                 new Param("username", creating.username),
                 new Param("Start_Time", creating.Start_Time),
                 new Param("End_Time", creating.End_Time),
                 new Param("Date", creating.Date),
                 new Param("Urgency_ID", creating.Urgency_ID),
                 new Param("Event_Type_ID", creating.Event_Type_ID),
                 new Param("Place_ID", creating.Place_ID),
                 new Param("Name", creating.Name),
                 new Param("Description", creating.Description)
            );

            //The entry is made into the database and assigned the resulting key.
            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);      //Entry is placed into main memory collection.
        }
        protected override void UpdateEval(DEvent updating){
            SqlCommand cmd = new SqlCommand("Planner.Event_Update");
            cmd.AddParams( 
                 new Param("Event_ID", updating.Event_ID),
                 new Param("Start_Time", updating.Start_Time),
                 new Param("End_Time", updating.End_Time),
                 new Param("Date", updating.Date),
                 new Param("Urgency_ID", updating.Urgency_ID),
                 new Param("Event_Type_ID", updating.Event_Type_ID),
                 new Param("Place_ID", updating.Place_ID),
                 new Param("Name", updating.Name),
                 new Param("Description", updating.Description)
            );

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }
        protected override void DeleteEval(DEvent deleting){
            SqlCommand cmd = new SqlCommand("Planner.Event_Delete");
            cmd.AddParam("Event_ID", deleting.Event_ID);

            ExecNonReader(cmd);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
