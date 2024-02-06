using ACT2;
using System;

namespace ACT2
{
    public class Car
    {
        public string carBrand { get; set; }
        public string carColor { get; set; }
        public int carPrice { get; set; }
        public void Honk(string stringVariable)
        {
            Console.WriteLine($"{stringVariable}: Honk!!!");
        }
    }
}

class Progress
{
    static void Main(string[] args)
    {
        List<Car> list = new List<Car>();

        while (true)
        {
            Console.WriteLine(" Enter new data? [Yes/No] ");

            if (Console.ReadLine() == "No")
            {
                break;
            }

            Car car1 = new Car();

            Console.WriteLine(" Enter Car Brand = ");
            car1.carBrand = Console.ReadLine();

            Console.WriteLine(" Enter Car Color = ");
            car1.carColor = Console.ReadLine();

            Console.WriteLine(" Enter Car Price = ");
            car1.carPrice = int.Parse(Console.ReadLine());

            list.Add(car1);
        }//

        list.ForEach(x =>
        {
            Console.WriteLine(x.carBrand);
            Console.WriteLine(x.carColor);
            Console.WriteLine(x.carPrice);
            Console.WriteLine(" ===================== ");
        });

    }
}