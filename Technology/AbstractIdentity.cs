using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractIdentity
    {
        private static int nextComponentId = 1;
        private readonly int ComponentID;

        public AbstractIdentity()
        {
            ComponentID = nextComponentId;
            nextComponentId++;
        }

        public int componentID 
        {
            get { return ComponentID; } 
        }
    }
}
