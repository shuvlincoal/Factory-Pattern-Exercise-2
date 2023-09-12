using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public string Name { get; set; } = "Unknown";
        public int Price { get; set; } = 0;

        public void LoadData()
        {
            Console.WriteLine($"Loading List Data Name:Name:{Name}, Price:{Price} Access");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving List Data Access");
        }

    }//Method
}//Namespace
