
class Program
{
    static void Main()
    {
        // Приклад використання дженеричного репозиторію
        Repository<int> intRepository = new Repository<int>();

        intRepository.Add(5);
        intRepository.Add(10);
        intRepository.Add(15);

        // Критерій для пошуку парних чисел
        Repository<int>.Criteria<int> evenNumbersCriteria = x => x % 2 == 0;

        // Знайдемо всі парні числа
        List<int> evenNumbers = intRepository.Find(evenNumbersCriteria);

        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
