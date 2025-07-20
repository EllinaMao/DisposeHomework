
namespace task2
{
    internal class Program{
    /*Задание 2
Создайте класс Магазин. Класс должен хранить такую информацию:

Название магазина;
Адрес магазина;
Тип магазина:
Продовольственный;
Хозяйственный;
Одежда;
Обувь.
Реализуйте в классе методы и свойства, необходимые для функционирования класса.

Класс должен реализовывать интерфейс IDisposable. Напишите код для тестирования функциональности класса.

Напишите код для вызова метода Dispose.*/
        static void Main(string[] args)
        {
            ClothingFactory store = new ClothingFactory();
            IStore clothingStore = store.CreateStore("Одежда", "Модный дом", "ул. Моды, 1");
            clothingStore.Display();
            clothingStore.Dispose();
            clothingStore.Display();
        }
    }
}
