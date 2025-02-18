using System.Net.Http.Headers;

public class Order
{
    private Customer _customer;
    private List<Product> _products;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetOrderTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        return total + GetShippingCost();
    }

    public double GetShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetProductInfo()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress()}\n";
    }


}