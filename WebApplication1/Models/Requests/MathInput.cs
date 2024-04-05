namespace WebApplication1.Models.Requests;
// Moved into its own file and folders.

    public class MathInput
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public required string Operation { get; set; } // Renamed to operation. I try to avoid shortened variable names unless the word is hard to spell.
    }
