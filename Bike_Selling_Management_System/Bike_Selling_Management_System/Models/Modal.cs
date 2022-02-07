using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bike_Selling_Management_System.Models
{
    public class Modal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Make Make { get; set; }

        public int MakeID { get; set; }
    }
}
