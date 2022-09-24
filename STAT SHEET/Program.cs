using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace STAT_SHEET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public const string version = "1.2.0.0";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( main = new Main());
        }
        public static ProgramData data = new ProgramData();
        public static Main main;
        public static double eval(string expres)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expres);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);

        }
        public static void save(string path)
        {
            
            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
            string json = JsonSerializer.Serialize(new SaveData() {data = data },option);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(path, json);
        }
    }
}
