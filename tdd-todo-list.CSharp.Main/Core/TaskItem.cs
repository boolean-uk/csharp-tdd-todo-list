using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; } = false;

        public TaskItem(string name)
        {
            Name = name;
        }
    }
}
