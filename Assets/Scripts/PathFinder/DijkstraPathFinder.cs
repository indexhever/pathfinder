using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathFinder
{
    public struct NodeRecord
    {
        public Connection.Node Node;
        public Connection Connection;
        public float CostSoFar;

        public NodeRecord(Connection.Node node, Connection connection, float costSoFar)
        {
            this.Node = node;
            this.Connection = connection;
            this.CostSoFar = costSoFar;
        }
    }
    public class DijkstraPathFinder
    {
        public Connection[] GeneratePath(Graph graph, Connection.Node start, Connection.Node end)
        {
            NodeRecord startRecord = InitializeRecordToStartNode(start);
            NodeRecord currentRecord;

            // Initialize open and closed lists
            PathFindingList open = CreatePathFindingList();
            open.Add(startRecord);
            PathFindingList closed = CreatePathFindingList();

            // TODO: implement the rest of code
            // Iterate through processing each node
            while (open.Count > 0)
            {
                currentRecord = open.SmallestElement;

                // If it is the goal node, then terminate
                if (currentRecord.Node.Equals(end))
                    break;

                Connection[] connections = graph.GetConectionsFromNode(currentRecord);
                foreach(Connection connection in connections)
                {
                    Connection.Node endNode = connection.ToNode;
                    float endNodeCost = currentRecord.CostSoFar + connection.Cost;

                    // skip if node is closed
                    if (closed.Contains(endNode))
                        continue;
                    //..or if it is open and we’ve found a worse
                    else if (open.Contains(endNode))
                    {

                    }

                }
            }

            return new Connection[0];
        }

        // TODO: make it possible to change the type of list by some UI interface
        private PathFindingList CreatePathFindingList()
        {
            return new PathFindingBasicList();
        }

        private NodeRecord InitializeRecordToStartNode(Connection.Node start)
        {
            return new NodeRecord(start, null, 0);
        }
    }
}