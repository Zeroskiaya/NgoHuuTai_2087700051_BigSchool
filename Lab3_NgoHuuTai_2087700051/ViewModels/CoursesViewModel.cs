using Lab3_NgoHuuTai_2087700051.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab3_NgoHuuTai_2087700051.ViewModels
{
    public class CoursesViewModel
    {

        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}