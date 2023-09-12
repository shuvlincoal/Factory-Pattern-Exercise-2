using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccesFactory
    {

        public static IDataAccess GetDataAccessType(string whichDB)
        {

            switch (whichDB.ToLower())
            {
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "list":
                    return new ListDataAccess();
                default:
                    return new SQLDataAccess();
            }//switch

        }


    }
}
