namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TodoTask> tasks;

        public TodoList()
        {
            tasks = new();
        }
        public void AddTask(TodoTask task)
        {
            tasks.Add(task);
        }

        public void ClearTodo()
        {
            tasks.Clear();
        }

        public List<TodoTask> GetCompleteTasks()
        {
            return tasks.Where(x => x.IsComplete).ToList();
        }

        public List<TodoTask> GetInCompleteTasks()
        {
            return tasks.Where(x => !x.IsComplete).ToList();
        }

        public List<TodoTask> GetTasks()
        {
            return tasks;
        }

        public List<TodoTask> GetTasksAscending()
        {
            return tasks.OrderBy(x => x.Name).ToList();
        }

        public List<TodoTask> GetTasksDescending()
        {
            return tasks.OrderByDescending(x => x.Name).ToList();
        }

        public bool SearchForTask(TodoTask task)
        {
            return tasks.Contains(task);
        }

        public bool ToggleTaskStatus(TodoTask task)
        {
            if (tasks.Contains(task))
            {
                task.IsComplete = !task.IsComplete;
                return true;
            }
            return false;
        }
    }
}
