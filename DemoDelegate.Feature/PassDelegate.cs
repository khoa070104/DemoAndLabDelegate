using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate.Feature
{
    


    public class PassDelegate
    {
        public static void Print(string message) => Console.WriteLine("Notification: " + message);
        public static void Error(string message) => Console.WriteLine("Error: "+message);
        public void Excute()
        {
            Message m = Print;
            m("Chuc thay Quang suc khoe");
            m = Error;
            m("Try again!");
        }
    }
}
