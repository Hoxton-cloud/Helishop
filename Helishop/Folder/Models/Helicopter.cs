using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.Folder.Models
{
    public class Helicopter
    {
        public int id { set; get; }

        public string name { set; get; }
        public string description { set; get; }
        public string image { set; get; }

        public int price { set; get; }

        public int issueYear { set; get; }
        public string fuel { set; get; }
        public int flightRange { set; get; }
        public int flightHours { set; get; }
        public int enginesCount { set; get; }

        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
