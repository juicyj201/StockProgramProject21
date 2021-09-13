using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProgram
{
    static class logg
    {
        private static bool logged = false;
        public static bool loggedSet { set { logged = logged; } }
        public static bool loggedGet { get { return logged; } }
    }
}
