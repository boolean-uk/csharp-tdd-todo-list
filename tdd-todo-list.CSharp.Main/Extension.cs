

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public List<TodoTask> tasks { get; set; }
        public TodoListExtension()
        {
            tasks = new();
        }

        public void addTask(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public TodoTask getTaskById(string taskId)
        {
            throw new NotImplementedException();
        }

        public bool updateTaskName(string taskId, string v)
        {
            throw new NotImplementedException();
        }

        public bool changeTaskStatus(string taskId)
        {
            throw new NotImplementedException();
        }

        public DateTime getCreationTime(string taskId)
        {
            throw new NotImplementedException();
        }
    }
}
