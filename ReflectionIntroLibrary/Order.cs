namespace ReflectionIntroLibrary
{
    /// <summary>
    /// Represents an order containing an order ID and an ordered product.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the ID of the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the ordered product associated with the order.
        /// </summary>
        public Product OrderedProduct { get; set; }
    }
}