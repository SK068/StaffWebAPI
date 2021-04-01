using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffWebAPI.Models
{
    public class StaffName
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
