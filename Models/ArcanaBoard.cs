namespace SolitaireSolver.Models
{
    public class ArcanaBoard
    {
        public List<Card>? Cards { get; set; }
        //Add logic for all of these
        public Card? LowestCard { get; set; }
        public Card? HighestCard { get; set; }
        public int NumberOfCards {get; set; }

    }
}