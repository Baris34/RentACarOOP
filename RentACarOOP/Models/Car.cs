using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Car --> ID, CreatedTime,Model,Brand,ColorName,DailyPrice
namespace RentACarOOP.Models
{
    public class Car:BaseModel
    {
        
        public Model Model { get; set; }
        public Brand Brand { get; set; }
        public string ColorName { get; set; }
        public double DailyPrice { get; set; }

        public override string ToString()
        {
            return $"Car[ID:{ID} Oluşturulma Zamanı:{CreatedTime} \n" +
                $"{Model} \n" +
                $"{Brand} \n" +
                $"Araç Rengi:{ColorName} Günlük Fiyat:{DailyPrice} ]\n";
        }
    }
}
