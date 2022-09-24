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
        public int MaxHP { get; set; }
        public int MaxMP { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        
        public string NAME { get; set; } = "Empty Name";
        public string DESC { get; set; } = "";

        public List<Items> ITEMS { get; set; } = new List<Items>();
        public List<Skill> SKILLS { get; set; } = new List<Skill>();
    }

    public class Items {
        public string NAME { get; set; } = "Empty Name";
        public string DESC { get; set; } = "";
    }

    public class Skill {
        public string NAME { get; set; } = "Empty Name";
        public string DESC { get; set; } = "";
    }

    public class ProgramData
    {
        public List<CharData> chars { get; set; } = new List<CharData>();
        public List<Items> items { get; set; } = new List<Items>();
    }

    public class SaveData
    {
        public string version { get; set; } = Program.version;
        public ProgramData data { get; set; }
    }
}
