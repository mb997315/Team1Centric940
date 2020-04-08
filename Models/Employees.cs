using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team1Centric940.Models
{
    public class Employees
    {
        [Key]
        public int employeeId { get; set; }
       
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int giverId { get; set; }
        
    }
}