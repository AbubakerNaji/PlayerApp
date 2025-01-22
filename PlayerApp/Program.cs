// See https://aka.ms/new-console-template for more information
using System;
namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = PlayerHandler.GetPlayers();
            Console.WriteLine("ID\tName\tTeam");
            Console.WriteLine("-----------------------");
            players.ForEach(p => Console.WriteLine($"{p.Id}\t{p.Name}\t{p.Team}"));
            Console.WriteLine(PlayerHandler.GetPlayer(1)?.ToString());
        }
    }
}
