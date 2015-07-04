using System;
using System.Collections.Generic;
using System.Diagnostics;


public class TestaAdicionaNoFinal
{
	static void Main()
	{
		List<int> arrayList = new List<int>();

		long tempo = TestaAdicionaNoFinal.AdicionaNoFinal(arrayList);
		Console.WriteLine("ArrayList: " + tempo + "ms");

		LinkedList<int> linkedList = new LinkedList<int>();

		tempo = TestaAdicionaNoFinal.AdicionaNoFinal(linkedList);
		Console.WriteLine("LinkedList: " + tempo + "ms");
	}

	public static long AdicionaNoFinal (ICollection<int> lista)
	{
		Stopwatch sw = new Stopwatch();

		sw.Start();
		int size
	}
	}
}

