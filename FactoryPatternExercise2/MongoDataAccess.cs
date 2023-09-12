using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public string Name { get; set; } = "MongoDB";
        public int Price { get; set; } = 7000;

        public void LoadData()
        {
            Console.WriteLine($"Loading Mongo List Data Name:{Name}, Price:{Price} Access");

        }
        public void SaveData()
        {
            Console.WriteLine("Saving Mongo Data");
        }

    }//Method
}//Namespace
