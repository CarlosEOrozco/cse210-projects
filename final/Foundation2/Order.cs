public class Order
{
    private Customer customer;
    private List<Product> products;
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }
    public Customer Customer { get { return customer; } }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address}";
    }
}