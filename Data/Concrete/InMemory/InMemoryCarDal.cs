using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal //:ICarDal
    {
        private readonly List<Car> _cars;

        public InMemoryCarDal ()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=45000,Description="Jaguar model efsane seveceksiniz kesinlikle",ModelYear=2020},
                new Car{Id=2,BrandId=2,ColorId=5,DailyPrice=55000,Description="Fiorino",ModelYear=2020},
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=75000,Description="Fiat doblo",ModelYear=2005},
                new Car{Id=4,BrandId=4,ColorId=3,DailyPrice=80000,Description="Renault Symbol Efsane",ModelYear=2012},
                new Car{Id=5,BrandId=5,ColorId=5,DailyPrice=50000,Description="Volvo en dayanıklı model",ModelYear=2021},
                new Car{Id=6,BrandId=6,ColorId=1,DailyPrice=15000,Description="Tofaşk aşkın kendisi" ,ModelYear=2000},
            };
        }

     
        public List<Car> GetAll()
        {
            return _cars;
        }
        public Car GetById(int id)
        {
            return _cars.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Update(Car car)
        {
            var carToUpdate=_cars.Where(c=>c.Id == car.Id).FirstOrDefault();
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;  
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            
        }
        public void Add(Car car)
        {
          _cars.Add(car);
        }

        public void Delete(int id)
        {
            var carToDelete = _cars.Where(c => c.Id == id).FirstOrDefault();
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
