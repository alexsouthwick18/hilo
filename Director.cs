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
            Console.WriteLine("Would you like to draw a card? [y/n]");
            string drawDeck = Console.ReadLine();
            keepPlaying = (drawDeck == "y")
        }
        public void DoUpdates()
        {
            
        }
        public void DoOutputs()
        {
            
        }
}