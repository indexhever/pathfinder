using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathFinder
{
    public class Connection
    {
        public struct Node
        {
            public Node(string name)
            {
                Name = name;
            }

            public string Name { get; }
        }

        public Connection(float cost, Node fromNode, Node toNode)
        {
            Cost = cost;
            FromNode = fromNode;
            ToNode = toNode;
        }

        public float Cost { get; }

        public Node FromNode { get; }

        public Node ToNode { get; }
    }
}