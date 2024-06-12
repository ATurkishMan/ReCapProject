using Business.Concrete;
using DataAccess.Abstarct;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "-" + car.ModelYear + "-" + car.Description);
            }
            carManager.GetById(2);
        }
    }
}