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
            Repository repository = new Repository();

            //1) Query the database for all the Exercises.
            List<Exercise> exercises = repository.GetAllExercises();
            Console.WriteLine("All Exercises:");
            foreach (Exercise e in exercises)
            {
                Console.WriteLine(e.Name);
            };
            Pause();

            //2) Find all the exercises in the database where the language is JavaScript.
            List<Exercise> javascriptExercises = repository.GetAllExercisesByLanguage("JavaScript");
            Console.WriteLine("JavaScript Exercises:");
            foreach (Exercise e in javascriptExercises)
            {
                Console.WriteLine(e.Name);
            };
            Pause();

            //3) Insert a new exercise into the database.
            Exercise additionalExercise = new Exercise()
            {
                Name = "Departments & Employees",
                Language = "SQL"
            };
            repository.AddExercise(additionalExercise);
            Console.WriteLine("Exercises after adding new one:");
            foreach (Exercise e in repository.GetAllExercises())
            {
                Console.WriteLine(e.Name);
            };
            Pause();

            //4) Find all instructors in the database. Include each instructor's cohort.
            List<Instructor> instructors = repository.GetAllInstructors();
            Console.WriteLine("List of instructors:");
            foreach (Instructor i in instructors)
            {
                Console.WriteLine($"{i.FirstName} {i.LastName} is an instructor in {i.Cohort.Name}");
            }
            Pause();

            //5) Insert a new instructor into the database. Assign the instructor to an existing cohort.
            Instructor additionalInstructor = new Instructor()
            {
                FirstName = "Leah",
                LastName = "Gwin-Hoefling",
                SlackHandle = "LeahGH",
                CohortId = 4
            };
            repository.AddInstructor(additionalInstructor);
            Console.WriteLine("Instructors after adding new one:");
            foreach (Instructor i in repository.GetAllInstructors())
            {
                Console.WriteLine($"{i.FirstName} {i.LastName} is an instructor in {i.Cohort.Name}");
            };
            Pause();

            //6) Assign an existing exercise to an existing student.

            List<Student> listOfStudents = repository.GetAllStudents();
            List<Exercise> listOfExercises = repository.GetAllExercises();
            Student firstStudent = listOfStudents[1];
            Exercise firstExercise = listOfExercises[0];

            repository.AddExerciseToStudent(firstStudent, firstExercise);
            Pause();

        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}