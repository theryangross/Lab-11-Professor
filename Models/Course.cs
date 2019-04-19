using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Lab_11_Professor.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Description { get; set; }
        public int ID { get; set; } //FK
        public Professor Professor {get; set;} // Nav
    }
}