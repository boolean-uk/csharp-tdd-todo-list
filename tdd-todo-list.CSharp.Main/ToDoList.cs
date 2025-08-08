using Newtonsoft.Json;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public enum Priority { low, medium, high }

    public class Task
    {
        #region Privates
        private string _taskText;
        private Priority _priority; //standard to low?
        private string _category;
        private DateTime _startTime;
        private Nullable<DateTime> _completeTime = null;
        private bool _completed = false;
        #endregion
        public Guid _id { get; } = Guid.NewGuid();

        public Task(string task, Priority priority = Priority.low, string category = "")
        {
            _startTime = DateTime.Now;
            _taskText = task;
            _priority = priority;
            _category = category;
        }

        public void CompleteTask()
        {
            _completed = true;
            _completeTime = DateTime.Now;
        }

        public void SetText(string NewText)
        {
            _taskText = NewText;
        }

        public void AdjustCompleteTime(DateTime NewTime)
        {
            _completeTime = NewTime;
        }

        public void UnCompleteTask() { _completed = false; _completeTime = null; }
        public bool IsCompleted() { return _completed; }
        public string GetTaskText() { return _taskText; }
        public Priority GetPriority() { return _priority; }
        public string GetCategory() { return _category; }
        public DateTime GetStartTime() { return _startTime; }
        public DateTime? GetCompletionTime() { return _completeTime; }

    }



    public class TodoList
    {
        private Dictionary<Guid, Task> _tasks = new Dictionary<Guid, Task>();


        public Guid Add(string taskText, Priority priority = Priority.low, string category = "")
        {
            Task task = new Task(taskText, priority, category);
            Guid id = task._id;
            _tasks.Add(id, task);
            return id;
        }

        public void ChangeTaskCompletion(Guid id)
        {
            if (_tasks[id].IsCompleted()) _tasks[id].UnCompleteTask();
            else _tasks[id].CompleteTask();
        }

        public void ChangeTaskCompletion(string taskText)
        {
            List<Task> tasks = SearchTaskText(taskText);
            if (tasks.Count >= 1) ChangeTaskCompletion(tasks[0]._id);
        }

        public void SetCustomTaskCompletion(Guid id, DateTime completeTime)
        {
            if (_tasks[id].IsCompleted()) _tasks[id].AdjustCompleteTime(completeTime);
            else
            {
                _tasks[id].CompleteTask();
                _tasks[id].AdjustCompleteTime(completeTime);
            }
        }

        public void ChangeTaskName(Guid id, string NewText)
        {
            Task task = GetTaskById(id);
            task.SetText(NewText);
        }

        public List<Task> GetList(Nullable<bool> status = null, bool descending = false, bool alphabetically = false)
        {
            if (status != null)
            {
                List<Task> completedTasks = new List<Task>();
                foreach (var task in _tasks)
                {
                    if (task.Value.IsCompleted() == status) completedTasks.Add(task.Value);
                }
                return completedTasks;

            }
            else
            {
                if (alphabetically)
                    return !descending
                        ? _tasks.Values.OrderBy(t => t.GetTaskText()).ToList()
                        : _tasks.Values.OrderByDescending(t => t.GetTaskText()).ToList();
                else
                {
                    return _tasks.Values.ToList();
                }
            }

        }

        public Task GetLongestCompletionTask()
        {
            return _tasks.Values.Where(task => task.IsCompleted()).MaxBy(task => (task.GetCompletionTime() - task.GetStartTime()));
        }

        public Task GetShortestCompletionTask()
        {
            return _tasks.Values.Where(task => task.IsCompleted()).MinBy(task => (task.GetCompletionTime() - task.GetStartTime()));
        }

        /// <summary>
        /// Method <c>GetPriorityList</c> orders all tasks by their priority.
        /// High = 2, medium = 1, low = 0, so high should appear highest.
        /// </summary>
        public List<Task> GetPriorityList() { 
            return _tasks.Values.OrderByDescending(task => task.GetPriority()).ToList();
        }

        public Task? GetTaskById(Guid id)
        {
            if (!_tasks.ContainsKey(id)) return null;
            return _tasks[id];
        }

        public bool GetTaskCompletion(Guid id)
        {
            return _tasks[id].IsCompleted();
        }


        public bool RemoveTask(Guid id)
        {
            return _tasks.Remove(id);
        }

        public List<Task> SearchTaskText(string text)
        {
            var Values = _tasks.Values.ToList();
            var result = Values.Where(task => task.GetTaskText().Contains(text)).ToList();
            return result;
        }

        public List<Task> Get5DayCompletionList()
        {
            return _tasks.Values.Where(task => (task.IsCompleted() && (task.GetCompletionTime() - task.GetStartTime()) >= new TimeSpan(5, 0, 0, 0))).ToList();
        }

        public List<Task> GetCategoryList()
        {
            return _tasks.Values.OrderBy(task => task.GetCategory()).ToList();
        }
    }
}