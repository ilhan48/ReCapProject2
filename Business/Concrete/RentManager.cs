using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentManager : IRentService
    {
        IRentDal _rentDal;

        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rent rent)
        {
            _rentDal.Add(rent);
            return new SuccessResult();
        }

        public IResult Delete(Rent rent)
        {
            _rentDal.Delete(rent);
            return new SuccessResult();
        }

        public IDataResult<List<Rent>> GetAll()
        {
            return new SuccessDataResult<List<Rent>>(_rentDal.GetAll());
        }

        public IDataResult<Rent> GetById(int id)
        {
            return new SuccessDataResult<Rent>(_rentDal.Get(r => r.Id == id));
        }

        public IResult Update(Rent rent)
        {
            _rentDal.Update(rent);
            return new SuccessResult();
        }
    }
}