using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarOOP.Models;
namespace RentACarOOP.Repository
{
    public class ModelRepository
    {
        private List<Model> _modelRepository;

        public ModelRepository()
        {
            _modelRepository = new List<Model>();
        }

        public void AddModel(Model model)
        {
            _modelRepository.Add(model);
        }
        public List<Model> GetAllModels()
        {
            return _modelRepository;
        }

        public Model GetById(int id)
        {
            bool isFound = false;
            Model found = new Model();
            foreach (Model model in _modelRepository)
            {
                if (model.ID==id)
                {
                    isFound = true;
                    found = model;
                }
            }
            if (!isFound)
            {
                throw new KeyNotFoundException($"{id} geçerli bir ID değil. ");
            }
            else
            {
                return found;
            }

        }
        public void Delete(int id)
        {
            Model deleted = new Model();
            bool isDeleted = false;
            foreach (Model model in _modelRepository)
            {
                if (model.ID==id)
                {
                    isDeleted = true;
                    deleted = model;
                }
            }
            if (!isDeleted)
            {
                throw new KeyNotFoundException($"{id} böyle bir ID'e sahip veri yok.");
            }
            else
            {
            _modelRepository.Remove(deleted);
            }

        }

    }
}
