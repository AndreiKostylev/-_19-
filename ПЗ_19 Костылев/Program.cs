namespace ПЗ_19_Костылев
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new LargeProduct("Мебель", 100, 10, 50);
            Product product2 = new MediumProduct("Электроника", 5, 2, 10);
            Product product3 = new SmallProduct("Книги", 2, 1, 5);
            Product product4 = new LargeProduct("Холодильник", 200, 20, 100);
            Product product5 = new MediumProduct("Одежда", 3, 1, 15);
            Product product6 = new SmallProduct("Аксессуары", 1, 0.5, 8);
            Product product7 = new LargeProduct("Машина", 1500, 50, 500);
            Product product8 = new MediumProduct("Игрушки", 2.5, 1.5, 12);
            Product product9 = new SmallProduct("Канцелярия", 1.2, 0.7, 7);
            Product product10 = new LargeProduct("Телевизор", 150, 15, 80);

            // Вызов методов для каждого товара
            Console.WriteLine("Расчет стоимости доставки для товара 1(Мебель): " + product1.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 2(Электроника): " + product2.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 3(Книги): " + product3.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 4(Холодильник): " + product4.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 5(Одежда): " + product5.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 6(Аксессуары): " + product6.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 7(Машина): " + product7.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 8(Игрушки): " + product8.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 9(Канцелярия): " + product9.CalculateDeliveryCost());
            Console.WriteLine("Расчет стоимости доставки для товара 10(Телевизор): " + product10.CalculateDeliveryCost());

            // Проверка операторов сравнения
            Console.WriteLine("Имеет ли товар 1 такую же стоимость доставки, как и товар 2? " + (product1 == product2));
            Console.WriteLine("Стоимость доставки товар 1 больше стоимости доставки товара 4? " + (product1 > product4));
            Console.WriteLine("Стоимость доставки товара 5 не равна стоимости доставки товара 3? " + (product5 != product3));
            Console.WriteLine("Стоимость доставки товара 7 больше, либо равна стоимости доставки товара 10? " + (product7 >= product10));
            Console.WriteLine("Стоимость доставки товара 4 меньше стоимости доставки товара 9? " + (product4 < product9));
            Console.WriteLine("Стоимость доставки товара 6 меньше, либо равна стоимости доставки товара 8? " + (product6 <= product8));
            double totalWeight = 0;
            totalWeight = totalWeight + product1 + product3 + product4 + product5 + product6 + product7 + product8 + product9 + product10;
            Console.WriteLine("Общий вес товаров: " + totalWeight);
        }
    }
}

