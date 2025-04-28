using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class HotPotatoGameSimulation
    {
        public void Run()
        {
            Console.Write("Enter the number of players: ");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            Console.Write("Enter the elimination interval (e.g., every 3rd player): ");
            int eliminationInterval = int.Parse(Console.ReadLine());

            PlayHotPotatoGame(numberOfPlayers, eliminationInterval);
        }

        private static void Main(string[] args)
        {
            HotPotatoGameSimulation game = new HotPotatoGameSimulation();
            game.Run();
        }

        private void PlayHotPotatoGame(int numberOfPlayers, int eliminationInterval)
        {
            Queue<string> playersQueue = new Queue<string>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                playersQueue.Enqueue($"Player {i}");
            }

            Stack<string> eliminatedPlayers = new Stack<string>();

            while (playersQueue.Count > 1)
            {
                for (int i = 1; i < eliminationInterval; i++)
                {
                    string currentPlayer = playersQueue.Dequeue();
                    playersQueue.Enqueue(currentPlayer);
                }

                string eliminatedPlayer = playersQueue.Dequeue();
                eliminatedPlayers.Push(eliminatedPlayer);
                Console.WriteLine($"{eliminatedPlayer} is eliminated!");
            }

            string winner = playersQueue.Dequeue();
            Console.WriteLine($"The winner is {winner}");

            Console.WriteLine("\nOrder of elimination:");
            while (eliminatedPlayers.Count > 0)
            {
                Console.WriteLine(eliminatedPlayers.Pop());
            }
        }
    }
}