using static MockWebStoreAPI.DataModels.ArmourProduct;

namespace MockWebStoreAPI.DTO
{
    public class ArmourProductDto : ProductDto
    {
        public int            ArmourRating      { get; set; }
        public int            ArmourWeight      { get; set; }
        public ArmourMaterial Material          { get; set; }
        public ArmourSlot     Slot              { get; set; }
    }
}