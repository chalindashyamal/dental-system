using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__sample_Project
{
    internal class DB_conection
    {
        public string connectionString = "server=localhost;port=3306;userid=root;password=chalinda12#;database=dental_db;sslmode=none;";

        public bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
