using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22___Dynamic_Tree_Creation
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Tree t = new Tree();
			Random rand = new Random();

			// Loop count.
			int loopCount = 10;
			
			Console.WriteLine("Inserting values into the Tree.");
			for (int index = 0; index <= loopCount; index++)
			{
				int randValue = rand.Next(1, 100);
				t.Insert(randValue);
			}

			Console.WriteLine("Printing values:");
			t.Print();
			Console.ReadLine();
		}
	}
}
