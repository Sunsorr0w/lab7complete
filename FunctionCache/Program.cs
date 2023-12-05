
class Program
{
    static void Main()
    {
        // Приклад використання дженеричного кешу
        FunctionCache<string, int> cache = new FunctionCache<string, int>();

        // Користувацька функція для отримання довжини рядка
        FunctionCache<string, int>.FuncDelegate stringLengthFunc = key => key.Length;

        // Отримуємо довжину рядка та кешуємо результат
        int length1 = cache.GetOrAdd("Hello", stringLengthFunc, TimeSpan.FromSeconds(5));
        Console.WriteLine($"Length of 'Hello': {length1}");

        // Отримуємо довжину рядка з кешу
        int length2 = cache.GetOrAdd("Hello", stringLengthFunc, TimeSpan.FromSeconds(5));
        Console.WriteLine($"Length of 'Hello' from cache: {length2}");

        // Отримуємо довжину іншого рядка з кешу
        int length3 = cache.GetOrAdd("World", stringLengthFunc, TimeSpan.FromSeconds(5));
        Console.WriteLine($"Length of 'World' from cache: {length3}");
    }
}
