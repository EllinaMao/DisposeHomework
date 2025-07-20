
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
 
            List<IStore> list = [];
            IStore groceryStore = new GroceryStore("Продукты", "ул. Продуктовая, 10");
            list.Add(groceryStore);

             IStore householdStore = new HouseholdStore("Хозтовары", "ул. Хозяйственная, 20");
            list.Add(householdStore);

            IStore clothingStore = new ClothingStore("Модный дом", "ул. Моды, 1");
            list.Add(clothingStore);

            IStore shoesStore = new ShoesStore("Обувной рай", "ул. Обувная, 5");
            list.Add(shoesStore);

            // Тестирование: вывод информации и вызов Dispose
            foreach (var store in list)
            {
                store.Display();
            }        
            foreach (var store in list)
            {
                store.Dispose();
            }

            Console.WriteLine("\nПосле удаления\n");
            foreach (var store in list)
            {
                store.Display();
            }

        }
    }
}
