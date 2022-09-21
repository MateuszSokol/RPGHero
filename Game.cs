using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHero
{
    public class Game
    {
        LinkedList<EQUIPMENT_TYPES> Equipment;
        Player player;
        GUI gui;

        private void InitVariables()
        {
            this.Equipment = new LinkedList<EQUIPMENT_TYPES>();
            this.player = new Player(100, 100, 0, Equipment, 0);
            this.gui = new GUI();
        }
        private void InitGUITitleScreen()
        {
            gui.PrintHeader();
            gui.PrintMessage();
            gui.colors.DeafultForegroundColor();
        }

        public void Run()
        {
            InitVariables();
            InitGUITitleScreen();
            Console.WriteLine("Hello natalia");            
           
        }
    }
}
