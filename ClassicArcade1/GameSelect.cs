/*            
 *            Author: Jeff Thwaites
 *        Class Name: GameSelect.cs
 * Class Description: Manages GameSelect form. Allows user to choose 
 *                    specified game and opens that game's form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicArcade
{
    public partial class gameSelect : Form
    {
        public gameSelect()
        {
            InitializeComponent();
        }

        private void StackBlocks_Click(object sender, EventArgs e)
        {
            NewGame("Stack"); //Call NewGame method
        }

        private void Sudoku_Click(object sender, EventArgs e)
        {
            NewGame("Sudoku"); //Call NewGame method
        }

        public void NewGame(String game) //Method for opening specified game
        {
            switch (game)
            {
                case ("Stack"): //Open StackBlocks form
                    new StackBlocks().Show();
                    break;
                case ("Sudoku"): //Open Sudoku form
                    //new Sudoku().Show();
                    break;
            }
            this.Close(); //Closes GameSelect form
        }

        private void quitB_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
