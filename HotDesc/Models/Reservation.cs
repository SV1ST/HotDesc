using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Models
{
    public class Reservation
    {
        public int Id { get; set; }        
        public DateTime Date { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
