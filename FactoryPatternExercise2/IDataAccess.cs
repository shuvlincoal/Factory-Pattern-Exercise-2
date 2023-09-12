using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        public void LoadData();
        //{

        //    Console.WriteLine("Load Data");
        //    //New List of Product
        //}

        public void SaveData();
        //{
        //    Console.WriteLine("Save Data");
        //}

    }
}
