using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate.Feature
{
    public delegate void Message(string message);
    public  class MultiDelegate
    {
        public static void Parent(string message) => Console.WriteLine("Parent said: "+message);
        public static void Child(string message) => Console.WriteLine("Child rep: " + message);
        public void Excute()
        {
            Message? test = Parent;
            test("Mr Quang co tuyen voi khong ?");
            test -= Parent;
            test += Child;
            test += Child;
            test("Qua tuyet voi la qua tuyet voi");

        }
    }

}
