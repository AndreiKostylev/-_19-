using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_19_Костылев
{
    internal class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double DeliveryCost { get; set; }

        public Product(string name, double weight, double volume, double deliveryCost)
        {
            Name = name;
            Weight = weight;
            Volume = volume;
            DeliveryCost = deliveryCost;
        }

        // Виртуальный метод расчета условий доставки товара
        public virtual double CalculateDeliveryCost()
        {
            return DeliveryCost;
        }

 

        // Перегрузка операторов сравнения по полю стоимости доставки
        public static bool operator ==(Product product1, Product product2)
        {
            return product1.DeliveryCost == product2.DeliveryCost;
        }

        public static bool operator !=(Product product1, Product product2)
        {
            return !(product1 == product2);
        }

        public static bool operator >(Product product1, Product product2)
        {
            return product1.DeliveryCost > product2.DeliveryCost;
        }

        public static bool operator <(Product product1, Product product2)
        {
            return product1.DeliveryCost < product2.DeliveryCost;
        }

        public static bool operator >=(Product product1, Product product2)
        {
            return product1.DeliveryCost >= product2.DeliveryCost;
        }

        public static bool operator <=(Product product1, Product product2)
        {
            return product1.DeliveryCost <= product2.DeliveryCost;
        }
        // Перегрузка оператора сложения для подсчета общего веса товаров
        public static double operator +(double totalWeight, Product product)
        {
            return totalWeight + product.Weight;
        }
        // Перегрузка оператора вычитания для подсчета общего веса товаров
        public static double operator -(double totalWeight, Product product)
        {
            return totalWeight - product.Weight;
        }
    }
}

