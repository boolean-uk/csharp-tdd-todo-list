using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        private Dictionary<int, Task> _todoListExtension;
        public class Task
        {
            private bool _completed;
            private string _name;
            private DateTime _created;
            public bool IsCompleted
            {
                get { return _completed; }
                set { _completed = value; }
            }
            public string TaskName 
            { 
                get { return _name; } 
                set { _name  = value; }
            }

            public DateTime Created
            {
                get { return _created; }
            }

            public Task()
            {
                this._completed = false;
                this._name = string.Empty;
                this._created = DateTime.Now;
            }

            public Task(string taskDescription)
            {
                this._completed = false;
                this._name = taskDescription;
                this._created = DateTime.Now;

            }

            public Task(string taskDescription, bool completed)
            {
                this._completed = completed;
                this._name = taskDescription;
                this._created = DateTime.Now;
            }

            public Task(string taskDescription, bool completed, DateTime created)
            {
                this._completed = completed;
                this._name = taskDescription;
                this._created = created;
            }
        }

        public TodoListExtension()
        {
            this._todoListExtension = new Dictionary<int, Task>();
        }

        public TodoListExtension(Dictionary<int, Task> todoList)
        {
            _todoListExtension = todoList;
        }

        public int Count()
        {
            return this._todoListExtension.Count;
        }

        public void AddTask(int id, Task task)
        {
            if (this._todoListExtension.ContainsKey(id)) return;

            this._todoListExtension[id] = task;
        }

        public void RemoveTask(int Id)
        {
            this._todoListExtension.Remove(Id);
        }
        public object SearchTaskById(int id)
        {
            if (this._todoListExtension.TryGetValue(id, out Task? value))
            {
                return value;
            }
            else
            {
                return "Task not found";
            }
        }

        public void UpdateTaskName(int id, string name)
        {
            if (this._todoListExtension.TryGetValue(id, out Task? value))
            {
                value.TaskName = name;
            }
        }

        public void UpdateTaskStatus(int id, bool v)
        {
            if (this._todoListExtension.TryGetValue(id, out Task? value))
            {
                value.IsCompleted = v;
            }
        }
    }
}
