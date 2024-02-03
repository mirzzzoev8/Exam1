using Task6;
var cat = new Cat("Katya");
cat.Greets();
System.Console.WriteLine();

var dog = new Dog("Max");
dog.Greets();
dog.Greets(dog);
System.Console.WriteLine();

var bigDog = new BigDog("Promax");
bigDog.Greets();
bigDog.Greets(dog);
bigDog.Greets(bigDog);
System.Console.WriteLine();