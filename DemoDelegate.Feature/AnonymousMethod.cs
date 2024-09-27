using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate.Feature
{
    
    public class AnonymousMethod
    {
        public void Excute(int a, int b)
        {
            TestDelegate test = (x, y) => x * y;
            Console.WriteLine($"Multiple: {test(a,b)}");
            test = (x, y) => y!= 0 ? x / y : 0;
            Console.WriteLine($"Divide: {test(a,b)}");
        }
    }
}
