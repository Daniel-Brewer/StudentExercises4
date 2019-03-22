using StudentExercises4.Data;
using StudentExercises4.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace StudentExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository;

            List<Exercise> exercises = repository.GetAllExercises();
            Console.WriteLine("All Exercises:");
            foreach (Exercise ex in exercises)
            {
                Console.WriteLine(ex.Name);
            };
            Pause();
        }
    }
}
