namespace ConsolePro
{
	class Base
	{
		protected string Name;

		public Base(string Name)
		{ 
			this.Name = Name;
			Console.WriteLine($"{this.Name}.Base()"); 
		}

		~Base()
		{
			Console.WriteLine($"{this.Name}.~Base()"); 
		}

		public void BaseMethod()
		{
			Console.WriteLine($"{Name}.BaseMethod()"); 
		}
	}

	class Derived : Base 
	{
		public Derived(string Name) : base(Name)
		{
			Console.WriteLine($"{this.Name}.Derived()");
		}

		~Derived()
		{
			Console.WriteLine($"{this.Name}.~Derived()");
		}

		public void ProgramMethod()
		{
			Console.WriteLine($"{Name}.DerivedMethod()"); 
		}

		static void Main(string[] args)
		{
			Base a = new Base("a");
			a.BaseMethod();

			Derived b = new Derived("b"); 
			b.BaseMethod();
			b.ProgramMethod();			
		}
	}
}
