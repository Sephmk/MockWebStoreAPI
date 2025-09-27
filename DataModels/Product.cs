namespace MockWebStoreAPI.DataModels
{
    public abstract class Product
    {
        public int     Id { get; private set; }
        public string  Name { get; set; } = "";
        public string? Description { get; set; }
        public bool    IsActive { get; set; }
    }
}
