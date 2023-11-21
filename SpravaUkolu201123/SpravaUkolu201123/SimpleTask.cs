using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUkolu201123
{
    internal class SimpleTask : ITaskComponent
    {
        public List<ITaskComponent> taskComponents = new List<ITaskComponent>();
        public string name { get; set; }

        public SimpleTask(string name) {
            this.name = name;
        }

        public void Add(ITaskComponent taskComponent)
        {
            taskComponent.Add(taskComponent);
        }

        public void Remove(ITaskComponent taskComponent)
        {
            taskComponent.Remove(taskComponent);
        }
    }
}
