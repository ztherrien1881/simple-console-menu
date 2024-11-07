using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Console_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Menu Title";//Set your prompt
            string[] options = { "Option 1", "Option 2", "Option 3" };//Set your options

            Menu exampleMenu = new Menu(prompt, options);//Call new menu with set args
            int selectedOption = exampleMenu.Run();//Run the menu

            Console.ReadKey();


        }




    }
}
