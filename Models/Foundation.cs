namespace SolitaireSolver.Models
{
    public class Foundation
    {
        public List<Card>? Cards { get; set; }
        //Add some logic for this
        public Card? BottomCard { get; set; }
        public CardProperties.CardSuits? CardSuit { get; set; }
        

    }
}