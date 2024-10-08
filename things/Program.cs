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

/* internal class Program
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

} */

/* 
internal class Program
{
	class bike
	{
		protected int cadence;
		protected int speed;
		protected int gear;
		public bike(int c, int s, int g)
		{
			cadence = c;
			speed = s;
			gear = g;
		}
		public virtual void printStats()
		{
			Console.Write($"cadence: {cadence}, speed: {speed}, gear: {gear}");
		}
	}
	class roadBike : bike
	{
		protected int tireWidth;
		public roadBike(int c, int s, int g, int t) : base(c, s, g)
		{
			tireWidth = t;
		}
		public override void printStats()
		{
			base.printStats();
			Console.WriteLine($", tire width: {tireWidth}");
		}
	}
	class mountainBike : bike
	{
		private int suspension;
		public mountainBike(int c, int s, int g, int sus) : base(c, s, g)
		{
			suspension = sus;
		}
		public override void printStats()
		{
			base.printStats();
			Console.WriteLine($", suspension: {suspension}");
		}
	}

	class basicBikeRepair
	{
		public basicBikeRepair(bike b)
		{
			tryRepair(b);
		}

		public virtual void tryRepair(bike b)
		{
			if (b.GetType() != typeof(bike))
			{
				Console.WriteLine("cannot repair non-regular bike");
			}
			else
			{
				Console.WriteLine("cool regular bike");
			}
		}
	}
	class roadBikeRepair : basicBikeRepair
	{
		public roadBikeRepair(bike b) : base(b)
		{
			tryRepair(b);
		}

		public override void tryRepair(bike b)
		{
			if (b.GetType() != typeof(roadBike))
			{
				Console.WriteLine("cannot repair non-road bike");
			}
			else
			{
				Console.WriteLine("cool road bike");
			}
		}
	}
	class mountainBikeRepair : basicBikeRepair
	{
		public mountainBikeRepair(bike b) : base(b)
		{
			if (b.GetType() != typeof(mountainBike))
			{
				Console.WriteLine("cannot repair non-mountain bike");
			}
			else
			{
				Console.WriteLine("cool mountain bike");
			}
		}
	}

	static void Main(string[] args)
	{
		bike bikeBike = new bike(-2, -1, 0);
		bike bikeRoad = new roadBike(1, 2, 3, 4);
		bike bikeMountain = new mountainBike(5, 6, 7, 8);

		basicBikeRepair b1 = new basicBikeRepair(bikeRoad);
		b1 = new basicBikeRepair(bikeBike);
		b1 = new roadBikeRepair(bikeRoad);
		b1 = new roadBikeRepair(bikeBike);
	}
}
 */

/* 
internal class Program
{
	abstract class document
	{
		public virtual void display()
		{
			Console.WriteLine("document");
		}
	}

	class invoiceDoc : document
	{
		string contents;
		public invoiceDoc(string c)
		{
			contents = c;
		}

		public override void display()
		{
			base.display();
			Console.WriteLine($"invoice contents: {contents}");
		}
	}
	class reportDoc : document
	{
		string contents;
		public reportDoc(string c)
		{
			contents = c;
		}

		public override void display()
		{
			base.display();
			Console.WriteLine($"report contents: {contents}");
		}
	}

	abstract class docFactory
	{
		public virtual document createDoc(string c)
		{
			Console.WriteLine("creating document");
			return null;
		}
	}

	class invoiceFac : docFactory
	{
		public override document createDoc(string c)
		{
			base.createDoc();
			return new invoiceDoc(c);
		}
	}
	class reportFac : docFactory
	{
		public override document createDoc(string c)
		{
			base.createDoc();
			return new reportDoc(c);
		}
	}

	private static void Main(string[] args)
	{
		docFactory invoiceFactory = new invoiceFac();
		docFactory reportFactory = new reportFac();
		invoiceFactory.createDoc();
	}
}
 */

internal class Program
{
	public interface document
	{
	}

	public interface docFactory
	{
		public document createDoc();
	}

	class displayDoc
	{
		void printContents()
		{
			Console.WriteLine();
		}
	}

	private static void Main(string[] args)
	{

	}
}