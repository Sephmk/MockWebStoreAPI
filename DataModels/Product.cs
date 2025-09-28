using System.ComponentModel.DataAnnotations;

namespace MockWebStoreAPI.DataModels
{
    public abstract class Product
    {
        public const int MAX_NAME_LENGTH = 255;

        public int     Id          { get; private set; }
        [Required]
        public string  Name        { get;         set; } = "";
        public string? Description { get;         set; }
        public bool    IsActive    { get;         set; }

        private Product()
        {
        }

        /// <summary>
        /// Constructs a product object and validates the required name
        /// </summary>
        /// <param name="name">Cannot be null and must be a valid length</param>
        /// <exception cref="ArgumentNullException">Throws if name is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws if name is 0 or greater than <see cref="MAX_NAME_LENGTH"/></exception>
        public Product (string name)
        {
            if (ValidateName(name))
            {
                Name = name;
            }
        }

        /// <summary>
        /// Validates and renames a product
        /// </summary>
        /// <param name="name">Cannot be null and must be a valid length</param>
        /// <exception cref="ArgumentNullException">Throws if name is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws if name is 0 or greater than <see cref="MAX_NAME_LENGTH"/></exception>
        public void Rename (string name)
        {
            if (ValidateName(name))
            {
                Name = name;
            }
        }

        private bool ValidateName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null");
            }
            else if (name.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(name), "Name (" + name + ") is too short");
            }
            else if (name.Length > MAX_NAME_LENGTH)
            {
                throw new ArgumentOutOfRangeException(nameof(name), "Name (" + name + ") is too long");
            }

            return true;
        }
    }
}
