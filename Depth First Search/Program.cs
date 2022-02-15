 /* 
 This program will print a Depth First Search traversal from a given graph.
 */

 using System;
 using System.Collections.Generic;

 class Graph {
     // Variable for the number of vertices
     private int numV;

     // Array of lists for adjacency list representation.
     private List<int>[] adj;

     Graph(int v) {
         numV = v;
         adj = new List<int>[v];
         for(int i = 0; i < v; i++){
             adj[i] = new List<int>();
         }
     }

     // Function that adds an edge into the graph
     void AddEdge(int v, int w){
         adj[v].Add(w);
     }

     // Function used by DFS
     void DFSUtility(int v, bool[] visited){
         // Mark the current node as visited and print it.
         visited[v] = true;
         Console.Write(v + " ");

         // Recursion for all the vertices adjacent to this vertex
         List<int> vList = adj[v];
         foreach(var n in vList){
             if(!visited[n]){
                 DFSUtility(n, visited);
             }
         }
     }

     // Function that does DFS traversal using recursion (DFSUtility)
     void DFS(int v) {
         // Mark all vertices as not visited
         bool[] visited = new bool[numV];

         // Call DFSUtility for recursion and to print traversal
         DFSUtility(v, visited);
     }

     // Driver Code
     public static void Main(string[] args){
         Graph g = new Graph(4);

         g.AddEdge(0, 1);
         g.AddEdge(0, 2);
         g.AddEdge(1, 2);
         g.AddEdge(2, 0);
         g.AddEdge(2, 3);
         g.AddEdge(3, 3);

         Console.WriteLine("Following is Depth First Traversal starting from vertex 2");

         g.DFS(2);
         Console.ReadKey();
     }
 }