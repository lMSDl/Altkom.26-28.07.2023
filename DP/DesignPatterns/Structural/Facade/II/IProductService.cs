using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Facade.II
{
    internal interface IProductService
    {
        float GetPrice(int productId);
    }
}
