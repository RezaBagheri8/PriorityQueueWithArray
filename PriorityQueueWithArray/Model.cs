using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithArray
{
    public class Model
    {
        public int value;
        public int priority;

        public Model(int theValue, int thePriority)
        {
            value = theValue;
            priority = thePriority;   
        }
    }
}
