using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a mongo database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a mongo database");
        }
    }
}
