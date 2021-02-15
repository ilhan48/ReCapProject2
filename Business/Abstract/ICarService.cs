﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllById(int id);
        List<Car> GetByDailytPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}