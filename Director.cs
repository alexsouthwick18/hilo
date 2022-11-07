using System;


class Director
{
    bool keepPlaying = true;
    public void StartGame()
    {
        Random numberGen = new Random();
        int firstCard = numberGen.Next(1,14);
        Console.Write(firstCard);
        while (keepPlaying)
        {
            
            GetInputs();
            DoUpdates();
            DoOutputs();
        }
    }
    Deck deck = new Deck();
    public int score = 300;
    public void GetInputs()
    {   
        
        Console.Write("\nIs the next card going to be Higher or Lower? (H/L) ");
        string response = Console.ReadLine();
    }
    
    public void DoUpdates()
    {
        Random numberGen = new Random();

        int card = 0;

        while (card == 0) {
            card = numberGen.Next(1,14);
            Console.WriteLine(card);
        }

    }
    public void DoOutputs()
    {
        
    }
}
