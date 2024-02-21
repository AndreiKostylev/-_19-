using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_19_Костылев
{
    internal class LargeProduct : Product
    {
        public LargeProduct(string name, double weight, double volume, double deliveryCost)
            : base(name, weight, volume, deliveryCost)
        {
        }

        public override double CalculateDeliveryCost()
        {
            return DeliveryCost * 1.5; // увеличение стоимости на коэффициент 1,5
        }
    
    }
}
