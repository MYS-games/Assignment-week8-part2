/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using UnityEngine;

public class Node
{
    // Change this depending on what the desired size is for each element in the grid
    public Node Parent;
    public Vector3Int Position;
    public float DistanceToTarget;
    public float Cost;
    public float Weight;
    
    public float F
    {
        get
        {
            if (DistanceToTarget != -1 && Cost != -1)
                return DistanceToTarget + Cost;
            else
                return -1;
        }
    }

    public Node(Vector3Int pos, float weight = 1)
    {
        Parent = null;
        Position = pos;
        DistanceToTarget = -1;
        Cost = 1;
        Weight = weight;
    }
}
*/