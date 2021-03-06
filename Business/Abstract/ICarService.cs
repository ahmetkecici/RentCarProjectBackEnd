using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);  
        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
