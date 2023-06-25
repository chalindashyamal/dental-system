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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\OneDrive\\Documents\\Projects\\C#_sample Project\\C#_sample Project\\Dental_DB.mdf\";Integrated Security=True";

            return connectionString;
        }

        public bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
