/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   IPlannerService.cs
 |  Purpose:    Declares a set of main functionality that the library produces.
 |  Note:       Is prepared to be swapped into a web service at a later time.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.ServiceModel;
using PlannerLib.Data.Entities;
using PlannerLib.Presentation;
namespace PlannerLib{
    [ServiceContract]
    public interface IPlannerService{
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_GetByUser
         |  Purpose:    Returns a collection of all the events belonging to a user.
         |  Param:      username            The owner who owns all returned events.
         |  Return:     IEnumerable<PEvent> All events belonging to a user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent> Event_GetByUser(string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Type_GetList
         |  Purpose:    Returns all event types stored in the database.
         |  Return:     IEnumerable<PEvent_Type> All event types
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent_Type> Event_Type_GetList();
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Place_GetList
         |  Purpose:    Returns all places stored in the database.
         |  Return:     IEnumerable<PPlace> All the places stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PPlace> Place_GetList();
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Urgency_GetList
         |  Purpose:    Returns all urgencies stored in the database.
         |  Return:     IEnumerable<PUrgency>   All the urgencies stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PUrgency> Urgency_GetList();


        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Create
         |  Purpose:    Creates an event and returns all current events in the database.
         |  Param:      creating:           The event to be added to the database.
         |              username:           The owner of the collection to be modified.
         |  Return:     IEnumerable<PEvent> Resulting events stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent> Event_Create(DEvent creating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Update
         |  Purpose:    Updates an event and returns all current events in the database.
         |  Param:      updating:           The event to be updated in the database.
         |              username:           The owner of the collection to be modified.
         |  Return:     IEnumerable<PEvent> Resulting events stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent> Event_Update(DEvent updating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Delete
         |  Purpose:    Deletes an event and returns all current events in the database.
         |  Param:      deleting:           The event to be removed from the database.
         |              username:           The owner of the collection to be modified.
         |  Return:     IEnumerable<PEvent> Resulting events stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent> Event_Delete(DEvent deleting, string username);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Type_Create
         |  Purpose:    Creates an event typeand returns all current events in the database.
         |  Param:      creating            The event type to be added to the database.
         |  Return:     IEnumerable<PEvent> Resulting event types stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent_Type> Event_Type_Create(DEvent_Type creating);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Type_Update
         |  Purpose:    Updates an event typeand returns all current events in the database.
         |  Param:      updating            The event to be updated in the database.
         |  Return:     IEnumerable<PEvent> Resulting event types stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent_Type> Event_Type_Update(DEvent_Type updating);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Event_Type_Delete
         |  Purpose:    Deletes an event typeand returns all current events in the database.
         |  Param:      deleting            The event to be removed from the database.
         |  Return:     IEnumerable<PEvent> Resulting event types stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PEvent_Type> Event_Type_Delete(DEvent_Type deleting);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Place_Create
         |  Purpose:    Creates a place and returns all current places in the database.
         |  Param:      creating:           The place to be added to the database.
         |  Return:     IEnumerable<PPlace> Resulting event types stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PPlace> Place_Create(DPlace creating);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Place_Update
         |  Purpose:    Updates a place and returns all current places in the database.
         |  Param:      updating            The place to be updated in the database.
         |  Return:     IEnumerable<PPlace> Resulting places stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PPlace> Place_Update(DPlace updating);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Place_Delete
         |  Purpose:    Deletes a place and returns all current places in the database.
         |  Param:      deleting:           The place is be removed from the database.
         |  Return:     IEnumerable<PPlace> Resulting places stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PPlace> Place_Delete(DPlace deleting);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Urgency_Create
         |  Purpose:    Creates an urgency and returns all current urgencies in the database
         |  Param:      creating                The urgency to be added to database.
         |  Return:     IEnumerable<PUrgency>   Resulting urgencies stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PUrgency> Urgency_Create(DUrgency creating);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Urgency_Update
         |  Purpose:    Updates an urgency and returns all current urgencies in the database
         |  Param:      updating                The urgency to be updated in database.
         |  Return:     IEnumerable<PUrgency>   Resulting urgencies stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PUrgency> Urgency_Update(DUrgency updating);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Urgency_Delete
         |  Purpose:    Deletes an urgency and returns all current urgencies in the database
         |  Param:      deleting                The urgency to be deleted
         |  Return:     IEnumerable<PUrgency>   Resulting urgencies stored in the database.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         */
        [OperationContract]
        IEnumerable<PUrgency> Urgency_Delete(DUrgency deleting);
    }
}
