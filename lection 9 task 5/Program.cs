//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;

namespace lection9task5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter string array");
			//int n = int.Parse (Console.ReadLine ());
			string[] array = Console.ReadLine ().Split (' ');
			Array.Sort(array,(x,y)=>(x.Length).CompareTo(y.Length));
			for (int i = 0; i < array.Length; i++){
				Console.Write(array[i]+" ");}
		}
	}
}
