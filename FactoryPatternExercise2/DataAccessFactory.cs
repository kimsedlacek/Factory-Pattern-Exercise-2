using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
             switch (databaseType)
            {
                case "List":
                case "list":
                    return new ListDataAccess();
                case "SQL":
                case "sql":
                    return new SQLDataAccess();
                case "Mongo":
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
                    
            }
        }
    }
}
