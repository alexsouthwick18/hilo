using System;

class Director
{
    bool keepPlaying = true;
    public void StartGame()
    {
        while (keepPlaying)
        {
            GetInputs();
            DoUpdates();
            DoOutputs();
        }
    }
    public void GetInputs()
    {
        Console.Write("Is the next card going to be Higher or Lower? ");
        string response = Console.ReadLine();
    }
    public void DoUpdates()
    {
        Random numberGen = new Random();

        int card = 0;

        while (card == 0) {
            card = numberGen.Next(1,14);
            Console.WriteLine();
        }

    }
    public void DoOutputs()
    {
        
    }
}
