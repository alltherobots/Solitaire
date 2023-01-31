namespace SolitaireSolver.Models
{
    public class Board
    {
        public Column? Column1 { get; set; }
        public Column? Column2 { get; set; }
        public Column? Column3 { get; set; }
        public Column? Column4 { get; set; }
        public Column? Column5 { get; set; }
        public Column? Column6 { get; set; }
        public Column? Column7 { get; set; }
        public ArcanaBoard? ArcanaBoard { get; set; }
        public Foundation? Clubs { get; set; }
        public Foundation? Hearts { get; set; }
        public Foundation? Spades { get; set; }
        public Foundation? Diamonds { get; set; }
    }
}