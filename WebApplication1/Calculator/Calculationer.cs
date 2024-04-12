namespace WebApplication1.calculator
{
    public class Calculation
    {

        public double Calculate(string Operation, double Number1, double Number2) 
        {

            return Operation switch
            {
                "add" => Addition.Add(Number1, Number2),
                "subtract" => Subtraction.Subtract(Number1, Number2),
                "multiply" => Multiplication.Multiply(Number1, Number2),
                "divide" => Number2 == 0 ? throw new Exception("Can not divide by zero.") : Division.Divide(Number1, Number2),
                _ => throw new Exception("Invalid operation.")
            };
        }
    }
}
