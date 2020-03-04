using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Team1Centric940.DAL
{
    public class MIS4200Team1Context : DBContext
    {
        public  MIS4200Team1Context() : base ("name=DefaultConnection")
            {

            }
    }
}