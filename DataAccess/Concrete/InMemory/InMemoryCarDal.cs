using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal


    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, CarName="Toyota",  BrandId= 1, ColorId=1, ModelYear= 2020, DailyPrice= 350, Description= "Hybrid"   },
                new Car{CarId=2, CarName="Honda",  BrandId= 2, ColorId=1, ModelYear= 2021, DailyPrice= 400, Description= "Sedan"   },
                new Car{CarId=3, CarName="Renault",  BrandId= 3, ColorId=3, ModelYear= 2018, DailyPrice= 250, Description= "Sedan"   },
                new Car{CarId=4, CarName="Kia",  BrandId= 4, ColorId=3, ModelYear= 2022, DailyPrice= 350, Description= "Hatchback"   },
                new Car{CarId=5, CarName="Mercedes",  BrandId= 5, ColorId=1, ModelYear= 2019, DailyPrice= 550, Description= "SUV"   },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carID)
        {
            return _cars.Where(c => c.CarId == carID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }

}
