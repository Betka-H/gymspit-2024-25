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

/* pizza
internal class Program
{
	public class pizza
	{
		public float diameter { get; set; }
		public string sauce { get; set; }
		public List<string> toppings { get; set; }
		public pizza()
		{

		}

		public void serve()
		{
			Console.WriteLine($"diameter: {diameter}, sauce: {sauce}, toppings: {printToppings()}");
		}
		string printToppings()
		{
			string result = " ";
			foreach (string t in toppings)
			{
				result += t + ", ";
			}
			return result;
		}
	}

	public class pizzaBuilder
	{
		public float diameter { get; set; } = 32;
		public string sauce { get; set; } = "tomato";
		public List<string> toppings { get; set; } = new List<string> { "cheese", "more cheese" };
		public pizzaBuilder()
		{

		}

		public pizzaBuilder withDiameter(float dia)
		{
			diameter = dia;
			return this;
		}
		public pizzaBuilder withSauce(string sau)
		{
			sauce = sau;
			return this;
		}
		public pizzaBuilder withToppings(List<string> top)
		{
			toppings = top;
			return this;
		}
		public void addTopping(string top)
		{
			toppings.Add(top);
		}

		public pizza build()
		{
			pizza buildPizza = new pizza();
			{
				buildPizza.diameter = diameter;
				buildPizza.sauce = sauce;
				buildPizza.toppings = toppings;
			}
			return buildPizza;
		}
	}

	private static void Main(string[] args)
	{
		pizzaBuilder pBuilder = new pizzaBuilder();
		pBuilder.withDiameter(42).withSauce("tomato").withToppings(new List<string> { "cheese", "loads of cheese" });
		pizza pizza1 = pBuilder.build();
		pBuilder.withDiameter(16).withSauce("no sauce");
		pizza pizza2 = pBuilder.build();
		pizza1.serve();
		pizza2.serve();
	}
}
 */

/* 
struktura tříd na počítání výrazů podle schématu (composite pattern)
Třída BinaryExpression bere v konstruktoru dvě instance IExpression (left a right).
Třída UnaryExpression pouze jednu.
Třída Number také implementuje IExpression, ale její evaluate metoda vrací pouze číslo, které dostane v konstruktoru
 */
/* 
internal class Program
{

	class IExpression
	{
		number number;

		public IExpression(number num)
		{
			number = num;
		}

		number evaluate()
		{
			return number;
		}
	}

	class unaryExpression : IExpression
	{
		number number;

		public unaryExpression(number num)
		{
			number = num;
		}
	}
	class binaryExpression : IExpression
	{

	}
	class number : IExpression
	{
		protected float value;

		public number(float val)
		{
			value = val;
		}
	}

	private static void Main(string[] args)
	{
		number a = new number(420.69f);
	}
}
 */
/* 
internal class Program
{
	class IExpression
	{
		double number;

		public IExpression(double num)
		{
			number = num;
		}

		double evaluate()
		{
			return number;
		}
	}

	class numberExpression : IExpression
	{
		public double number;

		public numberExpression(double num)
		{
			number = num;
		}
	}

	class addExpression : IExpression
	{
		public addExpression()
		{

		}
	}

	class builder : IExpression
	{
		double number;

		public builder(double num)
		{
			number = num;
		}

		public IExpression add(double num)
		{
			return add(num);
		}
		public IExpression add(IExpression exp)
		{
			return addExpression(exp);
		}

	}

	private static void Main(string[] args)
	{
		var result = new builder(0).add().multiply();
	}
}
 */


/* 
Zadání: Evidence knih v knihovně
Vytvořte konzolovou aplikaci v jazyce C#, která bude simulovat jednoduchou evidenci knih v knihovně. Aplikace bude mít možnost přidávat knihy, vyhledávat knihy podle různých kritérií, exportovat knihy do souboru a zobrazovat různé statistiky.

Požadavky na aplikaci
Třída Kniha:

Vytvořte třídu Kniha, která bude obsahovat následující vlastnosti:
string Nazev – Název knihy.
string Autor – Autor knihy.
DateTime DatumVydani – Datum vydání knihy.
string Zanr – Žánr knihy.
int PocetStran – Počet stran knihy.
Práce s kolekcemi:

Použijte List<Kniha> pro ukládání knih. Na začátku by měl být seznam prázdný.
Implementujte metody pro přidání knihy, vyhledávání knihy a odstranění knihy.
Vyhledávání knih:

Umožněte uživateli vyhledávat knihy podle:
Jména autora
Žánru
Rozsahu počtu stran
Pro vyhledávání použijte LINQ dotazy a umožněte filtrovat a řadit výsledky podle názvu nebo datumu vydání.
Export knih:

Implementujte funkci pro export knih do textového souboru. Každá kniha by měla být uložena na samostatném řádku ve formátu:
Zkopírovat kód
Nazev;Autor;DatumVydani;Zanr;PocetStran
Použijte System.IO pro práci se soubory.
Statistiky:

Vytvořte funkci pro zobrazení následujících statistik:
Celkový počet knih.
Průměrný počet stran knih.
Nejstarší a nejnovější kniha.
Počet knih podle žánru (např. Kolik knih je beletrie, kolik naučná literatura apod.)
Uživatelské rozhraní:

Implementujte jednoduché textové uživatelské rozhraní, které umožní uživateli:
Přidat novou knihu.
Vyhledávat knihy podle kritérií.
Zobrazit seznam všech knih.
Exportovat knihy do souboru.
Zobrazit statistiky o knihách.
Ujistěte se, že každý krok programu má jasnou zpětnou vazbu.
Zpracování výjimek:

Ošetřete možné výjimky, které mohou nastat při práci se soubory nebo při zadávání vstupu od uživatele (např. špatně zadané datum).
V případě chyby zobrazte uživateli srozumitelnou zprávu a nabídněte možnost pokračovat.
Příklad vstupu a výstupu
 */



internal class Program
{
	class book
	{
		public string name;
		public string author;
		public DateTime DOR;
		public string genre;
		public int pages;

		public book(string name, string author, DateTime DOR, string genre, int pages)
		{
			this.name = name;
			this.author = author;
			this.DOR = DOR;
			this.genre = genre;
			this.pages = pages;
		}

		public string bookToString()
		{
			return $"name: {name}, author: {author}, date of release: {DOR}, genre: {genre}, pages: {pages}";
		}

		public void saveToFile()
		{
			string fileName = $"{name} ({author})";
			using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\eliza\\Downloads", fileName + ".txt")))
			{
				outputFile.WriteLine(bookToString());
			}
		}
	}

	class library
	{
		List<book> books;

		public library()
		{
			books = new List<book>();
		}

		public void addBook(book b)
		{
			if (!books.Contains(b))
				books.Add(b);
			else Console.WriteLine("cannot have duplicate books");
		}

		public void removeBook(book b)
		{
			if (!books.Contains(b))
				books.Remove(b);
			else Console.WriteLine("cannot find book");
		}

		public void searchAll(string s)
		{
			List<book> results = new List<book>();

		}

		List<book> searchByName(string n)
		{
			List<book> results = new List<book>();
			foreach (book b in books)
			{
				if (b.name.Contains(n))
				{
					results.Add(b);
				}
			}
			return results;
		}
		List<book> searchByAuthor(string n)
		{
			List<book> results = new List<book>();
			foreach (book b in books)
			{
				if (b.author.Contains(n))
				{
					results.Add(b);
				}
			}
			return results;

		}
	}

	static void Main(string[] args)
	{
		book book1 = new book("name", "authror", new DateTime(24, 11, 5), "genr", 5);
		book1.saveToFile();
	}
}