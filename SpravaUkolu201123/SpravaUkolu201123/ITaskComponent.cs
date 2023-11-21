using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUkolu201123
{
    internal interface ITaskComponent
    {
        public string name { get; set; }
        
        void Add(ITaskComponent taskComponent);
        void Remove(ITaskComponent taskComponent);
    }
}
