using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            ColorManager colorManager = new ColorManager(new EfColorDal());

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            
            foreach (var c in carManager.GetAll())
            {
               Console.WriteLine($"{c.CarName} markalı arabanın günlük fiyatı {c.DailyPrice}tl'dir.");
            }
            Console.WriteLine("-----------------------");

            
            foreach (var s in colorManager.GetAll())
            {
                Console.WriteLine($"{s.ColorName}");
            }

            Console.WriteLine("-----------------------");

            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine($"Kiralanabilir arabalar ;" +
                    $" {b.BrandName}.");
            }


        }
    }
}