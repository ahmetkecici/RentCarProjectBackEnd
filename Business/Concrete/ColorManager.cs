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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public    IDataResult<List<Color>> GetAll()
        {
           
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Renkler");
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id));
        }

        public IResult Add(Color color)
        {
          _colorDal.Add(color);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(int id)
        {
            var entity=_colorDal.Get(c=>c.Id == id);    
           _colorDal.Delete(entity);
            return new SuccessResult("Silindi");
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult("Güncellendi");
        }
    }
}
