using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    // Product class
    class Product
    {
        private string name;
        private decimal price;
        private int stock;

        public Product(string name, decimal price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        // Public getters
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }

        // Reduce stock safely
        public bool ReduceStock(int quantity)
        {
            if (quantity <= stock)
            {
                stock -= quantity;
                return true;
            }
            else
            {
                Console.WriteLine($"Not enough stock for {name}.");
                return false;
            }
        }

        // Get current stock
        public int GetStock()
        {
            return stock;
        }
    }

    // ShoppingCart class
    class ShoppingCart
    {
        private List<Product> cartItems = new List<Product>();

        // Add product to cart
        public void AddProduct(Product product)
        {
            cartItems.Add(product);
            Console.WriteLine($"Added {product.Name} to the cart.");
        }

        // Remove product from cart
        public void RemoveProduct(Product product)
        {
            cartItems.Remove(product);
            Console.WriteLine($"Removed {product.Name} from the cart.");
        }

        // Calculate total price
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in cartItems)
            {
                total += item.Price;
            }
            return total;
        }

        // Display cart contents
        public void ShowCart()
        {
            Console.WriteLine("Cart items:");
            foreach (var item in cartItems)
            {
                Console.WriteLine($"{item.Name} - ${item.Price}");
            }
            Console.WriteLine("Total: $" + CalculateTotal());
        }

        // Get the list of items (read-only)
        public List<Product> GetItems()
        {
            return new List<Product>(cartItems);
        }
    }

    // Order class
    class Order
    {
        private string customerName;
        private ShoppingCart cart;

        public Order(string customerName, ShoppingCart cart)
        {
            this.customerName = customerName;
            this.cart = cart;
        }

        // Public getter for customer name
        public string CustomerName { get { return customerName; } }

        // Place the order
        public void PlaceOrder()
        {
            Console.WriteLine($"Order placed by {customerName}.");
            cart.ShowCart();
            Console.WriteLine("Thank you for your purchase!");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create products
            Product product1 = new Product("Laptop", 1200m, 5);
            Product product2 = new Product("Mouse", 25m, 10);

            // Create shopping cart
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            // Place an order
            Order order = new Order("Alice", cart);
            order.PlaceOrder();
        }
    }
}
