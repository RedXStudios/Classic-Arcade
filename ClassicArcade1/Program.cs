/*            
 *            Author: Jeff Thwaites
 *        Class Name: Program.cs
 * Class Description: Main program class that starts the program
 *                    and opens GameSelect form
 */

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
        static void Main()//Start program and open GameSelect form by default
        {
            gameSelect gameSlct = new gameSelect();

            Application.EnableVisualStyles();
            gameSlct.Show();
            Application.Run();
        }
    }
}
