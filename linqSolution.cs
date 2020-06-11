using System;
using System.Linq;

namespace ConsoleApplication1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//You have two arrays/lists as follows
			int[] list1 = new int[]{1, 2, 3, 4, 5};
			int[] list2 = new int[]{3, 4, 5, 6, 7};
			//a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in  both lists .
			
			// Option1
			//int[] list3 = list1.Intersect(list2).ToArray(); 
			
			//Option2
			var list3 =
				from item1 in list1
				join item2 in list2 on item1 equals item2
				select item1;
			Console.WriteLine(string.Join(" ", list3));
			
			//b. Show the elements from list 1, but is not found in list2. E.g 1 2"
			
			//Otpion1
			int[] list4 = list1.Except(list2).ToArray();
			Console.WriteLine(string.Join(" ", list4));
			//c. Complete here
			int[] list5 = list2.Except(list1).ToArray();
			//Show the elements from list 2, but is not found in list1. E.g 6 7"
			Console.WriteLine(string.Join(" ", list5));
			Console.WriteLine("Press <ENTER> to continue");
			Console.ReadLine();
		}
	}
}