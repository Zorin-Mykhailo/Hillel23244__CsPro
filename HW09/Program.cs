namespace HW09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Minivan sharan = new Minivan("VW Sharan", 2, new(2021, 10, 10), 150);
            Car car = new Minivan("Ford transit Connect", 6, new(2021, 10, 10), 180);

            Console.WriteLine(sharan);
            Console.WriteLine(sharan.GetNumberOfSeats());
            Console.WriteLine(sharan.GetYear());
            Console.WriteLine(sharan.GetCarDescription());

            CarManager<Minivan> minivanManager = new (sharan);
            CarManager<Minivan>.Tune(sharan);
            Console.WriteLine(minivanManager.GetCarFullInfo());

            Console.WriteLine(car);
            Console.WriteLine(car.GetNumberOfSeats());
            Console.WriteLine(car.GetYear());
            Console.WriteLine(car.GetCarDescription());

            CarManager<Car> carManager = new(car);
            Console.WriteLine(carManager.GetCarFullInfo());
        }
    }
}
