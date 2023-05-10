using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace tdd_todo_list.CSharp.Main
{
    public class ExtendedTodoList
    {
        public Dictionary<Guid, Task> tasks = new Dictionary<Guid, Task>();

        public void AddTask(string taskName)
        {
            var task = new Task(taskName);
            tasks.Add(task.Id, task);
        }

        public int Count { get { return tasks.Count; } }

        public Task GetTaskById(Guid id)
        {
            tasks.TryGetValue(id, out Task task);
            return task;
        }

        public void UpdateTaskName(Guid id, string newName)
        {
            if (tasks.ContainsKey(id))
            {
                tasks[id].Name = newName;
            }
        }

        public void ChangeTaskStatus(Guid id, bool isComplete)
        {
            if (!tasks.ContainsKey(id))
            {
                tasks[id].IsComplete = isComplete;
            }
        }

        public class Task
        {
            public Guid Id { get; private set; }
            public string Name { get; set; }
            public bool IsComplete { get; set; }
            public DateTime Created { get; set; }

        public Task(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            IsComplete = false;
            Created = DateTime.Now;

        }
    }
}
}