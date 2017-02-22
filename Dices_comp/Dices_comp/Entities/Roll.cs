using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dices_comp.Entities
{
    public class Roll : AbstractEntity
    {
        public DateTime DateStamp { get; set; }
        public List<int> Dices { get; set; } 

        public string Text { get; set; }
    }
}
