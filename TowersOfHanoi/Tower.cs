using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
	class Tower
	{
		Stack<int> Tower1;
		Stack<int> Tower2;
		Stack<int> Tower3;

		int moves;
		public Tower()
		{
			Tower1 = new Stack<int>();
			Tower2 = new Stack<int>();
			Tower3 = new Stack<int>();
		}

		void MoveTower(int ring, Stack<int> source, Stack<int> dest, Stack<int> spare)
		{
			moves++;
			if(ring == 1)
			{
				dest.Push(source.Pop());
			}else
			{
				MoveTower(ring - 1, source, spare, dest);
				dest.Push(source.Pop());
				MoveTower(ring-1, spare, dest, source);
			}
		}

		public void Solve(int size)
		{
			Tower1.Clear();
			Tower2.Clear();
			Tower3.Clear();
			for (int i = size-1; i >= 0; i--)
			{
				Tower1.Push(i);
			}
			Stopwatch sw = new Stopwatch();
			sw.Start();
			MoveTower(size, Tower1, Tower3, Tower2);
			sw.Stop();
			int count = Tower3.Count;
			for (int i = 0; i < count; i++)
			{
				Console.WriteLine(Tower3.Pop());
			}
			Console.WriteLine("moves: "+moves);
			Console.WriteLine("time: "+ sw.ElapsedMilliseconds+"ms");
		}
	}
}
