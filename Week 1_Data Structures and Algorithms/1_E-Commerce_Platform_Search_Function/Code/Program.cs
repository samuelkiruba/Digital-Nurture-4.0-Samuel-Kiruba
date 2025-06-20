using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}

public class ProductSearch
{
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, int targetId)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(103, "Laptop", "Electronics"),
            new Product(101, "Book", "Education"),
            new Product(104, "Phone", "Electronics"),
            new Product(102, "Pen", "Stationery")
        };

        Array.Sort(products, (x, y) => x.ProductId.CompareTo(y.ProductId));

        Console.WriteLine("Searching for Product ID 102 using Linear Search:");
        Product result1 = ProductSearch.LinearSearch(products, 102);
        Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

        Console.WriteLine("\nSearching for Product ID 104 using Binary Search:");
        Product result2 = ProductSearch.BinarySearch(products, 104);
        Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");

        Console.WriteLine("\nLinear Search works on unsorted data with a time complexity of O(n).\nBinary Search requires sorted data with a time complexity of O(log n).\nLinear search works fast for small amounts of data but Binary search is fast for large amounts of data.");
    }
}