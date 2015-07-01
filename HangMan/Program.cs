using System;

namespace Hangman
{
	class MainClass
	{

		public static void Main (string[] args)
		{

			try
			{
				Hangman game = new Hangman (args[0], Int32.Parse(args[1]));
				game.Start ();
			} catch
			{
				try
				{
					Hangman game = new Hangman (args[0], 5);
					game.Start ();
				} catch 
				{
					Console.WriteLine ("HangMan.exe <word> <wrongLetterLimit>");
				}
			}
		}

	}
}
