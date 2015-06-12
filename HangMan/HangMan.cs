using System;

namespace Hangman
{
	public class Hangman
	{

		private string _word;
		private string _guessedWord;
		private string _guessedLetters;
		private string _wrongLetters;
		private int _guessLimit;
		private bool _inProgress = true;

		public Hangman (string word, int guessLimit)
		{
			this._word = word.ToLower();
			this._guessLimit = guessLimit;
		}

		//initialize game
		public void Start()
		{
			_wrongLetters = "";
			_guessedLetters = "";

			//initialize guessed word string
			foreach (char item in _word)
			{
				_guessedWord += '_';
			}

			//guess spaces for player
			_guessedWord = CheckGuess (' ');
			_wrongLetters = "";

			//print initial letter spaces
			Console.WriteLine (_guessedWord);

			Run ();
		}

		//run game
		private void Run()
		{
			while (_inProgress)
			{
				DoGuess ();
			}
		}

		//execute one guessing round of hangman
		private void DoGuess ()
		{
			char guess = GetGuess();
			
			_guessedWord = CheckGuess(guess);

			_guessedLetters += guess;

			Console.WriteLine (_guessedWord);

			if (_guessedWord == _word)
			{
				_inProgress = false;
			} else if (_wrongLetters.Length > _guessLimit-1)
			{
				_inProgress = false;
			}

		}

		//gets char guess
		private char GetGuess() {
			
			char letter = Console.ReadKey().KeyChar;

			Console.WriteLine();
			return letter;
		}

		//checks if guess is in word. returns guessedWord.
		private string CheckGuess (char letter)
		{
			string guessedWord = "";

			if (!IsDuplicate (letter))
			{
				for (int i = 0; i < _word.Length; i++)
				{
					if (letter == _word [i])
					{
						guessedWord += letter;
					} else
					{
						if (_guessedWord [i] != '_')
						{
							guessedWord += _guessedWord [i];
						} else
						{
							guessedWord += '_';
						}
					}
				}

				if (!IsCorrect (guessedWord))
				{
					_wrongLetters += letter;
				}
				return guessedWord;
			} else
			{
				return _guessedWord;
			}

			
		}

		//check if guess is a duplicate
		private bool IsDuplicate (char letter)
		{
			foreach (char item in _guessedLetters)
			{
				if (letter == item)
				{
					return true;
				}
			}
			return false;
		}

		//check if guess was in word
		private bool IsCorrect (string guessedWord)
		{
			if (_guessedWord == guessedWord)
				return false;
			return true;
		}
	}
}


