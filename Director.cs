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
<<<<<<< HEAD
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
=======

>>>>>>> cf601b90baa215fb16ff73cafb1d3c83f81dbaf3
    }
    public void DoOutputs()
    {
        
    }
}
