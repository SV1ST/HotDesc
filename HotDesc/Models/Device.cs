using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Workplace> Workplaces { get; set; }
        public Device()
        {
            Workplaces = new List<Workplace>();
        }

    }
}
