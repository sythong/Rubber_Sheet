//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using SQLite;

namespace Rubber_Sheet.Database
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
    }
}
