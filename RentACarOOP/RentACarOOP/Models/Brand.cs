using System;
namespace RentACarOOP.Models
{
    
    public class Brand:BaseModel
    {

        public string Name{ get; set; }

        public override string ToString()
        {
            return $"Brand[ID:{ID} Oluşturulma Zamanı:{CreatedTime} Marka Adı:{Name}]";
        }
    }
}
