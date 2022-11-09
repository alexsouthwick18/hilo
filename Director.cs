using System;


class Director
{ 
    private String _response;
    private int _firstCard;
    int oldCard = 0;
    bool keepPlaying = true;
    bool hasStarted = true;
    public void StartGame()
    {
        
        Random numberGen = new Random();
        _firstCard = numberGen.Next(1,14);
        Console.Write($"Card: {_firstCard}\n");
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
        _response = Console.ReadLine();
    }
    
    public void DoUpdates()
    {
        
        int card = 0;
        if (hasStarted)
        {
            oldCard = _firstCard;
        }
        ///prevent to have an equal card to the old
        do{
            Random numberGen = new Random();
            card = numberGen.Next(1,14);
        }while(card==oldCard);

        Console.WriteLine($"card: {oldCard} --> next card: {card}");
        
        
        if(_response == "H")
        {
            if (card > oldCard)
            {
                score += 100;

                Console.WriteLine($"You guessed right 100 points added to score. \nscore:{score} ");
            }
        
            else if (card < oldCard)    
            {
                score -= 100;

                Console.WriteLine($"You guessed wrong 100 points subtracted to score. \nscore:{score}");
            }
        }
        if(_response == "L")
        {
             if (card > oldCard)
            {
                score -= 100;

                Console.WriteLine($"You guessed wrong 100 points subtracted to score. \nscore:{score}");
            }
        
            else if (card < oldCard)    
            {
                score += 100;
                Console.WriteLine($"You guessed right 100 points added to score. \nscore:{score} ");

            }

            
        }

        oldCard = card;
     
    }
    public void DoOutputs()
    {
        hasStarted = false;
        if (score == 0){
            keepPlaying = false;
            Console.WriteLine($"Game Over");
        }
    }
}
