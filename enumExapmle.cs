using System;
using System.Linq;

class Program
{
    enum ProgramState
    {
        MainMenu,
        HelpMenu,
        Quitting
    }

    static void Main()
    {
        ProgramState state = ProgramState.MainMenu;
        int userInput;

        while (state != ProgramState.Quitting)
        {
            switch(state)
            {
                case ProgramState.MainMenu:
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("[1] - Help]");
                    Console.WriteLine("[2] - Quit");
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        state = ProgramState.HelpMenu;
                    }

                    if (userInput == 2)
                    {
                        state = ProgramState.Quitting;
                    }

                    break;

                case ProgramState.HelpMenu:
                    Console.WriteLine("Help Menu!");
                    Console.WriteLine("Hit enter to go back");
                    Console.ReadLine();

                    state = ProgramState.MainMenu;
                    break;
            }
        }

        Console.WriteLine("Program is finished");
        Console.readKey();
    }
}