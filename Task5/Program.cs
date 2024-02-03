using Task5;

var student = new Student("Yusufjon", "dushanbe", "C#", 1, 2000);
System.Console.WriteLine(student.GetProgram());
System.Console.WriteLine(student.GetYear());
System.Console.WriteLine(student.GetFee());
System.Console.WriteLine(student.ToString());

System.Console.WriteLine("****************");

var staff = new Staff("Yusuf", "xujand", "JS", 1000);
System.Console.WriteLine(staff.GetSchool());
System.Console.WriteLine(staff.GetPay());
System.Console.WriteLine(staff.ToString());