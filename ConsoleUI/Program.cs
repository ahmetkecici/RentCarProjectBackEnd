using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework.Repositories;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            //ICarService _carservice = new CarManager(new InMemoryCarDal());
            //ListCars(_carservice);
            // GetByIdTest(_carservice);



            ////  AddCarTest(_carservice);
            //UpdateCarTest(_carservice);
            //DeleteCarTest(_carservice);
            //ListCarsTest(_carservice);
            //ICarService carService = new CarManager(new EfCarDal());
            //ListCarsTest(carService)

            //ColorList();

            //ICarService carService = new CarManager(new EfCarDal());
            //foreach (var item in carService.GetCarDetails())
            //{
            //    Console.WriteLine(item.ColorName + " "+item.BrandName +" "+item.CarName+" "+item.DailyPrice);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetAll();
            //Console.WriteLine(result.Message);
            RentalManager rental = new RentalManager(new EfRentalDal());

            rental.Add(new Rental { CarId=2,CustomerId=1});
        }

        //private static void ColorList()
        //{
        //    IColorService colorService = new ColorManager(new EfColorDal());
        //    var colors = colorService.GetAll();
        //    foreach (var item in colors)
        //    {
        //        Console.WriteLine(item.Name);
        //    }
        //}

        //public  static void ListCarsTest(ICarService carService)
        //{
        //    var cars = carService.GetAll();
        //    foreach (var car in cars)
        //    {

        //        Console.WriteLine(car.ModelName);

        //    }
        //}
        //public static void GetByIdTest(ICarService carService)
        //{
        //    var car= carService.GetById(4);
        //    Console.WriteLine(car.Description);
        //}
        //public static void AddCarTest(ICarService carService)
        //{
        //    carService.Add(new Car { Id = 8, BrandId = 5, ColorId = 5, DailyPrice = 50000, Description = "Sonradan Eklenen Araba", ModelYear = 2025 });
        //}
        //public static void UpdateCarTest(ICarService carService)
        //{
        //    carService.Update(new Car { Id = 2, BrandId = 5, ColorId = 5, DailyPrice = 50000, Description = "Sonradan Güncellenen Araba", ModelYear = 2025 });
        //}
        //public static void DeleteCarTest(ICarService carService)
        //{
        //    carService.Delete(5);
        //}
    }
}
