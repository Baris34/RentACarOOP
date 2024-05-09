using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarOOP.Repository;
using RentACarOOP.Models;
namespace RentACarOOP.Services
{
    public class ModelService
    {
        private ModelRepository _modelRepository;

        public ModelService()
        {
            _modelRepository = new ModelRepository();
        }
        public void Add(Model model)
        {
            _modelRepository.AddModel(model);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Model eklendi! \n {model}");
        }
        public void GetAllModels()
        {
            List<Model> _models = _modelRepository.GetAllModels();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tüm modeller oluşturuluyor!!!");
            Console.WriteLine("---------------------------");
            foreach (var model in _models)
            {
                Console.WriteLine(model);
            }
        }
        public void GetByID(int ID)
        {
            try
            {

            Model model = _modelRepository.GetById(ID);
            Console.WriteLine(model);
            }
            catch(KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                Console.WriteLine("---------------------------");
                _modelRepository.Delete(id);
                Console.WriteLine($"{id} numaralı veri silindi!!");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
