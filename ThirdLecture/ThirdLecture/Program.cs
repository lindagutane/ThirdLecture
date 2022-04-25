//First task

using ThirdLecture;

FirstTaskPhone phone = new FirstTaskPhone();
phone.SizeInch = 10.05;
phone.Brand = "IPhone";
phone.Model = "12";

phone.Call();
phone.WriteSMS();

Console.WriteLine();
Console.WriteLine("---------------------------");
Console.WriteLine();

//Second task

SecondTaskCar car = new SecondTaskCar();
car.CarNumberPlate = "AB1234";
car.CarModel = "E60";
car.CarBrand = "BMW";
car.CarSpeed = 0;

Console.WriteLine($"Car brand is {car.CarBrand}, model is {car.CarModel}, number plate is {car.CarNumberPlate}");

car.Drive();
car.IncreaseSpeed();
car.StopDriving();
car.BeepBeep();

Console.WriteLine();
Console.WriteLine("---------------------------");
Console.WriteLine();

//Third task

ThirdTaskProduct product = new ThirdTaskProduct(10.01, 5.05, 1.00);

product.Description();

product.ProductParametrs(product.Lenght, product.Width, product.Weight);

Console.WriteLine();
Console.WriteLine("---------------------------");
Console.WriteLine();

//Fourth task

FourthTaskPerson person = new FourthTaskPerson();

Console.WriteLine($"Lūdzu, norādiet savu vārdu: ");
person.Name = Console.ReadLine();
Console.WriteLine($"Lūdzu, norādiet savu uzvārdu: ");
person.Surname = Console.ReadLine();

Console.WriteLine($"Lūdzu, norādiet savu dzimšanas datumu formātā MM/DD/YYYY: ");

person.BirthDate = DateTime.Parse(Console.ReadLine());

person.Hoby = "dance";
person.IsFemale = true;

person.Greeting();

Console.WriteLine();
Console.WriteLine("---------------------------");
Console.WriteLine();