using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TaskItem> MyList { get; set; } = new List<TaskItem>();

        public List<TaskItem> CompletedTasks { get { return MyList.Where(x => x.IsCompleted == true).ToList(); } }
        public List<TaskItem> IncompletedTasks { get { return MyList.Where(x => x.IsCompleted == false).ToList(); } }

        public List<TaskItem> TasksSortedAscending { get { return MyList.OrderBy(x => x.Name).ToList(); } }
        public List<TaskItem> TasksSortedDescending { get { return MyList.OrderByDescending(x => x.Name).ToList(); } }
        public List<TaskItem> TasksSortedByPriority { get { return MyList.OrderBy(x => x.Priority).ToList(); } }

        public string Search(TodoList todolist, string name)
        {
            if(todolist.MyList.Any(t => t.Name == name))
            {
                return name;
            }
            else
            {
                return "Task not found";
            }
        }
    }
}
