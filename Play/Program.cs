using System.Numerics;

namespace PlayTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание и тестирование объектов Play
            Play play1 = new("Гамлет", "Уильям Шекспир", "Трагедия", "1600-01-01");
  
            Console.WriteLine(play1);
           
            play1.Dispose();

            Console.WriteLine(play1);
            // Создание списка пьес
            List<Play> plays =
                [
                    new("Вишнёвый сад", "Антон Чехов", "Драма", "1904-01-01"),
                    new("На дне", "Максим Горький", "Драма", "1902-01-01")
                ];

            foreach (var play in plays)
            {
                Console.WriteLine(play);
                play.Dispose();
            }
        }
    }
}
