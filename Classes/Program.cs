namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "BMW";
            car1.Model = "X2";
            car1.Year = 2025;

            Console.WriteLine($"{car1.Make}, {car1.Model}, {car1.Year}");

        }


    }


}


