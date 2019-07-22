using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantApp.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string LatinName { get; set; }
        public string CommonName { get; set; }
        public string Description { get; set; }
        public string WaterNeeds { get; set; }
        public string SoilNeeds { get; set; }
        public string LightNeeds { get; set; }
        public string OtherNeeds { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
