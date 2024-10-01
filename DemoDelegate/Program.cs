using DemoDelegate.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDelegate.Feature;
using System.Xml.Linq;

namespace DemoDelegate
{
    public class Program
    {
        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Test Declare Delegate");
            Console.WriteLine("2. Test Pass Delegate");
            Console.WriteLine("3. Test Multi Delegate");
            Console.WriteLine("4. Test Anonymous Method");
            Console.WriteLine("5. Test Generic Delegate");
            Console.WriteLine("6. Quit");
        }
        static void Main(string[] args)
        {
            // TEST :

            var a = 5; var b = 6;
            int choice = 0;
            do
            {

                Menu();
                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1: DeclareDelegate test = new DeclareDelegate();
                        test.Excute(a,b);
                        break;
                    case 2:
                        PassDelegate test2 = new PassDelegate();
                        test2.Excute();
                        break;
                    case 3:
                        MultiDelegate test3 = new MultiDelegate();
                        test3.Excute();
                        break;
                    case 4:
                        AnonymousMethod test4 = new AnonymousMethod();
                        test4.Excute(a,b);
                        break;
                    case 5: 
                        GenericDelegate test5 = new GenericDelegate();
                        Console.Write("Enter a number to check Perfect number: ");
                        int value = int.Parse(Console.ReadLine());
                        test5.Excute(value);
                        break;
                    default: Console.WriteLine("Enter again"); break;
                }
            } while (choice != 6);
            
        }
    }
    


}
