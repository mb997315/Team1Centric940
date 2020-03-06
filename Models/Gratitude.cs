using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team1Centric940.Models
{
    public class Gratitude
    {
        [Key]
        public int gratitudeId { get; set; }
        public int giverID { get; set; }



    }
}