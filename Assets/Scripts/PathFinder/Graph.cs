using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PathFinder
{
    public class Graph
    {
        public Graph(Connection[] connections)
        {
            this.Conections = connections;
        }
        public Connection[] Conections { get; private set; }

        public Connection[] GetConectionsFromNode(NodeRecord currentNode)
        {
            return Conections
                        .ToList()
                        .FindAll((currentConnection) =>
                        {
                            return currentConnection.FromNode.Equals(currentNode.Node);
                        })
                        .ToArray();
        }
    }
}