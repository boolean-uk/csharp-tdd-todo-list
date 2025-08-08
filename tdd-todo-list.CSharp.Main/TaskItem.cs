using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private string _description;
        private bool _isDone;
        private Priority _priority;

        public Guid Id { get; private set; } = Guid.NewGuid();

        public TaskItem(string description, Priority priority = Priority.Medium)
        {
            _description = description;
            _isDone = false;
            _priority = priority;
        }

        public string GetDescription() => _description;
        public bool GetStatus() => _isDone;
        public Priority GetPriority() => _priority;

        public void SetStatus() => _isDone = true;
        public void SetPriority(Priority priority) => _priority = priority;
    }
}