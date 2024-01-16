using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> Tasks {  get; set; }

        public TodoList()
        {
            Tasks = new Dictionary<string, bool>();
        }

        private void DisplayTask(KeyValuePair<string, bool> task)
        {
            string completed = task.Value ? "Completed" : "Uncompleted";
            Console.WriteLine($"{task.Key} ({completed})");
        }

        private void DisplayTask(string description)
        {
            KeyValuePair<string, bool> result = Tasks
                .Where(task => task.Key.Equals(description))
                .FirstOrDefault();

            if (!result.Equals(default(KeyValuePair<string, bool>)))
            {
                DisplayTask(result);
            }
            else
            {
                Console.Write("Not found");
            }
        }

        public void Display()
        {
            foreach (KeyValuePair<string, bool> task in Tasks)
            {
                DisplayTask(task);
            }
        }

        public void Display(bool ascending)
        {
            foreach (KeyValuePair<string, bool> task in Tasks)
            {
                if (ascending == task.Value)
                {
                    Console.WriteLine(task.Key);
                }
            }
        }

        public void DisplayAscending()
        {
            var orderedTasks = Tasks.OrderBy(task => task.Key);

            foreach (KeyValuePair<string, bool> task in orderedTasks)
            {
                string completed = task.Value ? "Completed" : "Uncompleted";
                Console.WriteLine($"{task.Key} ({completed})");
            }
        }

        public void DisplayAscending(bool completed)
        {
            var orderedTasks = Tasks.OrderBy(task => task.Key);

            foreach (KeyValuePair<string, bool> task in orderedTasks)
            {
                if (completed == task.Value)
                {
                    Console.WriteLine(task.Key);
                }
            }
        }

        public void DisplayDescending()
        {
            var orderedTasks = Tasks.OrderByDescending(task => task.Key);

            foreach (KeyValuePair<string, bool> task in orderedTasks)
            {
                string completed = task.Value ? "Completed" : "Uncompleted";
                Console.WriteLine($"{task.Key} ({completed})");
            }
        }

        public void DisplayDescending(bool completed)
        {
            var orderedTasks = Tasks.OrderByDescending(task => task.Key);

            foreach (KeyValuePair<string, bool> task in orderedTasks)
            {
                if (completed == task.Value)
                {
                    Console.WriteLine(task.Key);
                }
            }
        }

        public void Add(string description)
        {
            Tasks.Add(description, false);
        }

        public void Complete(string description)
        {
            if (Tasks.ContainsKey(description))
                Tasks[description] = true;
            else
                Console.WriteLine("Not found");
        }

        public void Search(string description)
        {
            if (Tasks.ContainsKey(description))
                DisplayTask(description);
            else
                Console.WriteLine("Not found");
        }

        public void Remove(string description)
        {
            if (Tasks.ContainsKey(description))
                Tasks.Remove(description);
            else
                Console.WriteLine("Not found");
        }
    }
}
