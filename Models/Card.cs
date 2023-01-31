using static SolitaireSolver.Models.CardProperties;

namespace SolitaireSolver.Models
{
    public class Card
    {
        public CardValues Value { get; set; }
        public CardSuits Suit { get; set; }
        public CardType Type { get; set; }
        public int ArcanaValue { get; set; }
    }
}