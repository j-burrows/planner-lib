/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSRepositoryFactory.cs
 |  Purpose:    A factory pattern class used to contruct repositories to achieve dependancy
 |              inversion.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System;
using PlannerLib.Base;
using PlannerLib.Data.Repository;
using Repository.Data;
using Repository.Factory;
using Repository.Helpers;
namespace PlannerLib.Factory{
    public class SqlSRepositoryFactory : IRepositoryFactory{
        public IDataRepository<T> Construct<T>(params object[] args) where T : IDataUnit {
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Event))){
                return (IDataRepository<T>)Activator.CreateInstance(typeof(SqlSEventRepository), args);
            }
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Event_Type))){
                return (IDataRepository<T>)Activator.CreateInstance(typeof(SqlSEvent_TypeRepository), args);
            }
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Place))){
                return (IDataRepository<T>)Activator.CreateInstance(typeof(SqlSPlaceRepository), args);
            }
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Urgency))){
                return (IDataRepository<T>)Activator.CreateInstance(typeof(SqlSUrgencyRepository), args);
            }
            return null;
        }
    }
}
