// Program.cs
using System;
using System.Threading;

class Program
{
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }

    static void GreetUser(User user)
    {
        Console.WriteLine($"Привет, {user.Name}!");

        if (!user.IsPremium)
        {
            ShowAds();
        }
    }

    static void Main(string[] args)
    {
        // Пример списка пользователей
        var users = new User[]
        {
            new User { Login = "user1", Name = "Иван", IsPremium = true },
            new User { Login = "user2", Name = "Мария", IsPremium = false },
            new User { Login = "user3", Name = "Алексей", IsPremium = true },
            new User { Login = "user4", Name = "Ольга", IsPremium = false }
        };

        // Приветствуем каждого пользователя
        foreach (var user in users)
        {
            GreetUser(user);
            Console.WriteLine(); // Добавляем пустую строку между пользователями для читаемости
        }
    }
}