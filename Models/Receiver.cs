using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team1Centric940.Models
{
    public class Receiver
    {
        [Key]
        public int receiverId { get; set; }
        public int gratitudeId { get; set; }
        [Display(Name = "ID of Person giving the recognition")]
        public Guid recognizor { get; set; }
        [Display(Name = "ID of Person receiving the recognition")]
        public Guid recognized { get; set; }

    }
}