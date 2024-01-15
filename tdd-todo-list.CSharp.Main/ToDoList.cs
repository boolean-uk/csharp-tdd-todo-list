



namespace tdd_todo_list.CSharp.Main
{
    public class TodoList()
    {
        private readonly List<ToDoTask> _tasks = new();

        public void Add(ToDoTask task)
        {
            _tasks.Add(task);
        }

        public List<ToDoTask> GetCompleteTasks()
        {
            return _tasks.Where(t => t.Status == Status.Complete).ToList();
        }

        public List<ToDoTask> GetIncompleteTasks()
        {
            return _tasks.Where(t => t.Status == Status.Incomplete).ToList();
        }

        public List<ToDoTask> View(Sorting sort)
        {
            switch (sort)
            {
                case Sorting.Ascending:
                    _tasks.Sort((a, b) => a.Name.CompareTo(b.Name));
                    break;
                case Sorting.Descending:
                    _tasks.Sort((a, b) => b.Name.CompareTo(a.Name));
                    break;
            }
            foreach (ToDoTask task in _tasks)
            {
                Console.WriteLine(task.Name);
            }
            return _tasks;
        }

        public ToDoTask? Search(string id)
        {
            ToDoTask task = _tasks.FirstOrDefault(t => t.Id == id)
                ?? throw new Exception($"No ToDoTask with id: {id}");
            return task;
        }

        public void Remove(string id)
        {
            ToDoTask task = Search(id)
                ?? throw new Exception($"No ToDoTask with id: {id}");
            _tasks.Remove(task);
        }

        public void Remove(int index)
        {
            _tasks.RemoveAt(index);
        }

        public int Count { get { return _tasks.Count; } }
    }
}
