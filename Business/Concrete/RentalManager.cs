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
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var isReturn = _rentalDal.GetAll(r=>r.CarId==rental.CarId&&r.ReturnDate==null).SingleOrDefault();
           //  var isReturn=carRents.SingleOrDefault(r=>r.ReturnDate==null);
            if (isReturn is not null)
            {
                throw new Exception("Araba kiralık");
            }
            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {


            var user = _rentalDal.Get(x => x.Id == id);
            _rentalDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.Id == id));
        }

        public IResult Update(Rental rental)
        {

            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
