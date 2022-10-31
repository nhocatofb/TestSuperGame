using System;
using System.Collections;
    				
public class Program
{
	
	public static int[] Ques3(int[,] arr) {
		ArrayList vertexts = new ArrayList();
		for(int i = 0; i<arr.GetLength(0); i++) {
			int v1 = arr[i, 0];
			int v2 = arr[i, 1];
			if(!vertexts.Contains(v1)) vertexts.Add(v1);
			if(!vertexts.Contains(v2)) vertexts.Add(v2);
		}
		
		ArrayList[] V = new ArrayList[vertexts.Count+1]; 
		
		for(int i = 0; i <= vertexts.Count; i++)
			V[i] = new ArrayList();
		
		for(int i = 0; i<arr.GetLength(0); i++) {
			int v1 = arr[i, 0];
			int v2 = arr[i, 1];
			V[v1].Add(v2);
			V[v2].Add(v1);	  
		}
		int[] result = new int[vertexts.Count];
		for(int i = 1; i<=vertexts.Count; i++) {
			result[i-1] = (BFS(vertexts.Count, V, i));
		}
		return result;
	}
	
	
	public static int count_trace(int[] trace, int fr, int to) {
		if(fr == to) return 0;
		return count_trace(trace, trace[fr], to) + 1;
	}
	
	public static int BFS(int n, ArrayList[] V, int target) {
		int[] trace = new int[n + 1];
		for(int i = 0; i<= n; i++) 
			trace[i] = i;
		
		Queue q = new Queue();
		q.Enqueue(1);
		
		while(q.Count != 0) {
			int v = (int)q.Dequeue();
			if(v==target) {
				return count_trace(trace, target, 1);
			}
			foreach (int i in V[v]) {
				if(trace[i]!=i) continue;
				q.Enqueue(i);
				trace[i] = v;
			}
		}
		return -1;
	}
	
	public static void Main()
	{
		int[,] arr = {{1, 2}, {2, 3}, {1, 3}, {2, 4}};
		int[] shortest_path = Ques3(arr);
		foreach(int i in shortest_path)
			Console.Write(i + " ");
	}
}