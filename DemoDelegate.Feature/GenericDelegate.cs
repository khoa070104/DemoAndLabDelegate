using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate.Feature
{
    public class GenericDelegate
    {
        public void Excute(int a)
        {
            Func<int, int> func = (x) => x == Math.Pow((int)Math.Sqrt(x), 2)? 1 : 0;
            if (func(a) == 1) {
                Console.WriteLine("This is Perfect Number");
            } else
            {
                Console.WriteLine("This is not Perfecr Number");
            }
        }
    }
}
