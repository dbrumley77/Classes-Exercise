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
            car1.SeatingCapacity = 4;

            Console.WriteLine($"{car1.Make}, {car1.Model}, {car1.Year}, seating capacity: {car1.SeatingCapacity}");

            var car2 = new Car();
            car2.Make = "Ford";
            car2.Year = 1987;
            car2.Model = "Bronco";
            car2.SeatingCapacity = 4;

            Console.WriteLine($"{car2.Make}, {car2.Model}, {car2.Year}, seating capacity: {car2.SeatingCapacity}");


            var car3 = new Car();
            car3.Make = "Chevy";
            car3.Year = 2004;
            car3.Model = "Suburban";
            car3.SeatingCapacity = 6;

            Console.WriteLine($"{car3.Make}, {car3.Model}, {car3.Year}, seating capacity: {car3.SeatingCapacity}"); 

        }


    }


}


