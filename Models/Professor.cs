using System;
using System.ComponentModel.DataAnnotations;

namespace Lab_11_Professor.Models
{
    public class Professor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}