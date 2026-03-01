using MockWebStoreAPI.DataModels;
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

        internal static WeaponProductDto FromEntity(WeaponProduct w)
        {
            WeaponProductDto result = new()
            {
                Range = w.Range,
                MinDamage = w.MinDamage,
                MaxDamage = w.MaxDamage,
                CriticalHitChance = w.CriticalHitChance,
                WeaponType = w.Type,

                Category = ProductDtoCategory.Weapon
            };

            MapBaseProperties(result, w);

            return result;
        }
    }
}