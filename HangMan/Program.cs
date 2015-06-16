using System;

namespace Hangman
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Hangman game = new Hangman ("cyan", 5);
			game.Start ();
		}
	}
}
