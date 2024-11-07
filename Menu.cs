using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Console_Menu
{
    internal class Menu
    {
        //Internal tracking for menu title and menu items/selected item
        private int selectedOption;
        private string[] options;
        private string prompt;
        //Constructor for building menus
        public Menu(string argPrompt, string[] argOptions)
        {
            prompt = argPrompt;
            options = argOptions;
            selectedOption = 0;
        }
        //Displaying the menu
        private void DisplayOptions()
        {
            Console.WriteLine(prompt);//Menu title
            Console.WriteLine("-----------------");
            for (int i = 0; i < options.Length; i++)//New line for every # of items
            {
                string currentOption = options[i];
                string prefix;
                if (i == selectedOption)//Colors selected option white
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix} << {currentOption} >>");//Formatting for selected option
            }
            Console.ResetColor();//Reset colors just for any other colored items used in future
        }
        public int Run()//Internals of menu function
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();//Clear console to allow re-render with new selection
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)//Decreases selectedOption on UpArrow
                {
                    selectedOption--;
                    if (selectedOption == -1)//Moves cursor to last item if go above top item
                    {
                        selectedOption = options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)//Increases selectedOption on DownArrow
                {
                    selectedOption++;
                    if (selectedOption == options.Length)//Moves cursor to first item if go below bottom item
                    {
                        selectedOption = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);//Runs menu until press enter


            return selectedOption;//When loop ends(press enter), return current selectedOption
        }

    }
}
