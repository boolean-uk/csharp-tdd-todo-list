using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public record ETask
    {
        public required string Title { get; set; }
        public required DateTime CreatedDate { get; init; }
        public required bool Completed { get; set; }
    };

    public class TodoListExtension
    {
        private Dictionary<String, ETask> _tasks = new Dictionary<String, ETask>();

        public ETask? Get(string id)
        {
            if (this._tasks.ContainsKey(id))
            {
                return this._tasks.GetValueOrDefault(id);
            }
            return null;
        }

        public bool Add(string id, ETask task)
        {
            return this._tasks.TryAdd(id, task);
        }

        public void ChangeName(string id, string newTitle)
        {
            ETask? task = this.Get(id);
            if (task != null)
            {
                task.Title = newTitle;
            }
        }

        public void ToggleCompleted(string id)
        {
            ETask? task = this.Get(id);
            if (task != null)
            {
                task.Completed = !task.Completed;
            }
        }

        public DateTime? GetDate(string id)
        {
            ETask? task = this.Get(id);
            if (task != null)
            {
                return task.CreatedDate;
            }
            return null;
        }
    }
}
