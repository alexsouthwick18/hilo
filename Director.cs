using System;


class Director
{ 
    private String _response;
    private int _firstCard;

    bool keepPlaying = true;
    public void StartGame()
    {
        
        Random numberGen = new Random();
        _firstCard = numberGen.Next(1,14);
        Console.Write(_firstCard);
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
        Random numberGen = new Random();

        int card = 0;

        while (card == 0) {

            card = numberGen.Next(1,14);

            Console.WriteLine(card);
        }
        
        if(_response == "H")
        {
            if (card > _firstCard)
            {
                score += 100;

                Console.WriteLine($"You guessed right 100 points added to score. \n your score is {score} ");
                _firstCard = card;
            }
        
            else if (card < _firstCard)    
            {
                score -= 100;

                Console.WriteLine($"You guessed wrong 100 points subtracted to score. \n your score is {score}");
                _firstCard = card;
            }
        }
        if(_response == "L")
        {
             if (card > _firstCard)
            {
                score -= 100;

                Console.WriteLine($"You guessed wrong 100 points subtracted to score. \n your score is {score}");
                _firstCard = card;
            }
        
            else if (card < _firstCard) 
            {
                score += 100;
                Console.WriteLine($"You guessed right 100 points added to score. \n your score is {score} ");
                _firstCard = card;
            }
        }
        if (score <= 0)
        {
            keepPlaying = false;
        }


     
    }
    public void DoOutputs()
    {
        
    }
}