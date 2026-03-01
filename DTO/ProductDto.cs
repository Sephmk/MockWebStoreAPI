using MockWebStoreAPI.DataModels;

namespace MockWebStoreAPI.DTO
{
    public class ProductDto
    {
        public int                Id          { get; set; }
        public string             Name        { get; set; } = "";
        public string?            Description { get; set; }
        public ProductDtoCategory Category    { get; set; }

        /// <summary>
        /// Creates the appropriate DTO from a Product entity.
        /// </summary>
        /// <param name="p">The product entity to map</param>
        /// <returns>A ProductDto (WeaponProductDto or ArmourProductDto)</returns>
        /// <exception cref="NotSupportedException">Thrown when product type is not recognized</exception>
        public static ProductDto FromEntity(Product p)
        {
            ProductDto result = p switch
            {
                WeaponProduct w => WeaponProductDto.FromEntity(w),
                ArmourProduct a => ArmourProductDto.FromEntity(a),
                _ => throw new NotSupportedException()
            };
            
            return result;
        }

        protected static void MapBaseProperties(ProductDto dto, Product entity)
        {
            dto.Id          = entity.Id;
            dto.Name        = entity.Name;
            dto.Description = entity.Description;            
            //Category set in child dto's
        }
    }
}