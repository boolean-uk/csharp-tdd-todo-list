using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private Dictionary<int, Task> _todoList;
        public class Task
        {
            private bool _completed;
            private string _description;
            public bool IsCompleted 
            { 
                get { return _completed; }  
                set { _completed = value; }
            }
            public string Description { get { return _description; } }

            public Task() 
            {
                this._completed = false;
                this._description = string.Empty;
            }

            public Task(string taskDescription)
            { 
                this._completed = false;
                this._description = taskDescription; 
            }

            public Task(string taskDescription, bool completed)
            {
                this._completed = completed;
                this._description = taskDescription;
            }
        }

        public TodoList() 
        { 
            this._todoList = new Dictionary<int, Task>();
        }

        public TodoList(Dictionary<int, Task> todoList)
        {
            _todoList = todoList;
        }

        public int Count()
        { 
            return this._todoList.Count; 
        }

        //Todo: handle unique keys/existing keys, currently overrides when key exists.
        public void AddTask(int id, Task task)
        {
            if (this._todoList.ContainsKey(id)) return;

            this._todoList[id] = task;
        }

        public void RemoveTask(int Id)
        {
            this._todoList.Remove(Id);
        }

        public object SearchTaskById(int id)
        {
            if (this._todoList.TryGetValue(id, out Task? value))
            {
                return value;
            }
            else
            {
                return "Task not found";
            }
        }

        public void UpdateTaskStatus(int id, bool v)
        {
            if (this._todoList.TryGetValue(id, out Task? value))
            {
                value.IsCompleted = v;
            }
        }

        public TodoList OrderByAscending()
        {

            var newList = this._todoList.OrderBy(task => task.Value.Description).ToDictionary(x => x.Key, x => x.Value);
            return new TodoList(newList);
        }

        public TodoList OrderByDescending()
        {

            var newList = this._todoList.OrderByDescending(task => task.Value.Description).ToDictionary(x => x.Key, x => x.Value);
            return new TodoList(newList);
        }

        public TodoList GetCompletedTasks()
        {
            var newList = this._todoList.Where(task => task.Value.IsCompleted == true).ToDictionary(x => x.Key, x => x.Value);
            return new TodoList(newList);
        }

        public TodoList GetInCompletedTasks()
        {
            var newList = this._todoList.Where(task => task.Value.IsCompleted == false).ToDictionary(x => x.Key, x => x.Value);
            return new TodoList(newList);
        }

        public Task First()
        { 
            return _todoList.First().Value; 
        }

    }
}
