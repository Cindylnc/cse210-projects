public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;


    public Product (string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_productName} (ID:m{_productId})";
    }

}