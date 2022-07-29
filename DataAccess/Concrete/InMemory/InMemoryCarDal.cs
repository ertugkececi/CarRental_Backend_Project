using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId =1, BrandId =1, ColorId = 1, DailyPrice =250, ModelName = "Renault Clio HB", ModelYear = 2017},
                new Car{ CarId =2, BrandId =2, ColorId = 2, DailyPrice =350, ModelName = "Renault Megane", ModelYear = 2015},
                new Car{ CarId =3, BrandId =3, ColorId = 4, DailyPrice =275, ModelName = "Wolkwagen Polo", ModelYear = 2018},
                new Car{ CarId =4, BrandId =4, ColorId = 3, DailyPrice =490, ModelName = "Dacia Duster", ModelYear = 2021},
                new Car{ CarId =5, BrandId =5, ColorId = 2, DailyPrice =325, ModelName = "Seat Ibiza", ModelYear = 2014},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.SingleOrDefault(filter.Compile());
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return filter == null ? _cars : _cars.Where(filter.Compile()).ToList();
        }

        public Car GetById(int CarId)
        {
            return _cars.SingleOrDefault(c => c.CarId == CarId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelName = car.ModelName;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}

