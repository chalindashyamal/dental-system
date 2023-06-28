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
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\NSBM\\1st year 3rd Semester\\C#\\dental-system\\C#_sample Project\\Dental_DB.mdf\";Integrated Security=True";
        public string GetConnectionString()
        {
            return connectionString;
        }

        public bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
