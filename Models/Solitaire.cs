namespace SolitaireSolver.Models
{
    public class Solitaire
    {
        public Board? InitialState { get; set; }

        public Board? CurrentState { get; set; }

        public Board? SolvedState { get; set; }
    }
}