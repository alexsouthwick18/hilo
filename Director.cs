using System;

class Director
{
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

    }
    public void DoUpdates()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    public void DoOutputs()
    {
        
    }
}