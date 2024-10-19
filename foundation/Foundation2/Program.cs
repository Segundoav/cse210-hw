using System;
using System.Collections.Generic;

class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()

    {
        return $"Product: {_name}, ID: {_productId}";
    }
}

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

}

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)

    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}

class Order

{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        // Shipping cost

        if (_customer.LivesInUSA())
        {
            total += 5;
        }

        else
        {
            total +=35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("141 Main St", "Miami","Florida", "USA");
        Address address2 = new Address("242 Main St", "Provo", "Utah", "USA");

        // Create customer
        Customer customer1 = new Customer("Juan Ramirez", address1);
        Customer customer2 = new Customer("Eduardo Diaz", address2);

        // Create product
        Product product1 = new Product("Smatphone", "C123", 600, 2);
        Product product2 = new Product("Printer", "H234", 700, 1);

        // Create order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        // Order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");   
    }  
}
