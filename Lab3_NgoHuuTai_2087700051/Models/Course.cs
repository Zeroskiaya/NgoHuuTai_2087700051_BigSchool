using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lab3_NgoHuuTai_2087700051;

namespace Lab3_NgoHuuTai_2087700051.Models
{
    public class Course
    {
        public int Id { get; set; } 
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }

        [Required]
        public byte CategoryID { get; set; }
    }
}