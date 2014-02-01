using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestingDataAnnotationProject.DataAnnotation;

namespace TestingDataAnnotationProject.Models
{
    public class MyClass
    {
        [PrimeNumberOnly]
        [Display(Name = "Prime Number")]
        public int PrimeNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}