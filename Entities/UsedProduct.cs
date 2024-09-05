using System.Globalization;

namespace Course.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateOnly manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Manufacture date: {ManufactureDate})";
        }
    }
}
