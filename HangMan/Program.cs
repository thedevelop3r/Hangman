using System;

namespace Hangman
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Hangman game = new Hangman ("robert james meade", 5);
			game.Start ();
		}
	}
}
