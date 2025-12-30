using System;
class Program
{

    const int BOARD_SIZE = 100;
    // Snake head positions
    static int[] snakeStart = { 99, 70, 52, 25 };
    // Snake tail positions
    static int[] snakeEnd = { 41, 55, 10, 5 };
    // Ladder start positions
    static int[] ladderStart = { 6, 11, 60, 46 };
    // Ladder end positions
    static int[] ladderEnd = { 25, 40, 85, 90 };
    // Random object for dice
    static Random random = new Random();
    static void Main()
    {
        Console.WriteLine("WELCOME TO SNAKE & LADDER GAME\n");
        // Get number of players (2–4)
        int playerCount = GetPlayerCount();
        // Arrays to store player data
        string[] playerNames = new string[playerCount];
        int[] playerPositions = new int[playerCount];
        // Input player names
        for (int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter name for Player{i + 1}:");
            playerNames[i] = Console.ReadLine();
            playerPositions[i] = 0;//All players start at 0
        }
        Console.WriteLine("\nGame Started!\n");
        bool gameWon = false;
        while (!gameWon)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n{playerNames[i]}'s turn. Press ENTER to roll dice...");
                Console.ReadLine();
                int dice = RollDice();
                Console.WriteLine($"Dice Rolled: {dice}");
                int oldPosition = playerPositions[i];
                int newPosition = oldPosition + dice;
                // If move goes beyond 100, skip turn
                if (newPosition > BOARD_SIZE)
                {
                    Console.WriteLine("⚠ Move exceeds 100. Turn skipped.");
                    // Dice=6→extra turn
                    if (dice == 6)
                    {
                        Console.WriteLine("Dice was 6! Extra turn!");
                        i--;//same player again
                    }
                    continue;
                }
                // Update position
                playerPositions[i]=newPosition;
                // Apply snake or ladder
                playerPositions[i]=ApplySnakeOrLadder(playerPositions[i]);
                Console.WriteLine(
                    $"{playerNames[i]}moved from{oldPosition}→{playerPositions[i]}"
                );
                // Check winning condition
                if (CheckWin(playerPositions[i]))
                {
                    Console.WriteLine($"\n{playerNames[i]} WON THE GAME!");
                    gameWon=true;
                    break;//Exit game
                }
                // Dice=6→extra turn
                if (dice==6)
                {
                    Console.WriteLine("Dice was 6! Extra turn!");
                    i--; // same player again
                }
            }
        }
        Console.WriteLine("\nGame Over.Thanks for playing!");
    }
    // Get number of players between 2 and 4
    static int GetPlayerCount()
    {
        int count;
        do
        {
            Console.Write("Enter number of players(2 to 4):");
            count = int.Parse(Console.ReadLine());
        }
        while (count < 2 || count > 4);
        return count;
    }
    // Roll dice(1 to 6)
    static int RollDice()
    {
        return random.Next(1, 7);
    }
    // Apply snake or ladder if present
    static int ApplySnakeOrLadder(int position)
    {
        // Check ladders
        for (int i = 0; i < ladderStart.Length; i++)
        {
            if (position == ladderStart[i])
            {
                Console.WriteLine($"Ladder!Climb up to {ladderEnd[i]}");
                return ladderEnd[i];
            }
        }
        // Check snakes
        for (int i = 0; i < snakeStart.Length; i++)
        {
            if (position == snakeStart[i])
            {
                Console.WriteLine($"Snake! Slide down to {snakeEnd[i]}");
                return snakeEnd[i];
            }
        }
        // No snake or ladder
        return position;
    }
    // Check if player has won
    static bool CheckWin(int position)
    {
        // Ternary operator usage
        return position == BOARD_SIZE ? true : false;
    }
}
