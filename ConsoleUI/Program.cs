using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Console.WriteLine("-----------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine( $"Avaliable brands for rent : {car.CarName} {car.Description}" );
            //}
            //Console.WriteLine("-----------------------");

            //foreach (var c in carManager.GetAll())
            //{
            //   Console.WriteLine($" The daily price for {c.CarName} {c.Description}{c.DailyPrice}");
            //}
            //Console.WriteLine("-----------------------");

            //foreach (var s in colorManager.GetAll())
            //{
            //    Console.WriteLine($"The avaliable colors are: {s.ColorName}");
            //}

            //Console.WriteLine("-----------------------");

            //foreach (var b in brandManager.GetAll())
            //{
            //    Console.WriteLine($"Currently available cars for rent :" +
            //        $" {b.BrandName}.");
            //}


            CarDetailsTest();
        }
        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"Currenlty avaliable car is {car.CarName} {car.BrandName} and the car is {car.ColorName} color. The dailyprice is {car.DailyPrice} Turkish Lira");
            }
        }
    }
}