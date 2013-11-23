/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   PlannerService.cs
 * 
 |  Purpose:    Defines a set of main functionality that the library produces.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.ServiceModel;
using PlannerLib.Data.Entities;
using PlannerLib.Factory;
using PlannerLib.Presentation;
using Repository.Data;
namespace PlannerLib{
    public class PlannerService : IPlannerService{
        public IEnumerable<PEvent> Event_GetByUser(string username) {
            return RepositoryFactory.Instance.Construct<DEvent>(username);
        }

        public IEnumerable<PEvent_Type> Event_Type_GetList() {
            return RepositoryFactory.Instance.Construct<DEvent_Type>();
        }

        public IEnumerable<PPlace> Place_GetList(){
            return RepositoryFactory.Instance.Construct<DPlace>();
        }

        public IEnumerable<PUrgency> Urgency_GetList(){
            return RepositoryFactory.Instance.Construct<DUrgency>();
        }

        public IEnumerable<PEvent> Event_Create(DEvent creating, string username) {
            IDataRepository<DEvent> events =
                RepositoryFactory.Instance.Construct<DEvent>(username);
            events.Create(creating);

            return events;
        }

        public IEnumerable<PEvent> Event_Update(DEvent updating, string username){
            IDataRepository<DEvent> events = 
                RepositoryFactory.Instance.Construct<DEvent>(username);
            events.Update(updating);

            return events;
        }

        public IEnumerable<PEvent> Event_Delete(DEvent deleting, string username){
            IDataRepository<DEvent> events = 
                RepositoryFactory.Instance.Construct<DEvent>(username);
            events.Delete(deleting);

            return events;
        }

        public IEnumerable<PEvent_Type> Event_Type_Create(DEvent_Type creating){
            IDataRepository<DEvent_Type> event_types = 
                RepositoryFactory.Instance.Construct<DEvent_Type>();
            event_types.Create(creating);

            return event_types;
        }

        public IEnumerable<PEvent_Type> Event_Type_Update(DEvent_Type updating){
            IDataRepository<DEvent_Type> event_types =
                RepositoryFactory.Instance.Construct<DEvent_Type>();
            event_types.Update(updating);

            return event_types;
        }

        public IEnumerable<PEvent_Type> Event_Type_Delete(DEvent_Type deleting){
            IDataRepository<DEvent_Type> event_types = 
                RepositoryFactory.Instance.Construct<DEvent_Type>();
            event_types.Delete(deleting);

            return event_types;
        }

        public IEnumerable<PPlace> Place_Create(DPlace creating){
            IDataRepository<DPlace> places = 
                RepositoryFactory.Instance.Construct<DPlace>();
            places.Create(creating);

            return places;
        }

        public IEnumerable<PPlace> Place_Update(DPlace updating){
            IDataRepository<DPlace> places =
                RepositoryFactory.Instance.Construct<DPlace>();
            places.Update(updating);

            return places;
        }

        public IEnumerable<PPlace> Place_Delete(DPlace deleting){
            IDataRepository<DPlace> places = RepositoryFactory.Instance.Construct<DPlace>();
            places.Delete(deleting);

            return places;
        }

        public IEnumerable<PUrgency> Urgency_Create(DUrgency creating){
            IDataRepository<DUrgency> urgencies = 
                RepositoryFactory.Instance.Construct<DUrgency>();
            urgencies.Create(creating);

            return urgencies;
        }

        public IEnumerable<PUrgency> Urgency_Update(DUrgency updating){
            IDataRepository<DUrgency> urgencies = 
                RepositoryFactory.Instance.Construct<DUrgency>();
            urgencies.Update(updating);

            return urgencies;
        }

        public IEnumerable<PUrgency> Urgency_Delete(DUrgency deleting){
            IDataRepository<DUrgency> urgencies =
                RepositoryFactory.Instance.Construct<DUrgency>();
            urgencies.Delete(deleting);

            return urgencies;
        }
    }
}
