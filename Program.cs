using System;
using School.classes;

namespace School
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector<string> vec = new Vector<string>();
			vec.push("3");
			vec.push("8");
			vec.push("5");
			vec.push("7");
			vec.push("1");
			vec.push("9");
			vec.push("4");
			vec.push("2");
			vec.push("0");
			vec.push("6");
			vec.push("Nome1");
			vec.push("Nome2");
			vec.push("Nome3");

			Console.WriteLine(vec[6]);
			Console.WriteLine(vec[4]);
			Console.WriteLine(vec[0]);
			Console.WriteLine(vec.pop());
			Console.WriteLine(vec.pop());
			Console.WriteLine(vec.pop());

			vec.push("teste");
			Console.WriteLine(vec.pop());
			Console.WriteLine(vec.length);

			Vector<string> vec2 = new Vector<string>();
			vec2.push("Teste1");
			vec2.push("Teste2");

			vec.concat(vec2);
			Console.WriteLine(vec.pop());
			Console.WriteLine(vec.pop());
			Console.WriteLine(vec.pop());
			Console.WriteLine(vec.pop());

		}
	}
}
