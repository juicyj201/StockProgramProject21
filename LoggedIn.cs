using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProgram
{
    static class LoggedIn
    {
        private static bool logged;
        public static bool loggedSet { set { logged = value; } }
        public static bool loggedGet { get { return logged; } }
    }
}
