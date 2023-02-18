/*
Order
- Contains a list of products and a customer. Can calculate the total cost of the order, and can return 
a string for the packing label, and can return a string for the shipping label.
- The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
- This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
- If the customer does not live in the USA, then the shipping cost is $35.
- A packing label should list the name and product id of each product in the order.
- A shipping label should list the name and address of the customer.
*/

public class Order
{
    // Order variables
    private Product[] products;
    private Customer customer;
    private double final_price;

    // Order constructor method
    public Order(Product[] order_products, Customer order_customer)
    {
        products = order_products;
        customer = order_customer;
        calculateFinalPrice();
    }

    // Method for creating the packing label
    public string createPackingLabel()
    {
        string packinglabel = "Product Name -- Product ID";
        foreach (Product product in products)
        {
            packinglabel += string.Format("\n{0} - {1}", product.getName(), product.getID());
        }
        return packinglabel;
    }

    // Method for creating the shipping label
    public string createShippingLabel()
    {
        string shippinglabel = string.Format("{0}\n{1}", customer.getName(), customer.getAddress().formattedAddress());
        return shippinglabel;
    }

    // Method that calculates the final price of the order
    public void calculateFinalPrice()
    {
        // getting a subtotal of each product in the order
        foreach (Product product in products)
        {
            final_price += product.getTotalPrice();
        }
        if (customer.isAddressInUSA() == true)
        {
            final_price += 5; // domestic shipping fee
        }
        else
        {
            final_price += 35; // international shipping fee
        }
    }

    // GETTER AND SETTER METHODS FOR PRIVATE VARIABLES
    public Product[] getProducts()
    {
        return products;
    }
    public void setProducts(Product[] new_products)
    {
        products = new_products;
    }
    public Customer getCustomer()
    {
        return customer;
    }
    public void setCustomer(Customer new_customer)
    {
        customer = new_customer;
    }
    public double getFinalPrice()
    {
        return final_price;
    }
    public void setFinalPrice(double new_final_price)
    {
        final_price = new_final_price;
    }
}