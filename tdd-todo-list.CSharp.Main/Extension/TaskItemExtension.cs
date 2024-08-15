using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public class TaskItemExtension
{
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsComplete { get; set; } = false;

        public TaskItemExtension(string name, int id)
        {
            Name = name;
            Id = id;
        }

    }
}
