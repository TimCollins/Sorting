﻿using System;

namespace ConsoleApp
{
    class Util
    {
        /// <summary>
        /// Waits for the Escape key to be pressed by the user.
        /// </summary>
        /// <param name="prompt">An optional parameter giving the text to prompt the user with.</param>
        public static void WaitForEscape(string prompt = "Please press Escape to exit...")
        {
            Console.WriteLine(prompt);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while (cki.Key != ConsoleKey.Escape)
            {
                cki = Console.ReadKey(true);
            }
        }
    }
}
