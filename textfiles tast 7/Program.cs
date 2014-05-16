//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace textfiles_task7
{
	class MainClass
	{	const string InputFile=@"input.txt";
		const string OutputFile=@"replaced text.txt";
		static void ReplaceString(string InputFile, string OutputFile)
		{
			StreamReader InputSream = new StreamReader (InputFile);
			StreamWriter OutputStream = new StreamWriter (OutputFile);
			string Readtext;
			string pattern = @"\bstart\b";
			using (InputSream) {
				using (OutputStream) {
					while((Readtext = InputSream.ReadLine () )!= null)
					{
						//Readtext = InputSream.ReadLine ();
						OutputStream.WriteLine(Regex.Replace(Readtext, pattern, "finish "));
					} 
				}
			}
		}
		public static void Main (string[] args)
		{	const string InputFile=@"../../input.txt";
			const string OutputFile=@"../../replaced text.txt";
			ReplaceString (InputFile, OutputFile);
			Console.WriteLine ("Complete");

		}
	}
}
