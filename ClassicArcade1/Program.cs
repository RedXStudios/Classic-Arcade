using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicArcade
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            gameSelect gameSlct = new gameSelect();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            gameSlct.Show();
            Application.Run();
        }
    }
}
