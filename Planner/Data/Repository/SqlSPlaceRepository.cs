/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSPlaceRepository.cs
 |  Purpose:    To define the stored procedures used by an Sql Server repository of places.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using PlannerLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace PlannerLib.Data.Repository{
    public class SqlSPlaceRepository : SqlSRepository<DPlace>{
        public SqlSPlaceRepository(): base(){
            //Collection is filled with all places stored in the database.
            string query = string.Format(
                @"EXEC dbo.Place_GetList;"
            );
            FillRepository(query);
        }

        public SqlSPlaceRepository(int Event_ID): base(){
            //Collection is filled with all places associated with a given event.
            string query = string.Format(
                @"EXEC dbo.Place_GetByID @Place_ID = '{0}';",
                Event_ID
            );
            FillRepository(query);
        }

        protected override void CreateEval(DPlace creating){
            SqlCommand cmd = new SqlCommand("dbo.Place_Create");
            cmd.AddParam("Long_Name", creating.Long_Name);
            cmd.AddParam("Short_Name", creating.Short_Name);

            //The entry is created in the database and assigned the resulting key.
            creating.key = ExecStoredProcedure(cmd);

            //The entry is created in the main memory collection.
            base.CreateEval(creating);
        }

        protected override void UpdateEval(DPlace updating){
            SqlCommand cmd = new SqlCommand("dbo.Place_Update");
            cmd.AddParam("Place_ID", updating.Place_ID);
            cmd.AddParam("Long_Name", updating.Long_Name);
            cmd.AddParam("Short_Name", updating.Short_Name);

            ExecNonReader(cmd);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is updated in main memory collection.
        }

        protected override void DeleteEval(DPlace deleting){
            SqlCommand cmd = new SqlCommand("dbo.Place_Delete");
            cmd.AddParam("Place_ID", deleting.Place_ID);

            ExecNonReader(cmd);             //The entry is deleted from the database.

            base.DeleteEval(deleting);      //Entry is deleted from main memory collection.
        }
    }
}
