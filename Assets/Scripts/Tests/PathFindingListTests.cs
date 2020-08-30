using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PathFinder;

namespace Tests
{
    public class PathFindingListTests
    {
        [Test]
        public void WhenAddItemTheListSizeIncreases()
        {
            PathFindingList pathFindingList = CreatePathFindingList();
            NodeRecord newItem = CreateItem();

            pathFindingList.Add(newItem);

            Assert.AreEqual(1, pathFindingList.Count);
        }

        [Test]
        public void SmallestElementIsTheOneWithSmallestCost()
        {
            PathFindingList pathFindingList = CreatePathFindingList();
            NodeRecord expectedSmallestElement = CreateItem(1);
            NodeRecord otherElement1 = CreateItem(2);                       
            NodeRecord otherElement2 = CreateItem(3);
            pathFindingList.Add(otherElement1);
            pathFindingList.Add(expectedSmallestElement);
            pathFindingList.Add(otherElement2);

            NodeRecord retrievedElement = pathFindingList.SmallestElement;

            Assert.AreEqual(expectedSmallestElement, retrievedElement);
        }

        private NodeRecord CreateItem(int cost = 0)
        {
            return new NodeRecord(new Connection.Node(), null, cost);
        }

        private PathFindingList CreatePathFindingList()
        {
            return new PathFindingBasicList();
        }

        private PathFindingList CreatePathFindingList(List<NodeRecord> recordList)
        {
            return new PathFindingBasicList(recordList);
        }
    }
}
