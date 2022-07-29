using Business.Concrate;
using Core.Utilities.Results;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Cars_Name);
                }
                Console.WriteLine(result.Message);
            }
            //addCar(carManager);

        }



        private static void addCar(CarManager carManager)
        {
            Car newCar = new Car
            {
                Id = 1,
                BrandsId = 1,
                ColorsId = 1,
                Cars_Name = "Model X",
                Daily_Price = 150,
                Description = "0 arac",
                Model_Year = 2022
            };
            carManager.Add(newCar);
        }
    }
}