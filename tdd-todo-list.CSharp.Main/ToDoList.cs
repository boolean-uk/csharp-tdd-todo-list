using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        
         public bool AddTask (String taskName)
        {
            TaskItem task = new TaskItem(taskName);
            Tasks.Add(task);
            return true;
        }

        public List<TaskItem> GetCompleteTasks()
        {
            List<TaskItem> completeTasks = Tasks.FindAll(task => task.IsComplete == true);

            return completeTasks;
        }

        public List<TaskItem> GetIncompleteTasks()
        {
            List<TaskItem> incompleteTasks = Tasks.FindAll(task => task.IsComplete == false);

            return incompleteTasks;
        }

    }
}
