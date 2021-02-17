using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName + "/" + car.ColorName); ;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //foreach (var car in carManager.GetCarDetails())
            //{
            //   Console.WriteLine(car.CarId + " " + car.DailyPrice);
            //}

            //carManager.Add(new Car { BrandId = 12, ColorId = 4, ModelYear = 2016, DailyPrice = 165, Description = "R" });
            //carManager.Delete(new Car { CarId = 2002 });


            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Update(new Brand { BrandId = 12,BrandName="Audi" });

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Altın Sarsı" });


        }


    }
}