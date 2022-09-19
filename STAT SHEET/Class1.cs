using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAT_SHEET
{
    public class CharData
    {
        public int STR { get; set; }
        public int DEX { get; set; }
        public int VIT { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int LUK { get; set; }
        public string NAME { get; set; } = "Empty Name";
        public string DESC { get; set; } = "";
        //public List<Items> ITEMS;
    }

    public class Items {
        public string NAME { get; set; }
        public string DESC { get; set; }
    }
}
