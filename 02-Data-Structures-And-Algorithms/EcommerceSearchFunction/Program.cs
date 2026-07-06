using EcommerceSearchFunction;

Product[] products =
{
    new Product(101, "Laptop", "Electronics"),
    new Product(102, "Keyboard", "Electronics"),
    new Product(103, "Mouse", "Electronics"),
    new Product(104, "Shoes", "Fashion"),
    new Product(105, "Watch", "Accessories")
};

Console.WriteLine("LINEAR SEARCH");

Product? linear = SearchAlgorithms.LinearSearch(products, 104);

if (linear != null)
    Console.WriteLine(linear);

Console.WriteLine();

Console.WriteLine("BINARY SEARCH");

Product? binary = SearchAlgorithms.BinarySearch(products, 104);

if (binary != null)
    Console.WriteLine(binary);