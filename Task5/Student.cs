namespace Task5;
public class Student : Person
{
    string program;
    int year;
    double fee;

    public Student(string name, string address, string program, int year, double fee) : base(name, address)
    {
        this.program = program;
        this.year = year;
        this.fee = fee;
    }
    public string GetProgram()
    {
        return program;
    }
    public void SetProgram(string program)
    {
        this.program = program;
    }
    public int GetYear()
    {
        return year;
    }
    public void SetYear(int year)
    {
        this.year = year;
    }
    public double GetFee()
    {
        return fee;
    }
    public void SetFee(double fee)
    {
        this.fee = fee;
    }
    public override string ToString()
    {
        return $"Student {base.ToString()}, program = {program}, year = {year}, fee = {fee} ";
    }

}

