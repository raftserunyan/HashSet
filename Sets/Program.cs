using System;
using System.Collections.Generic;

namespace Sets
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> hs = new HashSet<int>();

			hs.Add(112);
			hs.Add(0);
			hs.Add(11);

			hs.Contains(0);
		}
	}
}
