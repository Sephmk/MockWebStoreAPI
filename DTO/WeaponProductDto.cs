using static MockWebStoreAPI.DataModels.WeaponProduct;

namespace MockWebStoreAPI.DTO
{
    public class WeaponProductDto : ProductDto
    {
        public int        Range             { get; set; }
        public int        MinDamage         { get; set; }
        public int        MaxDamage         { get; set; }
        public double     CriticalHitChance { get; set; }
        public WeaponType WeaponType        { get; set; }
    }
}