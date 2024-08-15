using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public Dictionary<int, TaskItem> tasks = new Dictionary<int, TaskItem>();
        public int AddTask(string description)
        {
            int id = tasks.Count;
            tasks[id] = new TaskItem(description);

            return id;
        }

        public void ChangeStatus(int taskID)
        {
            tasks[taskID].IsCompleted = true;
        }

        public TaskItem FindTask(int taskID)
        {
            return tasks[taskID];
        }

        public string TaskTimeAndDate(int taskID)
        {
            return "";
        }

        public void UpdateTask(int taskID, string description)
        {
            tasks[taskID].Description = description;
        }
    }
}
