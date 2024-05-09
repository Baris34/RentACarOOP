using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarOOP.Models;
namespace RentACarOOP.Repository
{
    class CarRepository
    {
        private List<Car> cars;

        public CarRepository()
        {
            cars = new List<Car>();
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }
        public List<Car> GetAllCars()
        {
            return cars;
        }
        public Car GetByID(int ID)
        {
            foreach (Car car in cars)
            {
                if (car.ID==ID)
                {
                    return car;
                }
            }
            return new Car();
        }
        public void Delete(int ID)
        {
            Car deleted = new Car();

            foreach (Car car in cars)
            {
                if (car.ID==ID)
                {
                    deleted = car;
                }
            }
            cars.Remove(deleted);
        }



    }
}
