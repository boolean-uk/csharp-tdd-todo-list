using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(string name)
        {
            tasks.Add(new Task(nextId++, name));
        }

        public string FindTaskByID(int id)
        {
            var task = tasks.Find(x => x.Id == id);

            return task == null ? $"no task with id: {id}" : $"{task.Name} - {task.IsComplete}";
        }
    }
}
