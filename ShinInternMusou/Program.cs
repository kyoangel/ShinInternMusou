using System;
using ShinInternMusou.State;

namespace ShinInternMusou
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var ui = new UserInterface();

			while (!(ui.GetState() is EndGameState))
			{
				ui.InterAct();
			}

			ui.InterAct();

			Console.ReadLine();
		}
	}
}