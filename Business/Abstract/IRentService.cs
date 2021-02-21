using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentService
    {
        IDataResult<List<Rent>> GetAll();
        IDataResult<Rent> GetById(int id);
        IResult Add(Rent rent);
        IResult Update(Rent rent);
        IResult Delete(Rent rent);
    }
}