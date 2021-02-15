using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 4, DailyPrice = 200, ModelYear = 2003, Description = "sedan" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 500, ModelYear = 2013, Description = "crashed" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 700, ModelYear = 2016, Description = "off road" },
                new Car { Id = 4, BrandId = 4, ColorId = 1, DailyPrice = 2000, ModelYear = 2020, Description = "luxury" },
                new Car { Id = 5, BrandId = 7, ColorId = 5, DailyPrice = 90, ModelYear = 1999, Description = "it's okay it is go" },
                new Car { Id = 6, BrandId = 8, ColorId = 7, DailyPrice = 550, ModelYear = 2009, Description = "air conditioner does not work" },
                new Car { Id = 7, BrandId = 5, ColorId = 6, DailyPrice = 2000, ModelYear = 2021, Description = "luxury" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
        public List<Car> GetAllById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
