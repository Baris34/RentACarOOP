using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarOOP.Repository;
using RentACarOOP.Models;
using RentACarOOP.Models.Dtos;
namespace RentACarOOP.Services
{//----> ColorName alanı mininmum 2 karakterli olmalı ve dailyPrice kolonuna kdv tutarı eklenerek yazılmalı 
    public class CarService
    {
        CarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }
        public void Add(Car car)
        {

            if (car.ColorName.Length<2)
            {
                Console.WriteLine("ColorName alanı minimum 2 karakterli olmalıdır!!!");
            }
            car.DailyPrice = car.DailyPrice * 1.2;
            _carRepository.Add(car);
        }
        public void GetAllCars()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tüm araçlar çekiliyor");
            Console.WriteLine("---------------------------");
            foreach (Car car in _carRepository.GetAllCars())
            {
                CarResponseDto carResponseDto = new CarResponseDto()
                {
                    BrandName = car.Brand.Name,
                    ColorName = car.ColorName,
                    DailyPrice = car.DailyPrice,
                    Modelname = car.Model.Name,
                    ModelYear = car.Model.Year
                };
                Console.WriteLine(carResponseDto);
            }
        }


    }
}
