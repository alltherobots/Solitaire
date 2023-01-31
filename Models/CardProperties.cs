namespace SolitaireSolver.Models
{
    public class CardProperties
    {
        public enum CardValues
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public enum CardSuits
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts
        }

        public enum CardType
        {
            Standard,
            Arcana
        }
    }
}
