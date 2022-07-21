using Business.Concrate;
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

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Cars_Name);
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