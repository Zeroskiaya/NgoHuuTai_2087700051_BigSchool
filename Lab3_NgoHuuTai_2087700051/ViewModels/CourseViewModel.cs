﻿using Lab3_NgoHuuTai_2087700051.Models;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_NgoHuuTai_2087700051.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date,Time));
        }
    }
}