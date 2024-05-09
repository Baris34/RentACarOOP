using System;
namespace RentACarOOP.Models
{
    public class Model:BaseModel
    {
        
        public string Name{ get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Model[ID:{ID} Oluşturulma Zamanı:{CreatedTime} Model Adı:{Name} Model Yılı:{Year}]";
        }

    }

}
