using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantApp.Models;
using PlantApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlantApp.Controllers
{
    public class PlantController : Controller
    {
        private readonly IPlantRepository _plantRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PlantController(IPlantRepository plantRepository, ICategoryRepository categoryRepository)
        {
            _plantRepository = plantRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PlantsListViewModel plantsListViewModel = new PlantsListViewModel();
            plantsListViewModel.Plants = _plantRepository.Plants;
            plantsListViewModel.CurrentCategory = "Easy To Grow";
            return View(plantsListViewModel);
        }
    }
}
