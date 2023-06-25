using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__sample_Project
{
    internal class DB_conection
    {
        public string GetConnectionString()
        {
            string databaseFileName = "Dental_DB.mdf";
            string projectPath = Application.StartupPath;
            string databaseFilePath = Path.Combine(projectPath, databaseFileName);
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{databaseFilePath}\";Integrated Security=True";

            return connectionString;
        }

        public bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
