namespace _6dars
{
    internal class Program
    {
        static float Add(float a, float b)
        {
            return a + b;

        }
        static float Add(float a, float b, float c)
        {
            return a + b + c;
        }
        static string Add(string a, string b)
        {
            return a + b;
        }

        // task 2
        static int calculate(int a, int b)
        {
            return a + b;
        }

        static int calculate(int a, int b, int c)
        {
            return a * b * c;
        }

        // task 3

        static int multiplication(int a)
        {
            int res = 1;
            for (int i = 1; i <= a; i++)
            {
                res *= i;
            }
            return a;
        }
        static int multiplication(int a, int b)
        {
            int res = 1;
            for (int i = a; i <= b; i++)
            {
                res *= i;
            }
            return res;
        }
        static int multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] ags)
        {

            Console.WriteLine(Add(5.5f, 4.5f));
            Console.WriteLine(Add(5.5f, 4.5f, 2.0f));
            Console.WriteLine(Add("Hello, ", "World!"));


            // task 2

            Console.WriteLine(calculate(2, 3));
            Console.WriteLine(calculate(2, 3, 4));

            //task 3
            Console.WriteLine(multiplication(5));
            Console.WriteLine(multiplication(2, 4));
            Console.WriteLine(multiplication(2, 3, 4));

        }
    }
}
