using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    public class RollDice
    {
        public int[] SimulateDiceRolls(int numberOfRolls)
        {
            int[] rollTotals = new int[11];
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);
                int sum = die1 + die2;
                rollTotals[sum - 2]++;

            }
            return rollTotals;
        }
    }
}

     