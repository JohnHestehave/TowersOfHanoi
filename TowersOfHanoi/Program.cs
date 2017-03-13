using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
	class Program
	{
		static void Main(string[] args)
		{
			Tower Tower = new Tower();
			Tower.Solve(3);

			Console.ReadKey();
		}
	}
}
