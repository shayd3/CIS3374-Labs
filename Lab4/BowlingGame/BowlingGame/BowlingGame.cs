using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    public class BowlingGame
    {

        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public int Score
        {
            get
            {
                int score = 0;
                int index = 0;

                for (int frame = 0; frame < 10; frame++) //Keeps track of which frame (up to 10)
                {
                    if (IsStrike(index)) //Strike
                    {
                        score += rolls[index] + rolls[index + 1] + rolls[index + 2];
                        index++;
                    }
                    else if (IsSpare(index)) //Spare
                    {
                        score += rolls[index] + rolls[index + 1] + rolls[index + 2];
                        index += 2;
                    }
                    else //Open Frame
                    {
                        score += rolls[index] + rolls[index + 1];
                        index += 2;
                    }

                }
                return score;
            }
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        private bool IsStrike(int index)
        {
            return rolls[index] == 10;
        }

        private bool IsSpare(int index)
        {
            return rolls[index] + rolls[index + 1] == 10;
        }

        
    }
}
