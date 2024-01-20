namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
        public int Id { get; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; }

        // Construct that gets called when creating a Todo
        public Todo(string taskDesc, int taskId)
        {
            this.Description = taskDesc;
            this.Id = taskId;
            this.Done = false;
            this.CreatedAt = DateTime.Now;
        }
    }
    public class TodoList
    {
        private int _lastId = 0;
        public List<Todo> tasks = new List<Todo>();


        public void Add(string taskDesc)
        {
            _lastId++;
            Todo todo = new Todo(taskDesc, _lastId);
            tasks.Add(todo);
        }

        public List<Todo> Tasks()
        {
            return tasks;
        }

        public void ChangeStatus(int id)
        {
            foreach (Todo todo in tasks)
            {
                if (todo.Id == id)
                {
                    if (todo.Done == false)
                    {
                        todo.Done = true;
                    }
                    else
                    {
                        todo.Done = false;
                    }
                    break;
                }
            }
        }

        public List<Todo> CompletedTasks()
        {
            List<Todo> completedTasks = new List<Todo>();
            foreach (Todo todo in tasks)
            {
                if (todo.Done == true)
                {
                    completedTasks.Add(todo);
                }
            }
            return completedTasks;
        }

        public List<Todo> IncompleteTasks()
        {
            List<Todo> incompleteTasks = new List<Todo>();

            foreach (Todo todo in tasks)
            {
                if (todo.Done == false)
                {
                    incompleteTasks.Add(todo);
                }
            }

            return incompleteTasks;
        }

        public string SearchTask(int id)
        {
            foreach (Todo todo in tasks)
            {
                if (todo.Id == id)
                {
                    return "";
                }
            }
            return $"Id:{id} was not found";
        }

        public void Remove(int id)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Id == id)
                {
                    tasks.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Todo> TasksAcending()
        {
            return tasks.OrderBy(t => t.Description).ToList();
        }

        public List<Todo> TasksDecending()
        {
            return tasks.OrderByDescending(t => t.Description).ToList();
        }
    }
}