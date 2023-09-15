using System;
using System.Collections.Generic;

namespace List_Pelky_Annalesa

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // makes a list of 5 games
            List<string> games = new List<string>
           {
               "Sally Face",
               "Resident Evil 7",
               "DDLC",
               "Omari",
               "Minecraft",
           };
            // adds 2 more games to the list
            string[] otherGames = new string[]
            {
                "Spiderman PS4",
                "Portal"
            };

            // loops all of the games in a list
            foreach(string game in games)
            {
                Console.WriteLine(game);
            }
            // adds 5 games to a list and counts them
            Console.WriteLine($"\nGames in list: {games.Count}");
            // adds the 2 other games
            games.AddRange(otherGames);
            //makes the list 5 to 7
            Console.WriteLine($"\nGames in list: {games.Count}");
            // if the list contains sally face, it will print ASH CAMPBLE SUCKS
            if(games.Contains("Sally Face"))
            {
                Console.WriteLine("\nASH CAMPBLE SUCKS!");
            }
            else
            // if list doesnt have sally face, it will make the list 6 instead of 7 
            {
                games.Add("Sally Face");
            }

            int myInt = 6;

            // if the int value is less than the number of games, it will remove the game at index 6 of the games list.
            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }
            // says All games in the list: at the top of the console
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            // will sort the games list
            games.Sort();

            // will print Sorted Games list: above the sorted games list
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            // makes a new list of the games 
            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();
            // prints New List: about the new list
            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}