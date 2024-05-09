using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarOOP.Repository;
using RentACarOOP.Models;
namespace RentACarOOP.Services
{
    public class BrandService
    {
        private BrandRepository _brandRepository;
        public BrandService()
        {
            _brandRepository = new BrandRepository();
        }
        public void Add(Brand brand)
        {
            if (brand.Name.Length<=0)
            {
                Console.WriteLine("Lütfen bir geçerli bir isim giriniz!!");
            }
            _brandRepository.AddBrand(brand);
        }
        public void GetAllBrands()
        {
            List<Brand> brands = _brandRepository.GetAllBrands();

            foreach (Brand brand in brands)
            {
                Console.WriteLine(brand);
            }

        }
    }
}
