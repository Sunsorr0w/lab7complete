using System;
using System.Collections.Generic;

public class Repository<T>
{
    private List<T> elements;

    public Repository()
    {
        elements = new List<T>();
    }

    // Делегат для критерію
    public delegate bool Criteria<TT>(T item);

    // Метод для додавання елементів
    public void Add(T item)
    {
        elements.Add(item);
    }

    // Метод для пошуку елементів за критерієм
    public List<T> Find(Criteria<T> criteria)
    {
        List<T> result = new List<T>();

        foreach (var item in elements)
        {
            if (criteria(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}
