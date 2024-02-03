namespace Task6;
public class BigDog : Dog
{
    public BigDog(string name) : base(name) {}

    public override void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Greets(Dog another)
    {
        System.Console.WriteLine("Woooooow");
    }
    public void Greets(BigDog another)
    {
        System.Console.WriteLine("Wooooooooooow");
    }



}
