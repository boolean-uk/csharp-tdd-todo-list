namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        
        protected Dictionary<int, TodoTask> _tasks = new Dictionary<int, TodoTask>();
        protected int _id = 0;
        
        public int AddTask(string name)
        {
            _tasks.Add(_id, new TodoTask(name));
            return _id++;
        }
        
        public void RemoveTask(int id)
        {
            _tasks.Remove(id);
        }
        
        public TodoTask GetTask(string name)
        {
            return _tasks.FirstOrDefault(task => task.Value.GetName() == name).Value;
        }
        
        public Dictionary<int, TodoTask> GetTasks()
        {
            return _tasks;
        }
        
        public void SetStatus(string name, bool status)
        {
            GetTask(name).SetStatus(status);
        }
        
        public Dictionary<int, TodoTask> GetCompletedTasks()
        {
            Dictionary<int, TodoTask> completedTasks = _tasks
                .Where(task => task.Value.GetStatus())
                .ToDictionary(task => task.Key, task => task.Value);
            
            return completedTasks;
        }
        public Dictionary<int, TodoTask> GetIncompleteTasks()
        {
            Dictionary<int, TodoTask> incompleteTasks = _tasks
                .Where(task => !task.Value.GetStatus())
                .ToDictionary(task => task.Key, task => task.Value);
            
            return incompleteTasks;
        }
        
        public Dictionary<int, TodoTask> GetOrdered(bool ascending)
        {
            Dictionary<int, TodoTask> orderedTasks = new Dictionary<int, TodoTask>();
            int newId = 0;
            
            if (ascending)
            {
                orderedTasks = _tasks
                    .OrderBy(task => task.Value.GetName())
                    .ToDictionary(task => newId++, task => task.Value);
            }
            else
            {
                orderedTasks = _tasks
                    .OrderByDescending(task => task.Value.GetName())
                    .ToDictionary(task => newId++, task => task.Value);
            }
            
            return orderedTasks;
        }
    }
}
