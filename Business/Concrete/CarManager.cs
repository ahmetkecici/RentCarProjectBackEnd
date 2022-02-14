using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Arabalar Listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {

            return new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id) , "Arabalar Listelendi");
           
           // return _carDal.GetById(id);
        }

        public IResult Add(Car car)
        {
            if (car.ModelName.Length>2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult("Eklendi");
            }
            else
            {
                return new ErrorResult("Eklenemedi");
            }
        }

        public IResult Delete(int id)
        {
            var car = _carDal.Get(x=>x.Id==id);
            _carDal.Delete(car);
            return new SuccessResult("Silindi");
        }

      
        public IResult Update(Car car)
        {
           _carDal.Update(car);
            return new SuccessResult("Güncellendi");
        }

        public IDataResult< List<Car>> GetCarsByBrandId(int brandId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.BrandId == brandId), "Arabalar Listelendi");
         
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.ColorId == colorId), "Arabalar Listelendi");
        
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), "Arabalar Listelendi");
          
        }
    }
}
