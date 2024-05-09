
/*Rent A Car Projesi 
       3 tablomuz olacak Car,Brand,Model
       Bu tabloların bir veri tabanı olduğunu varsayalım ama şuanda liste ile işlemler yönetilecek
       listeleme, ekleme, silme , ID'ye göre getirme işlemleri yapılacaktır.

       Car --> ID, CreatedTime,Model,Brand,ColorName,DailyPrice
       Model --> ID,CreatedTime,Name,Year
       Brand --> ID,CreatedTime,Name

  */
using System;
using RentACarOOP.Models;
using RentACarOOP.Services;
namespace RentACarOOP
 
{
    public class Program
    {
        static void Main(string[] args)
        {

            Model model = new Model()
            {
                ID = 1,
                CreatedTime=DateTime.Now,
                Name ="kartal",
                Year=2022
            };
            Brand brand = new Brand()
            {
                ID = 1,
                CreatedTime=DateTime.Now,
                Name="Tofaş"
            };
            Car car = new Car()
            {
               ID=1,
               CreatedTime=DateTime.Now,
               Model=model,
               Brand=brand,
               ColorName="Mavi",
               DailyPrice=1235
            }; Model model2 = new Model()
            {
                ID = 3,
                CreatedTime = DateTime.Now,
                Name = "A5",
                Year = 2022
            };
            Brand brand2 = new Brand()
            {
                ID = 3,
                CreatedTime = DateTime.Now,
                Name = "Audi"
            };
            Car car2 = new Car()
            {
                ID = 3,
                CreatedTime = DateTime.Now,
                Model = model2,
                Brand = brand2,
                ColorName = "Siyah",
                DailyPrice = 1100
            };
            CarService carService = new CarService();
            //carService.Add(car);
            //carService.Add(car2);
            //carService.GetAllCars();
            ModelService modelService = new ModelService();
            modelService.Add(model2);
            
            modelService.Add(model);
            modelService.Delete(3);
            modelService.GetAllModels();

            carService.Add(car);
            carService.Add(car2);
            carService.GetAllCars();
            Console.Read();
        }
    }
}
