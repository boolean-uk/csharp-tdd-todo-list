using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<Task> todolist = new List<Task>();


        public string Add(string Task)
        {
            Task task = new Task(Task);
            todolist.Add(task);
            return task.ToString();
        }

        public List<string> ViewTasks()
        {
            return todolist.Select(task => task.ToString()).ToList();
        }
    }
}
