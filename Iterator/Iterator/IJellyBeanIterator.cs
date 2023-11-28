using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        JellyBean CurrentBean { get; }
        bool IsDone { get; }
    }
}
