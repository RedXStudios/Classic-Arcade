/*            
 *            Author: Jeff Thwaites
 *        Class Name: StackBlocks.cs
 * Class Description: Manages StackBlocks form. contains all components
 *                    necessary to replicate a game of Tetris
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
using System.IO;

namespace ClassicArcade
{
    public partial class StackBlocks : Form
    {
        private int hScore, cScore;//Initialize highscore and currentscore variables
        StreamReader reader;
        StreamWriter writer;

        public StackBlocks()//method to initialize StackBlocks game
        {
            Globals g = new Globals();//import Globals class for use of getHighScore method

            hScore = g.getHighScore("STACKBLOCKS");//retrieve stackblocks highscore
            cScore = 0;

            InitializeComponent();
            hScoreLabel.Text = hScore.ToString();//set highscore label to highscore
            cScoreLabel.Text = cScore.ToString();//set current score label to current score
            dropTimer.Start();
            runGame();//call main method
        }

        public void runGame()//main method for running the game and its components
        {
            Random rand = new Random();
            int i;

            i = rand.Next(5);
        }

        private void pauseb_Click(object sender, EventArgs e)//if pause/resume button is clicked
        {
            if (pauseB.Text == "Pause")//if game is paused, stop timer and change button text to "resume"
            {
                dropTimer.Stop();
                pauseB.Text = "Resume";
            }
            else//start timer and change button text to "pause"
            {
                dropTimer.Start();
                pauseB.Text = "Pause";
            }
        }

        private void exitB_Click(object sender, EventArgs e)//if exit button is clicked
        {
            DialogResult result;

            if (pauseB.Text == "Pause")//Pause game if it isn't already
            {
                dropTimer.Stop();
                pauseB.Text = "Resume";
            }

            result = MessageBox.Show("Are you sure?\n(All progress will be lost)", "Confirm", MessageBoxButtons.YesNo);//ask user to confirm if they want to quit

            if (result == DialogResult.Yes)//if yes is chosen, close StackBlocks form and reopen GameSelect form
            {
                gameSelect gameSlct = new gameSelect();

                gameSlct.Show();
                this.Close();
            }
            else//if no is chosen, resume game
            {
                dropTimer.Start();
                pauseB.Text = "Pause";
            }
        }

        public void NextBlock(int blockType) //Draws the next block in nextBlock area (bottom left in ui)
        {
            switch (blockType)//Specified block type
            {
                case 0: //Line block
                    setNextColor(Color.Orange);
                    next1.Visible = true;
                    next3.Visible = true;
                    next6.Visible = true;
                    next8.Visible = true;
                    break;
                case 1: //Right facing L block
                    setNextColor(Color.Blue);
                    next2.Visible = true;
                    next5.Visible = true;
                    next6.Visible = true;
                    next7.Visible = true;
                    break;
                case 2: //Left facing L block
                    setNextColor(Color.Red);
                    next4.Visible = true;
                    next5.Visible = true;
                    next6.Visible = true;
                    next7.Visible = true;
                    break;
                case 3: //T block
                    setNextColor(Color.Yellow);
                    next2.Visible = true;
                    next3.Visible = true;
                    next4.Visible = true;
                    next6.Visible = true;
                    break;
                case 4: //2x2 block
                    setNextColor(Color.Green);
                    next2.Visible = true;
                    next3.Visible = true;
                    next5.Visible = true;
                    next6.Visible = true;
                    break;
                default://no block
                    next1.Visible = false;
                    next2.Visible = false;
                    next3.Visible = false;
                    next4.Visible = false;
                    next5.Visible = false;
                    next6.Visible = false;
                    next7.Visible = false;
                    next8.Visible = false;
                    break;
            }
        }

        public void setNextColor(Color color)
        {
            next1.BackColor = color;
            next2.BackColor = color;
            next3.BackColor = color;
            next4.BackColor = color;
            next5.BackColor = color;
            next6.BackColor = color;
            next7.BackColor = color;
            next8.BackColor = color;
        }
    }
}
