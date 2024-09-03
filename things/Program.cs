/* int readNumber()
{
	int x;
	Console.Write("please input an integer value: ");
	while (!Int32.TryParse(Console.ReadLine().Trim(), out x))
	{
		Console.WriteLine("NaN");
	}
	return x;
}

readNumber();
Console.WriteLine("ok cool\nnow input 2 numbers");

int a = readNumber();
int b = readNumber();

Console.WriteLine("what do you want to do with them?");
Console.Write("a: add, s: subtract, m: multiply ");
switch (Console.ReadLine().Trim().ToLower())
{
	case "a":
		Console.WriteLine($"it's {a + b}");
		break;
	case "s":
		Console.WriteLine($"it's {a - b}");
		break;
	case "m":
		Console.WriteLine($"it's {a * b}");
		break;
	default:
		// Console.WriteLine("not an option");
		break;
}
Console.WriteLine("CONFRATULATIOSN");
Console.WriteLine("alright something different");
		int[] numbers = new int[] { 1, 24, 65, 43, 32, 23, 4, 2 };

		int sum = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.Write(numbers[i]);
			if (i < numbers.Length - 1)
			{
				Console.Write(", ");
			}
			sum += numbers[i];
		}

		Console.WriteLine($"\naverage: {sum / numbers.Length}");*/

internal class Program
{
	private static void Main(string[] args)
	{
		Car car1 = new Car("yo mama", "skibidi", 2003);
		Console.WriteLine(car1.ToString());
	}

	public class Car
	{
		public string manufacturer,
		   modelName;
		public int year;
		public Guid vinCode;

		public Car(string manufacturer, string modelName, int year)
		{
			this.manufacturer = manufacturer;
			this.modelName = modelName;
			this.year = year;
			vinCode = Guid.NewGuid();
		}

		public override string? ToString()
		{
			return $"{manufacturer} {modelName}, year {year}, vin: {vinCode}";
		}
	}

}