internal class Program
{
	public interface IExpression
	{
		double evaluate();
		string makeString();
	}

	internal class numberExpression : IExpression
	{
		private double value { get; set; }

		public numberExpression(double value)
		{
			this.value = value;
		}

		public double evaluate()
		{
			return value;
		}

		public string makeString()
		{
			return value.ToString();
		}
	}

	internal abstract class unaryExpression : IExpression
	{
		public IExpression child;

		public unaryExpression(IExpression child)
		{
			this.child = child;
		}

		public abstract double evaluate();

		public abstract string makeString();
	}

	public abstract class binaryExpression : IExpression
	{
		public IExpression left;
		public IExpression right;

		public binaryExpression(IExpression left, IExpression right)
		{
			this.left = left;
			this.right = right;
		}

		public abstract double evaluate();

		public abstract string makeString();
	}


	internal class negationExpression : unaryExpression
	{
		public negationExpression(IExpression child) : base(child)
		{
		}

		public override double evaluate()
		{
			return -child.evaluate();
		}

		public override string makeString()
		{
			return $"(-{child.makeString()})";
		}
	}


	internal class additionExpression : binaryExpression
	{
		public additionExpression(IExpression left, IExpression right) : base(left, right)
		{
		}

		public override double evaluate()
		{
			return left.evaluate() + right.evaluate();
		}

		public override string makeString()
		{
			return $"({left.makeString()} + {right.makeString()})";
		}
	}

	internal class subtractionExpression : binaryExpression
	{
		public subtractionExpression(IExpression left, IExpression right) : base(left, right)
		{
		}

		public override double evaluate()
		{
			return left.evaluate() - right.evaluate();
		}

		public override string makeString()
		{
			return $"({left.makeString()} - {right.makeString()})";
		}
	}

	internal class multiplicationExpression : binaryExpression
	{
		public multiplicationExpression(IExpression left, IExpression right) : base(left, right)
		{
		}

		public override double evaluate()
		{
			return left.evaluate() * right.evaluate();
		}

		public override string makeString()
		{
			return $"({left.makeString()} * {right.makeString()})";
		}
	}

	internal class divisionExpression : binaryExpression
	{
		public divisionExpression(IExpression left, IExpression right) : base(left, right)
		{
		}

		public override double evaluate()
		{
			return left.evaluate() / right.evaluate();
		}

		public override string makeString()
		{
			return $"({left.makeString()} / {right.makeString()})";
		}
	}

	internal class exponentiationExpression : binaryExpression
	{
		public exponentiationExpression(IExpression left, IExpression right) : base(left, right)
		{
		}

		public override double evaluate()
		{
			return Math.Pow(left.evaluate(), right.evaluate());
		}

		public override string makeString()
		{
			return $"{left.makeString()}^({right.makeString()})";
		}
	}


	public class expressionBuilder
	{
		private IExpression expression;

		public expressionBuilder(double num)
		{
			expression = new numberExpression(num);
		}


		public expressionBuilder add(double num)
		{
			var exp = new numberExpression(num);
			return add(exp);
		}

		public expressionBuilder add(IExpression exp)
		{
			var newResult = new additionExpression(expression, exp);
			expression = newResult;

			return this;
		}

		public expressionBuilder subtract(double num)
		{
			var exp = new numberExpression(num);
			return subtract(exp);
		}

		public expressionBuilder subtract(IExpression exp)
		{
			expression = new subtractionExpression(expression, exp);
			return this;
		}

		public expressionBuilder multiply(double num)
		{
			var exp = new numberExpression(num);
			return multiply(exp);
		}

		public expressionBuilder multiply(IExpression exp)
		{
			expression = new multiplicationExpression(expression, exp);
			return this;
		}

		public expressionBuilder divide(double num)
		{
			var exp = new numberExpression(num);
			return divide(exp);
		}

		public expressionBuilder divide(IExpression exp)
		{
			expression = new divisionExpression(expression, exp);
			return this;
		}

		public IExpression build()
		{
			return expression;
		}
	}

	static void Main(string[] args)
	{
		IExpression result = new expressionBuilder(5).add(new negationExpression(new numberExpression(3))).add(new expressionBuilder(3).divide(2).build()).multiply(2).build();

		Console.WriteLine(result.makeString() + " = " + result.evaluate());
	}
}
