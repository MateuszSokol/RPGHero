using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHero
{
    class GUI : Colours
    {
        private string Header { get; }
        public string Message { get; set; }
        public Colours colors { get; set; }
        

        public GUI()
        {
            this.colors = new Colours();
            this.Header = "\t \t \t \t \t" + "Welcome to RPG Hero game"
                + "\n" + "\t \t \t \t \t" + "=========================="
                + "\n";
            this.Message = "\t \t \t \t \t" + "You must protect the kingdom!"
                + "\n" + "\t \t \t \t \t" + "Choose your profession and earn some experience."
                + "\n" + "\t \t \t \t \t" + "Be aware of hiding enemies!"
                + "\n" + "\t \t \t \t \t" + "Good luck brave Hero!!";
        }

       

        public void PrintHeader()
        {
            colors.ChangeFontColorToYellow();
            
            Console.WriteLine(Header);
        }
        public void PrintMessage()
        {
            colors.ChangeFontColorToRed();
            Console.WriteLine(Message);
        }
        




    }
}
