namespace _4dars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task 1
            string text = "Foundation";
            var res1 = text.Substring(7, 3);
            Console.WriteLine(res1);

            string text4 = "davay";

            string text2 = "davay";
            var res2 = text2.Substring(2, 3);
            Console.WriteLine(res2);

            // task 2

            string text3 = "Foundation";
            var res3 = text3.Substring(2, text3.Length - 4);
            Console.WriteLine(res3);

            var res4 = text4.Substring(text4.Length - 2);
            Console.WriteLine(res4);
        }
    }
}
