using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHero
{
    public class Colours
    {

        public void ChangeFontColorToYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void ChangeFontColorToRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void DeafultForegroundColor()
        {
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
