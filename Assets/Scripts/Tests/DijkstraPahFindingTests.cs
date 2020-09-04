using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PathFinder;
using System;

namespace Tests
{
    public class DijkstraPahFindingTests
    {
        [Test]
        public void PathIsNotNullAfterGeneration()
        {
            Connection.Node[] nodes = CreateNodes();
            Connection[] connections = CreateConnections(nodes);
            Graph grapth = CreateGrapth(connections);
            DijkstraPathFinder dijkstraPathFinder = CreatePathFinder();
            Connection.Node start = nodes[0];
            Connection.Node end = nodes[6];

            Connection[] path = dijkstraPathFinder.GeneratePath(grapth, start, end);

            Assert.IsNotNull(path);
        }

        [Test]
        public void FindCorrectPath()
        {
            Connection.Node[] nodes = CreateNodes();
            Connection[] connections = CreateConnections(nodes);
            Connection[] expectedPath = new Connection[]
            {
                connections[0], // Connection I
                connections[4], // Connection V
                connections[6], // Connection VII
            };
            Graph grapth = CreateGrapth(connections);
            DijkstraPathFinder dijkstraPathFinder = CreatePathFinder();
            Connection.Node start = nodes[0];
            Connection.Node end = nodes[6];

            Connection[] foundPath = dijkstraPathFinder.GeneratePath(grapth, start, end);

            Assert.AreEqual(expectedPath.Length, foundPath.Length);
            AssertExpectedPathIsEqualToFoundPath(expectedPath, foundPath);
        }

        [Test]
        public void NodeAreEqualToAnotherOne()
        {
            Connection.Node nodeA = new Connection.Node("A");
            Connection.Node nodeB = new Connection.Node("B");
            Connection.Node secondNode = nodeA;

            Assert.IsTrue(nodeA.Equals(secondNode));
            Assert.IsFalse(nodeA.Equals(nodeB));
            Assert.AreEqual(nodeA.Name, secondNode.Name);
            Assert.AreEqual(nodeA.Name, "A");
        }

        private static void AssertExpectedPathIsEqualToFoundPath(Connection[] expectedPath, Connection[] foundPath)
        {
            for (int i = 0; i < foundPath.Length; i++)
            {
                Assert.AreEqual(expectedPath[i], foundPath[i]);
            }
        }

        private Connection.Node[] CreateNodes()
        {
            return new Connection.Node[] 
            { 
                CreateNode("A"),
                CreateNode("B"),
                CreateNode("C"),
                CreateNode("D"),
                CreateNode("E"),
                CreateNode("F"),
                CreateNode("G")
            };
        }

        private Connection[] CreateConnections(Connection.Node[] nodes)
        {
            return new Connection[]
            {
                new Connection( // Connection I
                    1.3f,
                    nodes[0], // Node A
                    nodes[1]  // Node B
                ),
                new Connection( // Connection II
                    1.6f,
                    nodes[0], // Node A
                    nodes[2]  // Node C
                ),
                new Connection( // Connection III
                    3.3f,
                    nodes[0], // Node A
                    nodes[3]  // Node D
                ),
                new Connection( // Connection IV
                    1.5f,
                    nodes[1], // Node B
                    nodes[4]  // Node E
                ),
                new Connection( // Connection V
                    1.9f,
                    nodes[1], // Node B
                    nodes[5]  // Node F
                ),
                new Connection( // Connection VI
                    1.3f,
                    nodes[2], // Node C
                    nodes[3]  // Node D
                ),
                new Connection( // Connection VII
                    1.4f,
                    nodes[5], // Node F
                    nodes[6]  // Node G
                )
            };
        }

        private Graph CreateGrapth(Connection[] connections)
        {
            return new Graph(connections);
        }

        private Connection.Node CreateNode(string name)
        {
            return new Connection.Node(name);
        }

        private DijkstraPathFinder CreatePathFinder()
        {
            return new DijkstraPathFinder();
        }
    }
}
