using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUkolu201123
{
    internal class SubTask : ITaskComponent
    {
        List<ITaskComponent> taskComponents = new List<ITaskComponent>();
        public string name { get; set; }

        public SubTask(string name)
        {
            this.name = name;
        }

        public void Add(ITaskComponent taskComponent)
        {
            taskComponents.Add(taskComponent);
        }

        public void Remove(ITaskComponent taskComponent)
        {
            taskComponents.Remove(taskComponent);
        }
    }
}
