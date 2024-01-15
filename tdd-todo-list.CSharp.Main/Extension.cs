

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public Dictionary<string, TodoTask> tasks { get; set; }
        public TodoListExtension()
        {
            tasks = new();
        }

        public void AddTask(TodoTask task)
        {
            tasks.Add(task.Id, task);
        }

        public TodoTask? GetTaskById(string taskId)
        {
            return tasks.TryGetValue(taskId, out TodoTask? value) ? value : null;
        }

        public bool UpdateTaskName(string taskId, string v)
        {
            if (tasks.TryGetValue(taskId, out _))
            {
                tasks[taskId].Name = v;
                return true;
            }
            else return false;
        }

        public bool ChangeTaskStatus(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TodoTask? _))
            {
                tasks[taskId].IsComplete = !tasks[taskId].IsComplete;
                return true;
            }
            else return false;
        }

        public DateTime? GetCreationTime(string taskId)
        {
            return tasks.TryGetValue(taskId, out TodoTask? value) ? value.creationTime : null;
        }
    }
}
