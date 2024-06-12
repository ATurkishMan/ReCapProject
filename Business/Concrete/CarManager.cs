using Business.Abstarct;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;//construction injection 

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("CarManager da void in içine ne yazılacak bilmiyorum");
        }

        public void Delete(Car car)
        {
            Console.WriteLine("CarManager da void in içine ne yazılacak bilmiyorum");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public void Update(Car car)
        {
            Console.WriteLine("CarManager da void in içine ne yazılacak bilmiyorum");
        }
    }
}
