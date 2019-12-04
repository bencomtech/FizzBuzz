using Microsoft.Extensions.DependencyInjection;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = RegisterServiceCollection();
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            FizzBuzzService service = serviceProvider.GetService<FizzBuzzService>();

            for (int number = 1; number <= 100; number++)
            {
                string text = service.GetText(number);

                Console.WriteLine(text);
            }

            Console.Write("Press any key to close app...");
            Console.ReadKey();
        }

        private static ServiceCollection RegisterServiceCollection()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<FizzBuzzService>();

            return serviceCollection;
        }
    }
}
