namespace OnlineOrdering;


public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Getters
    public string GetName() => _name;
    public string GetProductId() => _productId;
    public double GetPricePerUnit() => _pricePerUnit;
    public int GetQuantity() => _quantity;

    // Setters
    public void SetName(string name) => _name = name;
    public void SetProductId(string productId) => _productId = productId;
    public void SetPricePerUnit(double pricePerUnit) => _pricePerUnit = pricePerUnit;
    public void SetQuantity(int quantity) => _quantity = quantity;


    public double GetTotalCost() => _pricePerUnit * _quantity;
}
