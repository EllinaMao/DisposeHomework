using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTask1
{/*Создайте класс Пьеса. Класс должен хранить такую информацию:

Название пьесы;
ФИО автора;
Жанр;
Год выпуска.
Реализуйте в классе методы и свойства, необходимые для функционирования класса. Добавьте в классе деструктор. Напишите код для тестирования функциональности класса. Напишите код для проверки работы деструктора (например, создание и удаление объектов).*/
    public class Play : IEnumerable<Play>, IDisposable
    {
        public string PlayName { get; set; }
        public string AutorName { get; set; }
        public string PlayGenre { get; set; }
        public DateOnly YearOfRelease { get; set; }

        public Play()
        {
            PlayName = string.Empty;
            AutorName = string.Empty;
            PlayGenre = string.Empty;
            YearOfRelease = DateOnly.MinValue;

        }
        public Play(string playName, string autorName, string playGenre, string dateOnly)
        {
            PlayName = playName;
            AutorName = autorName;
            PlayGenre = playGenre;
            try
            {
                YearOfRelease = DateOnly.Parse(dateOnly, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                YearOfRelease = DateOnly.MinValue;
            }
        }
        public Play(string playName, string autorName, string playGenre, DateOnly dateOnly)
        {
            PlayName = playName;
            AutorName = autorName;
            PlayGenre = playGenre;
            YearOfRelease = dateOnly;


        }

        public IEnumerator<Play> GetEnumerator()
        {
           yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return $"Название: {PlayName}, Имя автора: {AutorName}, Жанр: {PlayGenre}, Дата выхода: {YearOfRelease}";
        }

        public void Dispose()
        {
            Console.WriteLine("Выносим мусор!");
            PlayName = string.Empty;
            AutorName = string.Empty;
            PlayGenre = string.Empty;
            YearOfRelease = DateOnly.MinValue;
            GC.SuppressFinalize(this); // Отключает вызов финализатора
        }

        ~Play()
        {
            Console.WriteLine("Finalizator");
            PlayName = string.Empty;
            AutorName = string.Empty;
            PlayGenre = string.Empty;
            YearOfRelease = DateOnly.MinValue;

        }







    }
}
