/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using UnityEngine;

public class Astar
{

    public static void FindPath(IGraph<object> graph, object startNode, object endNode, List<object> outputPath, int maxiterations = 1000)
    {
            Node start = new Node((Vector3Int)startNode);
            Node end = new Node((Vector3Int)endNode);
            //IGraph<Node> g = (IGraph < Node >)graph;
            List<Node> OpenList = new List<Node>();
            List<Node> ClosedList = new List<Node>();
            Node current = start;

            // add start node to Open List
            OpenList.Add(start);

            while (OpenList.Count != 0 && !ClosedList.Exists(x => x.Position == end.Position))
            {
                current = OpenList[0];
                OpenList.Remove(current);
                ClosedList.Add(current);

                foreach (Node n in graph.Neighbors(current))
                {
                        if (!ClosedList.Contains(n))
                        {
                            if (!OpenList.Contains(n))
                            {
                                n.Parent = current;
                                n.DistanceToTarget = Math.Abs(n.Position.x - end.Position.x) + Math.Abs(n.Position.y - end.Position.y);
                                n.Cost = n.Weight + n.Parent.Cost;
                                OpenList.Add(n);
                                OpenList = OpenList.OrderBy(node => node.F).ToList<Node>();
                            }
                        }
                }
            }

            // construct path, if end was not closed return null
            if (!ClosedList.Exists(x => x.Position == end.Position))
            {
            Debug.Log("can't find shortest path, line 48");
            return;
            }

            // if all good, return path
            Node temp = ClosedList[ClosedList.IndexOf(current)];
             if (temp == null)
             {
                Debug.Log("can't find shortest path, line 56");
                return; 
             }

            do
            {
              outputPath.Add(temp.Position);
            } while (temp != start && temp != null);
       
            outputPath.Reverse();
          
    }

    public static List<object> GetPath<NodeType>(IGraph<object> graph, NodeType startNode, NodeType endNode, int maxiterations = 1000)
    {
        List<object> path = new List<object>();
        FindPath(graph, startNode, endNode, path, maxiterations);
        return path;
    }
   
}

*/