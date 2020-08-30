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
        public Connection[] GeneratePath(Grapth grapth, Connection.Node start, Connection.Node end)
        {
            NodeRecord startRecord = InitializeRecordToStartNode(start);

            // Initialize open and closed lists
            List<NodeRecord> open = new List<NodeRecord>();
            open.Add(startRecord);
            List<NodeRecord> closed = new List<NodeRecord>();

            // TODO: implement the rest of code
            // Iterate through processing each node
            //while(open.Count > 0)
            //{

            //}

            return new Connection[0];
        }

        private NodeRecord InitializeRecordToStartNode(Connection.Node start)
        {
            return new NodeRecord(start, null, 0);
        }
    }
}