/*
Customer
- The customer contains a name and an address.
- The name is a string, but the Address is a class.
- The customer should have a method that can return whether they live in the USA or not. 
(Hint this should call a method on the address to find this.)
*/

public class Customer
{
    // Customer variables
    private string name;
    private Address address;

    // Customer constructor method
    public Customer(string customer_name, Address customer_address)
    {
        name = customer_name;
        address = customer_address;
    }

    // Method to return a boolean (true or false) if the address is in the united states
    public bool isAddressInUSA()
    {
        return address.getIsUSA();
    }


    // GETTER AND SETTER METHODS FOR PRIVATE VARIABLES
    public string getName()
    {
        return name;
    }

    public void setName(string new_name)
    {
        name = new_name;
    }

    public Address getAddress()
    {
        return address;
    }

    public void setAddress(Address new_address)
    {
        address = new_address;
    }
}