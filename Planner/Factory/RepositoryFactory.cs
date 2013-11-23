/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   RepositoryFactory.cs
 |  Purpose:    Declares a singleton of a repository instance.
 |  Date:       October 14th, 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Factory;
namespace PlannerLib.Factory{
    public sealed class RepositoryFactory : SqlSRepositoryFactory, IRepositoryFactory{
        private static volatile RepositoryFactory _instance;

        private static object _lock = new object();

        private RepositoryFactory() { }

        public static RepositoryFactory Instance{
            get{
                if (_instance == null){
                    lock (_lock){
                        if (_instance == null){
                            _instance = new RepositoryFactory();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
