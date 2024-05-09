using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarOOP.Models;
namespace RentACarOOP.Repository
{
    public class BrandRepository
    {
        private List<Brand> _BrandRepository;

        public BrandRepository()
        {
            _BrandRepository = new List<Brand>();
        }

        public List<Brand> GetAllBrands()
        {
            return _BrandRepository;
        }

        public void AddBrand(Brand brand)
        {
            _BrandRepository.Add(brand);
        }
        public Brand GetByID(int id)
        {
            foreach (Brand brand in _BrandRepository)
            {
                if (brand.ID==id)
                {
                    return brand;
                }
            }
            return new Brand();
        }
        public void Delete(int id)
        {
            Brand delete = new Brand();
            foreach (Brand brand in _BrandRepository)
            {
                if (brand.ID==id)
                {
                    delete = brand;
                }
            }
            _BrandRepository.Remove(delete);
        }

    }
}
