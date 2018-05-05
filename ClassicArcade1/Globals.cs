/*            
 *            Author: Jeff Thwaites
 *        Class Name: Globals.cs
 * Class Description: Contains global variables used throughout the program,
 *                    along with method to retrive highscore of specified game
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassicArcade
{
    class Globals
    {
        public const String savePath = @"C:\Users\Public\ClassicArcade.txt";//save file path

        public int getHighScore(String game)//method to retrive highscore of current running game
        {
            int highScore = 0;

            using (StreamReader reader = File.OpenText(savePath))//open savefile path
            {
                String l = game;//store current game name in l variable

                while (reader.ReadLine() != game.ToUpper())//while next line isn't current game
                {
                    reader.ReadLine();//skip score of read game to cut amount of loops in half
                }

                int.TryParse(reader.ReadLine(), out highScore);//once current game is found in save file, 
                                                               //read highscore and pass it into highScore variable
            }

            return highScore;
        }
    }
}
