using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _5th_Study_List_Class_Relations.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Lab Laboratory { get; set; }

        public string ReflectInfo()
        {
            return $"{Name}{LastName}";
        }

    }
}
