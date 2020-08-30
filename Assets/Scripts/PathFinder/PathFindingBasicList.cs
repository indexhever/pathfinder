using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PathFinder
{
    public class PathFindingBasicList : PathFindingList
    {
        private List<NodeRecord> recordList;

        public PathFindingBasicList()
        {
            recordList = new List<NodeRecord>();
        }

        public PathFindingBasicList(List<NodeRecord> recordList)
        {
            this.recordList = recordList;
        }

        public float Count => recordList.Count;

        public NodeRecord SmallestElement 
        {
            // if firstRecord.CostSoFar < secondRecord.CostSoFar, firstRecord is smaller, 
            // if firstRecord.CostSoFar > secondRecord.CostSoFar, first is greater
            // else, they are equal
            get
            {
                recordList.Sort(
                    (firstRecord, secondRecord)
                        =>
                        {
                            if (firstRecord.CostSoFar < secondRecord.CostSoFar)
                                return -1;
                            else if (firstRecord.CostSoFar > secondRecord.CostSoFar)
                                return 1;
                            else
                                return 0;
                        }
                );

                return recordList[0];
            }
        }

        public void Add(NodeRecord newItem)
        {
            recordList.Add(newItem);
        }
    }
}