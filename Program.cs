using System;
using School.classes;

namespace School
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector<string> vec = new Vector<string>();
			vec.push("0");
			vec.push("1");
			vec.push("2");
			vec.push("3");
			vec.push("4");

			display(vec);
			vec[3] = "testing";
			display(vec);

		}

		static void display(Vector<string> vec)
		{
			for (int i = 0; i < vec.length; i++)
			{
				Console.Write($"{vec[i]} -> ");
			}
			Console.WriteLine();
		}
	}
}
