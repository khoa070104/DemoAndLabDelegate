namespace DemoDelegate.Feature
{
    public delegate int TestDelegate(int x, int y);

    public class DeclareDelegate
    {
        public int Sum(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public void Excute(int a, int b)
        {
            Console.WriteLine("Method 1: ");
            TestDelegate test1 = new TestDelegate(Sum);
            Console.WriteLine($"Sum: {test1(a,b)}");
            Console.WriteLine("Method 2: ");
            test1 = Subtract;
            Console.WriteLine($"Substract: {test1.Invoke(a, b)}");
        }
    }
}
