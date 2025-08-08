using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TodoTask> Tasks { get; set; } = new List<TodoTask>();

        public List<TodoTask> CompletedTasks { get { return Tasks.Where(x => x.IsComplete == true).ToList(); } }

        public List<TodoTask> InCompletedTasks { get { return Tasks.Where(x => x.IsComplete == false).ToList(); } }

        public List<TodoTask> TasksByPriority { get { return Tasks.OrderByDescending(task => task.Priority).ToList(); } }

        public string FindTaskByName(string name)
        {
            var todoTask = Tasks.FirstOrDefault(t => t.Name == name);
            if (todoTask != null)
            {
                return todoTask.Name;
            }
            else
            {
                return "Task not found";
            }
        }
    }
}
