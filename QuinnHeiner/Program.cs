using System;
/*

Challenge #1 (due 11/23/2015): Hello W@#$!?
Saw a similar challenge to this one on www.codewars.com and though it would be a good one to kick off this round of code challenges.
 
Description
In order to stop too much communication from happening, your overlords declare that you are no longer allowed to use certain functionality in your code!
 
Disallowed functionality:
· Strings or Chars
· Numbers (including binary)
· Loading pre-existing images, text, or other data files from within your own solution
· Regular Expressions
· Functions, classes, or objects named "Hello", "World", "HelloWorld" or anything similar (including concatenating multiple names using some form of reflection).
Without using the above, output "Hello World!" to prove that there is always a way.
 
Bonus Entry
Submit a solution with fewer than 1000 characters of core program logic (excludes comments, whitespace, unit tests, etc.).  No minifying, please.
 
Submission Instructions
GitHub repo: https://github.com/STGCodeChallenges/Q4-2015-Challenge-01
Google Form (to be filled out upon completion of challenge): https://docs.google.com/a/stgconsulting.com/forms/d/1ZZTzV6E0SKwII54O65HwET5c9z1h1RtbbXkNVbsbJPs/viewform?usp=send_form

 */

namespace O
{
	// class representation of a printable character
	public class O {}
}

namespace CodeChallenge01_HelloWorld
{
	public class Program
	{
		public static readonly O.O O = new O.O();

		// prints "O.O" to the screen, since namespace will be included
		private static void P()
		{
			Console.Write(O);
		}

		// moves cursor to the next COLUMN
		public static void C()
		{
			Console.CursorLeft++;
		}

		// moves cursor to the next ROW
		public static void R()
		{
			Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, ++Console.CursorTop);
		}

		public static void Main()
		{
			// Line 1
			P();C();C();C();P();C();C();C();P();P();P();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();C();C();C();C();C();P();P();P();R();
			
			// Line 2
			P();C();C();C();P();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();P();R();
			
			// Line 3
			P();P();P();C();C();C();P();P();P();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();P();R();
			
			// Line 4
			P();C();C();C();P();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();P();R();
			
			// Line 5
			P();C();C();C();P();C();C();C();P();P();P();C();C();P();P();P();C();C();P();P();P();C();C();P();P();P();R();
			
			// Line 6
			R();
			
			// Line 7
			P();C();C();C();C();P();C();C();C();C();C();P();C();C();C();P();P();P();C();C();P();P();P();C();C();C();P();C();C();C();C();C();C();C();C();P();P();P();C();C();P();R();
			
			// Line 8
			P();C();C();C();C();P();C();C();C();C();C();P();C();C();C();P();C();C();C();P();C();C();P();P();P();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();P();C();C();P();R();
			
			// Line 9
			P();C();C();C();C();P();C();C();C();C();C();P();C();C();C();P();C();C();C();P();C();C();P();C();C();C();P();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();P();C();C();P();R();
			
			// Line 10
			P();C();C();C();C();P();C();C();C();C();C();P();C();C();C();P();C();C();C();P();C();C();P();P();P();C();C();C();P();C();C();C();C();C();C();C();C();P();C();C();C();P();R();
			
			// Line 11
			P();P();P();P();P();P();C();C();C();P();P();P();C();C();P();C();C();C();C();P();C();C();P();P();P();C();C();P();P();P();C();C();P();R();

			Console.ReadKey();
		}
	}
}