using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Extension
{
    public class TodoListExtension
    {
        public List<TaskItemExtension> Tasks { get; set; } = new List<TaskItemExtension>();

        public bool AddTask(string taskName, int id)
        {
            TaskItemExtension task = new TaskItemExtension(taskName, id);
            Tasks.Add(task);
            return true;
        }

        public TaskItemExtension? GetTask(int id)
        {
            TaskItemExtension? taskItem = Tasks.Find(task => task.Id == id);
            return taskItem;
        }
    }
}
