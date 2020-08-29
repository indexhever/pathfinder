using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection
{
    public struct Node
    {

    }

    public float Cost
    {
        get
        {
            return 0;
        }
    }

    public Node FromNode
    {
        get
        {
            return new Node();
        }
    }

    public Node ToNode
    {
        get
        {
            return new Node();
        }
    }
}
