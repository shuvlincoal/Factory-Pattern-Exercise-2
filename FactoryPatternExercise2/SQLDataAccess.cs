using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public string Name { get; set; } = "SQLDB";
        public int Price { get; set; } = 5000;
        public void LoadData()
        {
            Console.WriteLine($"Loading SQL List Data NameName:{Name}, Price:{Price} Access");

        }
        public void SaveData()
        {
            Console.WriteLine("Saving SQL Data");
        }

    }//Method
}//Namespace
