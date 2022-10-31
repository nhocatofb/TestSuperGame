using System;
using System.Collections;
    				
public class Program
{
	
	public static int Ques2(int[] arr, int k) {
		Array.Sort<int>(arr);
		int sum = 0;
		int count = 0;
		foreach(int i in arr) {
			sum += i;
			if(sum >= k) break;
			count++;
		}
		return count;
	}
		
	public static void Main()
	{
		int[] arr = new int[] {9, 74, 2, 80, 40, 10, 20, 15, 1};
		int k = 75;
		Console.WriteLine(Ques2(arr, k));
	}
}