namespace MockWebStoreAPI.DataModels
{
    public class WeaponProduct : Product
    {
        public const int MELEE_RANGE = 1;

        public enum WeaponType
        {
            Sword,
            Shield,
            Dagger,
            Bow,
        }

        public int        Range             { get; private set; } = MELEE_RANGE;
        public int        MinDamage         { get; private set; }
        public int        MaxDamage         { get; private set; }
        public double     CriticalHitChance { get; private set; }
        public WeaponType Type              { get; private set; }

        protected WeaponProduct()
        {
        }

        public WeaponProduct(string name, int range, int minDamage, int maxDamage, double critChance, WeaponType type) : base(name)
        {
            Range = range;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CriticalHitChance = critChance;
            Type = type;
        }
    }
}
