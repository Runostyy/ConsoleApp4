using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Створення колекції з 10 різних доменних імен сайтів
        List<string> websites = new List<string>
        {
            "google.com",
            "yahoo.com",
            "google.co.uk",
            "bing.com",
            "google.ca",
            "amazon.com",
            "google.com.au",
            "facebook.com",
            "google.fr",
            "github.com"
        };

        // Запит LINQ для вибору сайтів, що починаються з "google"
        var googleWebsites = websites.Where(website => website.StartsWith("google", StringComparison.OrdinalIgnoreCase)).ToList();

        // Виведення результатів
        Console.WriteLine("Сайти, що починаються з 'google':");
        foreach (var site in googleWebsites)
        {
            Console.WriteLine(site);
        }
    }
}
