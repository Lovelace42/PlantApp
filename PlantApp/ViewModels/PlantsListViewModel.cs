using PlantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantApp.ViewModels
{
    public class PlantsListViewModel
    {
        public IEnumerable<Plant> Plants { get; set; }
        public string CurrentCategory { get; set; }
    }
}
