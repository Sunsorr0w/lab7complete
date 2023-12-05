class Program
{
    static void Main()
    {
        // Example usage with int
        Calculator<int> intCalculator = new Calculator<int>();
        intCalculator.PerformOperations(5, 3);

        Console.WriteLine();

        // Example usage with double
        Calculator<double> doubleCalculator = new Calculator<double>();
        doubleCalculator.PerformOperations(7.5, 2.5);
    }
}
