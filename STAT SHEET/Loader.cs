using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace STAT_SHEET
{
    class Loader
    {
        string path;
        string rawJson;
        string version;
        JsonElement JSON;
        int minor;
        public Loader(string inputPath) 
        {
            path = inputPath;
            rawJson = System.IO.File.ReadAllText(path);
            JSON = JsonDocument.Parse(rawJson).RootElement;
            version = JSON.TryGetProperty("version", out JsonElement ver) ? ver.GetString() : GetVersion();
            minor = int.Parse(version.Split('.')[1]);
            
        }

        string GetVersion() {
            if (JSON.TryGetProperty("chars",out _))
            {
                return "1.1.0.0";
            }
            else
            {
                return "1.0.0.0";
            }
        }
        
        public bool Loadable()
        {
            if (int.Parse(Program.version.Split('.')[1]) < minor)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public ProgramData Data()
        {
            if (minor == 0)
            {
                return LoadM0();
            }
            else if (minor == 1)
            {
                return LoadM1();
            }
            else if (minor == 2)
            {
                return LoadM2();
            }
            else
            {
                return new ProgramData();
            }
        }
        
        ProgramData LoadM0()
        {
            return new ProgramData() { chars = JSON.Deserialize<List<CharData>>() };
        }

        ProgramData LoadM1()
        {
            return JSON.Deserialize<ProgramData>();
        }

        ProgramData LoadM2()
        {
            return JSON.TryGetProperty("data", out JsonElement data) ? data.Deserialize<ProgramData>() : new ProgramData();
        }
    }
}
