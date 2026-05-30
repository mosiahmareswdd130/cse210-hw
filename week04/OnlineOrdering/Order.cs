namespace OnlineOrdering;


public class Order
{
    private List<Product> _products;
    private Customer _customer;

    private const double UsaShippingCost = 5.00;
    private const double InternationalShippingCost = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer GetCustomer() => _customer;
    public List<Product> GetProducts() => _products;


    public void SetCustomer(Customer customer) => _customer = customer;


    public void AddProduct(Product product) => _products.Add(product);


    public double GetTotalCost()
    {
        double productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUsa() ? UsaShippingCost : InternationalShippingCost;
        return productTotal + shippingCost;
    }


    public string GetPackingLabel()
    {
        string label = "** Packing Label **\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label.TrimEnd();
    }


    public string GetShippingLabel()
    {
        return $"** Shipping Label **\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
