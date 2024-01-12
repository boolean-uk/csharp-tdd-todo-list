namespace tdd_todo_list.CSharp.Main
{
    using System.Collections.Generic;
    using System.Linq;

    namespace tdd_todo_list.CSharp.Main
    {
        public class Task
        {
            public string? Name { get; set; }
            public bool IsComplete { get; set; }
        }

        public class TodoList
        {
            private List<Task> tasks;

            public TodoList()
            {
                tasks = new List<Task>();
            }

            public void AddTask(string name)
            {
                tasks.Add(new Task { Name = name , IsComplete = false });
            }

            public List<Task> GetAllTasks()
            {
                return tasks;
            }

            public void ChangeTaskStatus(string name , bool isComplete)
            {
                var task = tasks.Find(t => t.Name == name);
                if(task != null)
                {
                    task.IsComplete = isComplete;
                }
            }

            public List<Task> GetCompleteTasks()
            {
                return tasks.Where(t => t.IsComplete).ToList();
            }

            public List<Task> GetIncompleteTasks()
            {
                return tasks.Where(t => !t.IsComplete).ToList();
            }

            public string SearchTask(string name)
            {
                var task = tasks.Find(t => t.Name == name);
                return task != null ? $"Task found: {task.Name}" : "Task not found";
            }

            public void RemoveTask(string name)
            {
                var task = tasks.Find(t => t.Name == name);
                if(task != null)
                {
                    tasks.Remove(task);
                }
            }

            public List<Task> GetTasksOrderedAscending()
            {
                return tasks.OrderBy(t => t.Name).ToList();
            }

            public List<Task> GetTasksOrderedDescending()
            {
                return tasks.OrderByDescending(t => t.Name).ToList();
            }
        }
    }

}
