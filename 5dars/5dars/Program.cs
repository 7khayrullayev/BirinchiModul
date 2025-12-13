namespace _5dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List length ni kiriting: ");
            var n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("list elementini kiriting: ");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }
        }
    }
}