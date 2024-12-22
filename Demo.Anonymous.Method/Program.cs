namespace Demo.Anonymous.Method
{
    public delegate void Print(int value);

    //public delegate double Square(double value);


    internal class Program
    {
        static void Main(string[] args)
        {

            var name = "C# Corner";
            Print print = delegate (int val)
            {
                Printer.Test();
                Console.WriteLine($"Inside Anonymous method. Value: {val} - {name}");
            };

            print(100);

            //Square square = delegate (double val)
            //{
            //    return val * val;
            //};
            //Console.WriteLine(square(4.5));


            Printer.Print(delegate (int val) { Console.WriteLine("Inside Anonymous method. Value: {0}", val); }, 100);


        }
    }

    public class Printer
    {
        public static void Print(Print print, int value)
        {
            print(value);
        }

        public static void Test()
        {
            Console.WriteLine("Test method body");
        }
    }
}
