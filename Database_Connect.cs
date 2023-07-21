using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner_s_Point
{
    public static class Database_Connect
    {
        public static string connect_database() 
        {
            string connect = "Server=localhost; database=Learners_Point; Uid=root; Pwd=''; SslMode=none";
            return connect;
        }
    }
}
