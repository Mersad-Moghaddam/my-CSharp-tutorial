using System;

class HotPotatoGameSimulation
{
    static void Main()
    {
        Console.Clear();
        
        HotPotatoGameSimulation game = new();
        game.Run();
    }

    private void PlayHotPotatoGame(int numberOfPlayers, int eliminationInterval)
    {
        Queue<string> playersQueue = new();

        for (int i = 1; i <= numberOfPlayers; i++)
        {
            playersQueue.Enqueue($"Player {i}");
        }

        Stack<string> eliminatedPlayers = new();

        while (playersQueue.Count > 1)
        {
            for (int i = 1; i < eliminationInterval; i++)
            {
                string currentPlayer = playersQueue.Dequeue();
                playersQueue.Enqueue(currentPlayer);
            }
            string eliminatedPlayer = playersQueue.Dequeue();
            eliminatedPlayers.Push(eliminatedPlayer);
            Console.WriteLine($"{eliminatedPlayer} is Eliminated !");

        }

        string winner = playersQueue.Dequeue();
        Console.WriteLine($"The winner is {winner}");
        Console.WriteLine($"----------------");
        Console.WriteLine($"Eliminated Order :");

        int counter = 1;
        while (eliminatedPlayers.Count > 0)
        {
            Console.WriteLine($"{counter}. {eliminatedPlayers.Pop()}");
            counter++;

        }

    }

    public void Run()
    {
        Console.Write($"Enter the Number of Players : ");
        int numberOfPlayers = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the Elimination interval (e.g , every 3rd player) : ");
        int eliminationInterval = int.Parse(Console.ReadLine());


        PlayHotPotatoGame(numberOfPlayers, eliminationInterval);
        
        
    }
}