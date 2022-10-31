using System;
    				
public class Program
{
	
	public static int Ques1(int[] arr) {
		int[] tmp = new int[arr.GetLength(0)];
		for(int i = 0; i<tmp.GetLength(0); i++) tmp[i] = 1;
		for(int i = 0; i<tmp.GetLength(0); i++) {
			for(int j = i-1; j >= 0; j--)
				if(tmp[i] <= tmp[j] && arr[i] < arr[j]) tmp[i] = tmp[j] + 1;
		}
		
		int max = 0;
		for(int i = 0; i<tmp.GetLength(0); i++)
			if(tmp[i] > max) max = tmp[i];
		return max;
	}
		
	public static void Main()
	{
		int[] arr = new int[] {9, 74, 2, 80, 40, 10, 20, 15, 1};
		Console.WriteLine(Ques1(arr));
	}
}