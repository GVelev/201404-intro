//Write a program that extracts from given XML file all the text without the tags
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace textfiles_task10
{
	class MainClass
	{	static void XMLReader(string InputFile, string OutputFile)
		{
			StreamReader InputStream=new StreamReader(InputFile);
			StreamWriter OutputStream=new StreamWriter(OutputFile);
			using (InputStream) {
				using (OutputStream) {
					string line;
					while ((line = InputStream.ReadLine ()) != null) {
						OutputStream.WriteLine(Regex.Match(line,@">.*<"));
					
					

					}
				}
			}

		}
		
							public static void Main (string[] args)
								{
								string Input = "input.xml";
								string Output = "Output.txt";
			XMLReader (Input, Output);
								Console.WriteLine ("Hello World!");

		}
	}
}
