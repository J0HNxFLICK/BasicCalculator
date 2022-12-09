namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C A L C U L A T O R ");
            Brain calculator = new Brain();
            Console.WriteLine("Enter first value : ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first value : ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            calculator.addition(firstValue, secondValue);
            calculator.substraction(firstValue, secondValue);
        }
    }
}