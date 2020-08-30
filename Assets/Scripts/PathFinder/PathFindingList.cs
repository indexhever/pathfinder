using UnityEngine;
using System.Collections;

namespace PathFinder
{
    public interface PathFindingList
    {
        float Count { get; }
        NodeRecord SmallestElement { get; }

        void Add(NodeRecord newItem);
    }
}