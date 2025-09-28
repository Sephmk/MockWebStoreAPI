namespace MockWebStoreAPI.DataModels
{
    public class ArmourProduct : Product
    {
        public enum ArmourSlot
        {
            Head,
            Chest,
            Legs
        }

        public enum ArmourMaterial
        {
            Leather,
            Iron,
            Cloth
        }

        public int            ArmourRating      { get; private set; }
        public int            ArmourWeight      { get; private set; }
        public ArmourMaterial Material          { get; private set; }
        public ArmourSlot     Slot              { get; private set; }

        protected ArmourProduct()
        {
        }

        public ArmourProduct(string name, int armourRating, int armourWeight, ArmourMaterial material, ArmourSlot slot) : base(name)
        {
            ArmourRating = armourRating;
            ArmourWeight = armourWeight;
            Material = material;
            Slot = slot;
        }
    }
}
