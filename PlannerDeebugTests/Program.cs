using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerLib;
using PlannerLib.Base;
using PlannerLib.Data.Entities;

namespace PlannerLibDebug{
    class Program{
        static void Main(string[] args)
        {
            Repository.Configuration.connString = "Server=localhost;Database=ApplicationData;Trusted_Connection=True;";
            
            IPlannerService service = new PlannerService();

            IEnumerable<Event> events = service.Event_Delete(new DEvent{ 
                key = 1,
                Date=DateTime.Today,
                End_Time=DateTime.Today,
                Start_Time =DateTime.Today,
                Event_Type_ID = 2,
                Urgency_ID = 2,
                Place_ID = 2,
                username = "user",
                Name = "Name",
                Description = "Description"
            }, "user");

            Console.WriteLine(events.Count());
        }
    }
}
