using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }
        public int Count { get { return tasks.Count; } }

        public string GetTask(int index) { return tasks[index]; }

        public List<string> GetAllTasks() 
        {
            return tasks;
        }

    }

}
