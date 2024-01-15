namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TodoTask> tasks;

        public TodoList()
        {
            tasks = new();
        }
        public void addTask(TodoTask task)
        {
            tasks.Add(task);
        }

        public void clearTodo()
        {
            tasks.Clear();
        }

        public List<TodoTask> getCompleteTasks()
        {
            return tasks.Where(x => x.IsComplete).ToList();
        }

        public List<TodoTask> getInCompleteTasks()
        {
            return tasks.Where(x => !x.IsComplete).ToList();
        }

        public List<TodoTask> getTasks()
        {
            return tasks;
        }

        public List<TodoTask> getTasksAscending()
        {
            return tasks.OrderBy(x => x.Name).ToList();
        }

        public List<TodoTask> getTasksDescending()
        {
            return tasks.OrderByDescending(x => x.Name).ToList();
        }

        public bool searchForTask(TodoTask task)
        {
            return tasks.Contains(task);
        }

        public bool toggleTaskStatus(TodoTask task)
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
