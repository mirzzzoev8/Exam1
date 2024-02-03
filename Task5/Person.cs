namespace Task5;
public class Person
{
    string name;
    string address;

    public Person(string name, string address)
    {
       this.name = name;
       this.address = address;
    }
    public string GetName()
    {
        return name;
    }
    public void SetAddress(string address)
    {
        this.address = address;
    }
    public string GetAddress()
    {
        return address;
    }
   
    public override string ToString()
    {
        return $" Person name = {name}, address={address} ";
    }


}
