using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team1Centric940.Models
{
    public class Giver
    {
        [Key]
        public int giverID { get; set; }
        public int gratitudeId { get; set; }
        [Display(Name = "Award")]
        public CoreValue award { get; set; }
        [Display(Name = "Your Name")]
        public Guid recognizor { get; set; }
        [Display(Name = "Employee Being Recognized")]
        public string recognized { get; set; }
        [Display(Name = "Date recognition given")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="(0:MM/DD/yyyy", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> recognizationDate { get; set; }
        
        public enum CoreValue
        {
            Excellence = 1,
            Integrity = 2,
            Stewardship = 3,
            Innovate = 4,
            Balance = 5,
            Passion = 6,
            Culture = 7,


        }
    }
}