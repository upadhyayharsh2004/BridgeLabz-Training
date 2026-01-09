using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
class ATMDispenser
{
    private int[] denominations;

    // Constructor receives denominations as-is (no sorting done)
    public ATMDispenser(int[] denominations)
    {
        this.denominations = denominations;
    }

    public void Dispense(int amount)
    {
        Console.WriteLine($"\nRequested: ₹{amount}");
        int remaining = amount;

        // Array to store note quantities
        int[] noteCount = new int[denominations.Length];

        // Greedy algorithm: use largest notes first
        for (int i = 0; i < denominations.Length; i++)
        {
            if (denominations[i] <= remaining)
            {
                noteCount[i] = remaining / denominations[i];
                remaining %= denominations[i];
            }
        }

        // Check if exact amount is obtained
        if (remaining == 0)
        {
            DisplayResult(noteCount);
        }
        else
        {
            Console.WriteLine($"⚠ Exact amount not possible! Remaining = ₹{remaining}");
            DisplayFallback(noteCount, remaining);
        }
    }

    private void DisplayResult(int[] noteCount)
    {
        Console.WriteLine("Optimal Note Distribution:");
        for (int i = 0; i < denominations.Length; i++)
        {
            if (noteCount[i] > 0)
            {
                Console.WriteLine($"₹{denominations[i]} x {noteCount[i]}");
            }
        }
    }

    private void DisplayFallback(int[] noteCount, int remaining)
    {
        Console.WriteLine("Fallback Notes Provided:");
        DisplayResult(noteCount);
        Console.WriteLine($"Unfulfilled Balance: ₹{remaining}");
    }
}


// MAIN PROGRAM
class ATMDispenserDetails
{
    static void Main(string[] args)
    {
        // SCENARIO A: Full denominations (already in descending order)
        Console.WriteLine("=== SCENARIO A ===");
        int[] fullNotes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        ATMDispenser atmA = new ATMDispenser(fullNotes);
        atmA.Dispense(880);

        // SCENARIO B: Remove ₹500 temporarily
        Console.WriteLine("\n=== SCENARIO B (₹500 removed) ===");
        int[] no500 = { 200, 100, 50, 20, 10, 5, 2, 1 };
        ATMDispenser atmB = new ATMDispenser(no500);
        atmB.Dispense(880);

        // SCENARIO C: Exact change not possible
        Console.WriteLine("\n=== SCENARIO C (Fallback example) ===");
        int[] limitedNotes = { 50, 10, 5 }; // cannot make ₹93 exactly
        ATMDispenser atmC = new ATMDispenser(limitedNotes);
        atmC.Dispense(93);
    }
}
