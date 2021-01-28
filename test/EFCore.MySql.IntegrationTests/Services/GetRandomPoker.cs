
using System;

namespace Player.Actions
{
    public class GetRandomPoker
    {
        public int[] Get(int playerAmount)
        {
            int[] poker = new int[playerAmount*2 + 5];

            return poker;
        }

        private int GetRandomNumber()
        {
            Random rd = new Random();
            return rd.Next(0, 52);
        }
    }
}
