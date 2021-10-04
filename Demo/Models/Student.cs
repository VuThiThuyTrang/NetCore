using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Student

    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}