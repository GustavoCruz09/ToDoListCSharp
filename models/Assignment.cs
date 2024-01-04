using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListCSharp.models
{
    public class Assignment
    {
        public Assignment(string description)
        {
            Description = description;
            Completed = false;
        }

        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}