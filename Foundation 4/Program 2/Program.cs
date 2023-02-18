/*
Scenario
You have been hired to help a company with their product ordering system. They sell many products 
online to a variety of customers and need to produce packing labels, shipping labels, and compute 
final prices for billing.
Program Specification
Write a program that has classes for Product, Customer, Address, and Order. The responsibilities of 
these classes are as follows:
Order
- Contains a list of products and a customer. Can calculate the total cost of the order, and can return 
a string for the packing label, and can return a string for the shipping label.
- The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
- This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
- If the customer does not live in the USA, then the shipping cost is $35.
- A packing label should list the name and product id of each product in the order.
- A shipping label should list the name and address of the customer.
Product
- Contains the name, product id, price, and quantity of each product.
- The price of this product is computed by multiplying the price and the quantity.
Customer
- The customer contains a name and an address.
- The name is a string, but the Address is a class.
- The customer should have a method that can return whether they live in the USA or not. (Hint this 
should call a method on the address to find this.)
Address
- The address contains a string for the street address, the city, state/province, and country.
- The address should have a method that can return whether it is in the USA or not.
- The address should have a method to return a string all of its fields together in one string (with 
newline characters where appropriate)
Other considerations
- Make sure that all member variables are private and getters, setters, and constructors are created as 
needed.
Once you have created these classes, write a program that creates at least two orders with 2-3 
products each. Call the methods to get the packing label, the shipping label, and the total price of 
the order, and display the results of these methods.
*/


class Program2
{
    public static void Main(string[] args)
    {
        // First product order (domestic)
        // creating list of products
        Product[] products1 = {
            new Product("Pipes", "P019873", 9.99, 10),
            new Product("Fasteners", "F91348S", 0.99, 5),
            new Product("Flux Capacitor", "FLUX1234", 100, 1)
        };
        // creating the address for the customer
        Address marty_home = new Address("308 Negra Arroyo Lane", "Albuquerque", "NM", "United States");
        // creating the customer
        Customer marty_mcfly = new Customer("Marty McFly", marty_home);
        // creating the order
        Order marty_order = new Order(products1, marty_mcfly);

        // Outputting the order, packing and shipping labels, and final price
        Console.WriteLine("Order 1 - Marty McFly's Order");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(marty_order.createPackingLabel());
        Console.WriteLine();
        Console.WriteLine(marty_order.createShippingLabel());
        Console.WriteLine();
        Console.WriteLine(string.Format("Final Price: {0:c}", marty_order.getFinalPrice()));
        Console.WriteLine();

        // Second product order (domestic)
        // creating list of products
        Product[] products2 = {
            new Product("Tires", "TR00123HK", 234.95, 4),
            new Product("Filters", "FIL91340", 8.99, 2),
            new Product("Bolts", "BLT000013", 0.25, 50)
        };
        // creating the address for the customer
        Address mechanic_shop = new Address("1620 Waukegan Rd", "Glenview", "IL", "USA");
        // creating the customer
        Customer mechanic = new Customer("Mechanic", mechanic_shop);
        // creating the order
        Order mechanic_order = new Order(products2, mechanic);

        // Outputting the order, packing and shipping labels, and final price
        Console.WriteLine("Order 2 - Mechanic's Order");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(mechanic_order.createPackingLabel());
        Console.WriteLine();
        Console.WriteLine(mechanic_order.createShippingLabel());
        Console.WriteLine();
        Console.WriteLine(string.Format("Final Price: {0:c}", mechanic_order.getFinalPrice()));
        Console.WriteLine();


        // Third product order (international)
        // creating list of products
        Product[] products3 = {
            new Product("American Cheese", "123CHEESE", 4.99, 10),
            new Product("American Jeans", "LEVIS09345", 24.99, 5)
        };
        // creating the address for the customer
        Address french_shop = new Address("972 Monte Blanc Boulevard", "Paris", "Île-de-France", "France");
        // creating the customer
        Customer french_man = new Customer("Augustine Le'Clair", french_shop);
        // creating the order
        Order french_order = new Order(products3, french_man);

        // Outputting the order, packing and shipping labels, and final price
        Console.WriteLine("Order 3 - Augustine Le'Clair's Order");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(french_order.createPackingLabel());
        Console.WriteLine();
        Console.WriteLine(french_order.createShippingLabel());
        Console.WriteLine();
        Console.WriteLine(string.Format("Final Price: {0:c}", french_order.getFinalPrice()));
        Console.WriteLine();
    }
}