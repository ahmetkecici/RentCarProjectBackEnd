using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public IDataResult<List<Brand>> GetAll()
        {
           return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Markalar Listelendi");   
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id), "Markalar Listelendi");
       
        }


        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(int id)
        {
            var entity = _brandDal.Get(b => b.Id == id);
            _brandDal.Delete(entity);
            return new SuccessResult("Silindi");
        }
        public IResult Update(Brand brand)
        {
         _brandDal.Update(brand);
            return new SuccessResult("Güncellendi");
        }
    }
}
