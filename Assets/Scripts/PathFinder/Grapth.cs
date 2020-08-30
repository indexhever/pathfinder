using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathFinder
{
    public class Grapth
    {
        public Grapth(Connection[] connections)
        {
            this.Conections = connections;
        }
        public Connection[] Conections { get; private set; }
    }
}