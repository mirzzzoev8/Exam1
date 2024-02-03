List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };

System.Console.WriteLine("Max : " + list.Max());
System.Console.WriteLine("***********************************");

for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list.Count; j++)
    {
        if (list[i] == list[j])
        {
            list.Remove(list[i]);
        }
    }
}
foreach (var i in list)
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("*************************");

list.Sort();
foreach (var i in list)
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("**************************");


List<int> list2 = list.FindAll(e=> e < 0);
for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list2.Count; j++)
    {
        if (list[i] == list[j])
        {
            list[i] = 0;
        }
    }

}
foreach (var i in list)
{
    System.Console.WriteLine(i);
}








