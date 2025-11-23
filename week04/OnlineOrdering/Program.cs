using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    // Product class
    class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        private int stock;

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            this.stock = stock;
        }

        public bool ReduceStock(int quantity)
        {
            if (quantity <= stock)
            {
                stock -= quantity;
                return true;
            }
            else
            {
                Console.WriteLine($"Not enough stock for {Name}");
                return false;
            }
        }

        public int GetStock()
        {
            return stock;
        }
    }

    // ShoppingCart class
    class ShoppingCart
    {
        private List<Product> cartItems = new List<Product>();

        public void AddProduct(Product product)
        {
            cartItems.Add(product);
            Console.WriteLine($"Added {product.Name} to the cart.");
        }

        public void RemoveProduct(Product product)
        {
            cartItems.Remove(product);
            Console.WriteLine($"Removed {product.Name} from the cart.");
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in cartItems)
            {
                total += item.Price;
            }
            return total;
        }

        public void ShowCart()
        {
            Console.WriteLine("Cart items:");
            foreach (var item in cartItems)
            {
                Console.WriteLine(item.Name + " - $" + item.Price);
            }
            Console.WriteLine("Total: $" + CalculateTotal());
        }
    }

    // Order class
    class Order
    {
        private ShoppingCart cart;
        public string CustomerName { get; private set; }

        public Order(string customerName, ShoppingCart cart)
        {
            CustomerName = customerName;
            this.cart = cart;
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"Order placed by {CustomerName}.");
            cart.ShowCart();
            Console.WriteLine("Thank you for your purchase!");
        }
    }

    class Program
    {
        static void Main()
        {
            Product product1 = new Product("Laptop", 1200m, 5);
            Product product2 = new Product("Mouse", 25m, 10);

            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            Order order = new Order("Alice", cart);
            order.PlaceOrder();
        }
    }
}
