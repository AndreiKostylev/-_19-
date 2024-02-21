using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_19_Костылев
{
    internal class SmallProduct : Product
    {
        public SmallProduct(string name, double weight, double volume, double deliveryCost)
            : base(name, weight, volume, deliveryCost)
        {
        }

        public override double CalculateDeliveryCost()
        {
            return DeliveryCost * 0.8; // увеличение стоимости на коэффициент 0,8
        }
    
    }
}
