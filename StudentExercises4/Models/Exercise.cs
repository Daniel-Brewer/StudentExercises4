using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises4.Models
{
    public class Exercise
    {
        public Exercise()
        {
        }

        public Exercise(string Name, string Language)
        {
            this.Name = Name;
            this.Language = Language;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
    }
}
