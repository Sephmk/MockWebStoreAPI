using MockWebStoreAPI.DataModels;
using static MockWebStoreAPI.DataModels.ArmourProduct;

namespace MockWebStoreAPI.DTO
{
    public class ArmourProductDto : ProductDto
    {
        public int            ArmourRating      { get; set; }
        public int            ArmourWeight      { get; set; }
        public ArmourMaterial Material          { get; set; }
        public ArmourSlot     Slot              { get; set; }

        internal static ArmourProductDto FromEntity(ArmourProduct a)
        {
            ArmourProductDto result = new()
            {
                ArmourRating = a.ArmourRating,
                ArmourWeight = a.ArmourWeight,
                Material = a.Material,
                Slot = a.Slot,

                Category = ProductDtoCategory.Armour
            };
            
            MapBaseProperties(result, a);

            return result;
        }
    }
}