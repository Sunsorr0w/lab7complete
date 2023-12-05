using System;

public class Calculator<T>
{
    // Define delegates for basic arithmetic operations
    public delegate T AddDelegate(T a, T b);
    public delegate T SubtractDelegate(T a, T b);
    public delegate T MultiplyDelegate(T a, T b);
    public delegate T DivideDelegate(T a, T b);

    // Initialize delegates
    public AddDelegate Add { get; set; }
    public SubtractDelegate Subtract { get; set; }
    public MultiplyDelegate Multiply { get; set; }
    public DivideDelegate Divide { get; set; }

    // Constructor to initialize delegates
    public Calculator()
    {
        // Default implementations for delegates
        Add = (a, b) => (dynamic)a + b;
        Subtract = (a, b) => (dynamic)a - b;
        Multiply = (a, b) => (dynamic)a * b;
        Divide = (a, b) => (dynamic)a / b;
    }

    // Method to perform arithmetic operations
    public void PerformOperations(T operand1, T operand2)
    {
        Console.WriteLine($"Operand 1: {operand1}");
        Console.WriteLine($"Operand 2: {operand2}");
        Console.WriteLine($"Addition: {Add(operand1, operand2)}");
        Console.WriteLine($"Subtraction: {Subtract(operand1, operand2)}");
        Console.WriteLine($"Multiplication: {Multiply(operand1, operand2)}");
        Console.WriteLine($"Division: {Divide(operand1, operand2)}");
    }
}
