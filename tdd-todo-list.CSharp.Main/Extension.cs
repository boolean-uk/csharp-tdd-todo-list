using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tdd_todo_list.CSharp.Main.TodoListExtension;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private static int lastID = 0;
        public Dictionary<int, Task> Tasks { get; set; }

        public TodoListExtension()
        {
            Tasks = new Dictionary<int, Task>();
        }

        public class Task
        {
            public string Description { get; set; }
            public bool IsComplete { get; set; }
            public DateTime Creation { get; private set; }

            public Task(string description)
            {
                Description = description;
                IsComplete = false;
                Creation = DateTime.Now;
            }
        }

        private int GetID()
        {
            lastID++;
            return lastID;
        }

        private void DisplayTask(Task task)
        {
            string completed = task.IsComplete ? "Completed" : "Uncompleted";
            Console.WriteLine($"{task.Description} ({completed})");
        }

        private void DisplayTask(int id)
        {
            KeyValuePair<int, Task> result = Tasks
                .Where(task => task.Key.Equals(id))
                .FirstOrDefault();

            if (!result.Equals(default(KeyValuePair<int, Task>)))
            {
                DisplayTask(result.Value);
            }
            else
            {
                Console.Write("Not found");
            }
        }

        public void Display()
        {
            foreach (KeyValuePair<int, Task> kvp in Tasks)
            {
                Task task = kvp.Value;
                string completed = task.IsComplete ? "Completed" : "Uncompleted";
                Console.WriteLine($"{task.Description} ({completed}) ({task.Creation})");
            }
        }

        public void Search(int id)
        {
            if (Tasks.ContainsKey(id))
                DisplayTask(id);
            else
                Console.WriteLine("Not found");
        }

        public int Add(string description)
        {
            Task task = new Task(description);

            int id = GetID();

            Tasks.Add(id, task);

            return id;
        }

        public void Rename(int id, string Description)
        {
            if (Tasks.ContainsKey(id))
                Tasks[id].Description = Description;
            else
                Console.WriteLine("Not found");
        }

        public void Complete(int id)
        {
            if (Tasks.ContainsKey(id))
                Tasks[id].IsComplete = true;
            else
                Console.WriteLine("Not found");
        }
    }
}
