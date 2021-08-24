using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram
{
    /// <summary>
    /// A static class that allows other forms to access its variables.
    /// I am using this class to keep the data in the forms updated and to prevent the closing of any forms (loss of data)
    /// </summary>
    static class FormControl
    {
        private static StartMenu menu = new StartMenu();
        public static StartMenu menu2 { get { return menu; } }

        private static MainDatabase main = new MainDatabase();
        public static MainDatabase main2 { get { return main; } }

        private static Help help = new Help();
        public static Help help2 { get { return help; } }

        private static Settings settings = new Settings();
        public static Settings settings2 { get { return settings; } }

        private static AboutBox about = new AboutBox();
        public static AboutBox about2 { get { return about; } }

        private static Login login = new Login();
        public static Login login2 { get { return login; } }

        private static Registration register = new Registration();
        public static Registration register2 { get { return register; } }
    }

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
            Application.Run(new SplashScreen());
        }

    }
}
