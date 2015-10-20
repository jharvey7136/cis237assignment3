using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//John Harvey - CIS237 Assignment 3 - Due:10/20/15
//Droid program for The Jawas on Tatooin

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int windowheight = 60;
            int windowwidth = 160;
            UserInterface MainMenu = new UserInterface();

            Console.BufferHeight = 8000;
            Console.BufferWidth = 100;
            Console.SetWindowSize(windowwidth, windowheight);

            MainMenu.MainMenu();
        }
    }
}
