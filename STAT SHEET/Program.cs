﻿using System;
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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        public static List<CharData> chars = new List<CharData>();
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
            Console.WriteLine(chars.ToArray().ToString());
            string json = JsonSerializer.Serialize(chars,option);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(path, json);
        }
    }
}
