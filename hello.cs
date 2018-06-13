using System;
using System.IO;

namespace Demo
{
	public class Hello()
	{
		public static void Main(object[] args)
		{
			var name = Console.Readline();
			Console.WriteLine($"Hello, {name}");
		}
	}
}
