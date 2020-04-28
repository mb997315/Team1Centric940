using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Team1Centric940.Models
{
    public class Giver
    {
        [Key]

        public int giverID { get; set; }

        [Display(Name = "Award")]

        public CoreValue award { get; set; }

        [Display(Name = "Your Name")]

        public Guid recongizer { get; set; }
        [ForeignKey("recongizer")]

        public virtual Employees giver { get; set; }

        [Display(Name = "Employee Being Recognized")]

        public Guid recognized { get; set; }
        [ForeignKey("recognized")]
        public virtual Employees reciever { get; set; }

        [Display(Name = "Date recognition given")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]

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

        public int employeeId { get; set; }

    }


}
