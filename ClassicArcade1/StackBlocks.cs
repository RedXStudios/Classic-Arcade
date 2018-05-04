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
    public partial class StackBlocks : Form
    {
        private int hScore, cScore;

        public StackBlocks()
        {
            InitializeComponent();
        }

        private void pauseb_Click(object sender, EventArgs e)
        {
            if (pauseB.Text == "Pause")
            {
                dropTimer.Stop();
                pauseB.Text = "Resume";
            }
            else
            {
                dropTimer.Start();
                pauseB.Text = "Pause";
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (pauseB.Text == "Pause")
            {
                dropTimer.Stop();
                pauseB.Text = "Resume";
            }

            result = MessageBox.Show("Are you sure?\n(All progress will be lost)", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                gameSelect gameSlct = new gameSelect();

                gameSlct.Show();
                this.Close();//test when ur back
            }
            else
            {
                dropTimer.Start();
                pauseB.Text = "Pause";
            }
        }

        public void NextBlock(int blockType) //Draws the next block in nextBlock area (bottom left in ui)
        {
            switch (blockType)//Specified block type
            {
                case 1: //Line block
                    next1.Visible = true;
                    next3.Visible = true;
                    next6.Visible = true;
                    next8.Visible = true;
                    break;
                case 2: //Right facing L block
                    next2.Visible = true;
                    next5.Visible = true;
                    next6.Visible = true;
                    next7.Visible = true;
                    break;
                case 3: //Left facing L block
                    next4.Visible = true;
                    next5.Visible = true;
                    next6.Visible = true;
                    next7.Visible = true;
                    break;
                case 4: //T block
                    next2.Visible = true;
                    next3.Visible = true;
                    next4.Visible = true;
                    next6.Visible = true;
                    break;
                case 5: //2x2 block
                    next2.Visible = true;
                    next3.Visible = true;
                    next5.Visible = true;
                    next6.Visible = true;
                    break;
                default:
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
    }
}
