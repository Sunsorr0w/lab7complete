using System;
using System.Collections.Generic;

public class FunctionCache<TKey, TResult>
{
    private readonly Dictionary<TKey, CacheItem<TResult>> cache = new Dictionary<TKey, CacheItem<TResult>>();

    // Делегат для користувацької функції
    public delegate TResult FuncDelegate(TKey key);

    // Клас для збереження результатів та часу їхньої дії
    private class CacheItem<T>
    {
        public T Result { get; set; }
        public DateTime ExpirationTime { get; set; }
    }

    // Метод для виконання функції та збереження результату в кеші
    public TResult GetOrAdd(TKey key, FuncDelegate func, TimeSpan expirationTime)
    {
        if (cache.TryGetValue(key, out var cacheItem) && DateTime.Now < cacheItem.ExpirationTime)
        {
            // Використовуємо результат з кешу, якщо він ще дійсний
            return cacheItem.Result;
        }

        // Виконуємо користувацьку функцію
        TResult result = func(key);

        // Зберігаємо результат та час його дії в кеші
        cache[key] = new CacheItem<TResult>
        {
            Result = result,
            ExpirationTime = DateTime.Now.Add(expirationTime)
        };

        return result;
    }
}

