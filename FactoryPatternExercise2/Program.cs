using System;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string? userInput = "";
            Console.WriteLine("Enter \"sql\",  \"mongo\", or \"list\" ");
            string? userInput = (Console.ReadLine()).ToLower();
            IDataAccess dataAccess = DataAccesFactory.GetDataAccessType(userInput);
            dataAccess.LoadData();
            dataAccess.SaveData();

        }
    }
}
