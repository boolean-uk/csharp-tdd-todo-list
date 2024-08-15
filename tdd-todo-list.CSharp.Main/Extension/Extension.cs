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

        public bool AddTask(string taskName, int id, string dateTime)
        {
            TaskItemExtension task = new TaskItemExtension(taskName, id, dateTime);
            Tasks.Add(task);
            return true;
        }

        public TaskItemExtension? GetTask(int id)
        {
            TaskItemExtension? taskItem = Tasks.Find(task => task.Id == id);
            return taskItem;
        }

        public bool UpdateTaskName(int id, String newName)
        {
            TaskItemExtension? task = GetTask(id);
            if (task == null)
                return false;

            task.Name = newName;
            return true;
        }

        public  bool UpdateTaskStatus(int id)
        {
            TaskItemExtension? task = GetTask(id);
            if (task == null)
                return false;

            if (task.IsComplete)
                task.IsComplete = false;
            else 
                task.IsComplete = true;

            return true;
        }
    }
}
