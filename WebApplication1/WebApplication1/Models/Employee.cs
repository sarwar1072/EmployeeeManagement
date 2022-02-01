using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public DateTime datetime { get; set; }
        public bool maritialStatus { get; set; }
        public double salary { get; set; }
    }
}
