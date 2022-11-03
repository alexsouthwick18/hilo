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
        keepPlaying = (response == "y");
    }
    public void DoUpdates()
    {
        
    }
    public void DoOutputs()
    {
        
    }
}
