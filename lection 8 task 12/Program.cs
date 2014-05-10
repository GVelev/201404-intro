//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;

namespace lection8task12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] alphabet = new char[26];
			for (char i = 'a'; i <='z'; i++) {
				alphabet [i - 'a'] = i;
				Console.Write (alphabet[i-'a']+" ");

			}
			Console.WriteLine ("enter word");
			char[] array = Console.ReadLine ().ToCharArray ();
			foreach (var arr in array) {
				for (int i = 0; i < alphabet.Length; i++) {
					if (arr == alphabet [i]) {
						Console.WriteLine ("letter " + (i+1));
					}
				}
					
				}
			}
		}
	}
