using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Dice
    {

        public int value {get;set;}

        public void roll()
        {
            Random rnd = new Random();
            value = rnd.Next(1, 7);
        }



    }
}
