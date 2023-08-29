using System.Reflection;

namespace ReflectionArticle02TypeInformation
{
    internal class Program
    {
        /// <summary>
        /// Entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            // Accessing type information
            Type orderType = typeof(ReflectionIntroLibrary.Order);
            Console.WriteLine($"Type Name: {orderType.FullName}");
            Console.WriteLine($"Namespace: {orderType.Namespace}");
            Console.WriteLine($"Assembly: {orderType.Assembly.FullName}");

            // Creating an instance of Order using reflection
            object orderInstance = Activator.CreateInstance(orderType);

            // Getting PropertyInfo instances for the properties of Order
            PropertyInfo orderIdProperty = orderType.GetProperty("OrderId");
            PropertyInfo orderedProductProperty = orderType.GetProperty("OrderedProduct");

            // Setting the value of OrderId property using reflection
            orderIdProperty.SetValue(orderInstance, 101);

            // Creating an instance of Product using reflection
            object productInstance = Activator.CreateInstance(typeof(ReflectionIntroLibrary.Product));

            // Getting PropertyInfo instance for the Name property of Product
            PropertyInfo productNameProperty = productInstance.GetType().GetProperty("Name");

            // Setting the value of Name property of the Product instance
            productNameProperty.SetValue(productInstance, "Example Product");

            // Setting the OrderedProduct property of the Order instance using reflection
            orderedProductProperty.SetValue(orderInstance, productInstance);

            // Getting the value of OrderId property using reflection
            int orderId = (int)orderIdProperty.GetValue(orderInstance);

            // Getting the value of Name property of the Product instance
            string productName = (string)productNameProperty.GetValue(productInstance);

            Console.WriteLine($"Order ID: {orderId}");
            Console.WriteLine($"Product Name: {productName}");
        }
    }
}
