using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: List, SQL, or Mongo?\n");
            
            IDataAccess data = DataAccessFactory.GetDataAccessType(Console.ReadLine());
            data.LoadData();
            data.SaveData();
        }
    }
}
