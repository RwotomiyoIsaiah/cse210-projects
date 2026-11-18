public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private string _productId;
    //constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _productId = productId;
        _price = price;
        _name = name;
        _quantity = quantity;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    
}