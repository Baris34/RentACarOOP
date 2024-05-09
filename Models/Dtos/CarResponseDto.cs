using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOOP.Models.Dtos
{
    class CarResponseDto
    {
        public string Modelname { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public string ColorName { get; set; }
        public double DailyPrice { get; set; }

        public override string ToString()
        {
            return $"Aracın Modeli:{Modelname} Markası:{BrandName} Yılı:{ModelYear} Rengi:{ColorName} Günlük Ücreti:{DailyPrice}";
        }
    }
}
