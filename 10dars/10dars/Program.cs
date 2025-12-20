namespace _10dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop laptop1 = new laptop()
            {
                Brand = "HP",
                ScreenSize = 15.6,
                Storage = 512,
                Processor = "Intel Core i5",
                DateManufactured = 2022


            };
            Console.WriteLine(laptop1.Brand);



            uzbekistan uzbekistan1 = new uzbekistan()
            {
                Population = 37500000,
                Area = 448978,
                Capital = "Tashkent",
                Language = "Uzbek",
                Currency = "Som"
            };
            Console.WriteLine(uzbekistan1.Population);



            PresidentOfUzb president = new PresidentOfUzb()
            {
                FullName = "Shavkat Mirziyoyev",
                YearBorn = 1957,
                YearElected = 2016,
                PoliticalParty = "UzLiDeP",
                Height = 168
            };
            Console.WriteLine(president.FullName);



            Phone phone1 = new Phone();
            phone1.Model = "17 pro";
            phone1.Brand = "Samsung";
            phone1.Color = "Black";
            phone1.Storage = 512;
            phone1.DateManufactured = 2025;

            Console.WriteLine(phone1.Brand);

            IUT inha = new IUT();

            inha.FullName = "Inha University in Tashkent";
            inha.NumberOfStudents = 2000;
            inha.EstablishedDate = 2014;
            inha.WorldRanking = 631;
            inha.Location = "Mirzo Ulug'bek";

            Console.WriteLine(inha.FullName);


        }
    }
}