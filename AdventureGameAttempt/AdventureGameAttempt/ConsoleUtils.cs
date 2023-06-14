using System;
using static System.Console;

namespace AdventureGameAttempt;

public static class ConsoleUtils
{
    public static void QuitTheGame()
    {
        WriteLine("Press any key to exit.");
        ReadKey(true);
        Environment.Exit(0);
    }
}