using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantApp.Models
{
    public class MockPlantRepository: IPlantRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Plant> Plants
        {
            get
            {
                return new List<Plant>
                {
                    new Plant{
                        Id = 1,
                        LatinName = "Aeschynanthus Radicans",
                        CommonName = "Red-leafed Lipstick Plant",
                        Description = "Aeschynanthus radicans, commonly called lipstick plant or lipstick vine, is an ephiphytic evergreen vine from Malaysia with slender trailing and arching stems originating in tree branches. It has long, red, tubular flowers in dense terminal clusters. Its leaves are dark green, elliptical, fleshy and smooth-edged. Fruit grows to 1 ½ in long. It is an attractive flowering vine for use in hanging pots. Genus name comes from the Greek words aischune meaning shame and anthos meaning flower referring to the red flowers. Specific epithet means having rooting stems. The common name refers to the appearance of the flower buds that have bright red flowers emerging from a dark tube-like structure.",
                        WaterNeeds = "Keep evenly moist. Can be hard to re-wet because of potting medium. Do not allow to stand in water.",
                        SoilNeeds = "Peaty mix.",
                        LightNeeds = "Grow in east or west facing window or under grow light for the most blooms. Turn plant often to ensure equal growth and blooms.",
                        OtherNeeds = "Cousin of the african violet.",
                        ImageUrl = "~/Images/RedLeafedLipstickPlant.jpg",
                        CategoryId = 1,
                        Category = _categoryRepository.Categories.ToList()[0]},
                    new Plant{
                        Id = 2,
                        LatinName = "Begonia Rex",
                        CommonName = "Painted Leaf Begonia, Firework",
                        Description = "Sometimes called painted-leaf begonias or fancy-leaf begonias, these plants are known for their showy, sometimes jaw-dropping leaf coloration.",
                        WaterNeeds = "Use filtered water ONLY (very sensitive). Provide lots of humidity (do not mist as wet leaves will rot). Never allow the plant to sit in water and allow to drain thoroughly after watering. Water only when soil almost completely dry (past surface level), but avoid letting the leaves wilt.",
                        SoilNeeds = "Organic, sharp-draining soil",
                        LightNeeds = "Bright but indirect sunlight",
                        OtherNeeds = "Keep plant away from drafts. Repot only when plant becomes rootbound.",
                        ImageUrl = "~/Images/PaintedLeafBegonia.jpg",
                        CategoryId = 3,
                        Category = _categoryRepository.Categories.ToList()[2]},
                    new Plant{
                        Id = 3,
                        LatinName = "Bromeliaceae",
                        CommonName = "Guzmania Bromeliad",
                        Description = "They feature long, narrow, shiny green leaves that rise from a deep central cup. The plants are somewhat taller than many bromeliads. Their large and showy flower bracts arise in the summer in an amazing array of colors.",
                        WaterNeeds = "Can withstand drought, and are prone to root rot if over watered. Loves humidity, pebble tray and misting are good.",
                        SoilNeeds = "Allow for fast drainage.",
                        LightNeeds = "Bright, indirect light",
                        OtherNeeds = "",
                        ImageUrl = "~/Images/GuzmaniaBromeliad.jpg",
                        CategoryId = 1,
                        Category = _categoryRepository.Categories.ToList()[0]},
                    new Plant{
                        Id = 4,
                        LatinName = "Chlorophytum Comosum",
                        CommonName = "Spider Plant",
                        Description = "Chlorophytum comosum is native to South Africa. It has linear leaves that are green or striped white. Flowering stems bear loose panicles of small, white, starry flowers. Plantlets are formed at the flowering nodes. When plants are full, they have an interesting, graceful, cascading habit.",
                        WaterNeeds = "Keep plant evenly moist ",
                        SoilNeeds = "",
                        LightNeeds = "Medium to bright light to maintain variegation.",
                        OtherNeeds = "Brown tips appear from over fertilizing. Repot when tubers fill or break the pot.",
                        ImageUrl = "~/Images/SpiderPlant.jpg",
                        CategoryId = 1,
                        Category = _categoryRepository.Categories.ToList()[0]}
                };
            }
        }

        public Plant GetPlantById(int plantId)
        {
            throw new System.NotImplementedException();
        }
    }
}
