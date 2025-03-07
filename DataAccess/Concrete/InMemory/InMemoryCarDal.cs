﻿using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;//global _değişken
        public InMemoryCarDal()//construtor : Class ın ismiyle yapılan.
                                                 //proje başladığında bellekte oluştur
        {
            _cars = new List<Car>()
            {
                new Car() {Id=1,BrandId=1,ColorId=1,DailyPrice=10000,ModelYear=2020,Description="Kelepir"},
                new Car() {Id=2,BrandId=1,ColorId=2,DailyPrice=15000,ModelYear=2019,Description="Yeni Gibi"},
                new Car() {Id=3,BrandId=2,ColorId=1,DailyPrice=30000,ModelYear=2024,Description="Sıfır"},
                new Car() {Id=4,BrandId=3,ColorId=2,DailyPrice=25000,ModelYear=2023,Description="Memur Arabası"},
                new Car() {Id=5,BrandId=3,ColorId=3,DailyPrice=5000,ModelYear=2016,Description="İyi Durumda"}
            }; 
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public Car GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
