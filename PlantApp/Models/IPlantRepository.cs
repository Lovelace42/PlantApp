using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantApp.Models
{
    public interface IPlantRepository
    {
        IEnumerable<Plant> Plants { get; }

        Plant GetPlantById(int plantId);
    }
}
