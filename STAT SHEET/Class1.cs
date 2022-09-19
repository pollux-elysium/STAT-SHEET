using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAT_SHEET
{
    public class CharData
    {
        public int STR;
        public int DEX;
        public int VIT;
        public int INT;
        public int WIS;
        public int CHA;
        public int LUK;
        public string NAME;
        public string DESC;
        public Items[] ITEMS;
    }

    public class Items {
        public string NAME;
        public string DESC;
    }
}
