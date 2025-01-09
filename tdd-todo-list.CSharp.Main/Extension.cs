using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private int _runningId = 0;
        private Dictionary<int, TodoTask> _todoList = [];
        private Dictionary<string, int> _taskLookupTable = [];
        public int Add(string taskContent)
        {
            TodoTask task = new TodoTask(_runningId, taskContent);
            _todoList.Add(task.Id, task);
            _taskLookupTable.Add(taskContent, task.Id);
            _runningId++;
            return task.Id;
        }

        public TodoTask Get(int id)
        {
            ValidateId(id);
            return _todoList[id];
        }

        public TodoTask Get(string name)
        {
            ValidateName(name);
            int id = GetIdFromName(name);
            return Get(id);
        }

        public void UpdateName(int id, string name)
        {
            ValidateId(id);
            string key = _todoList[id].Name;
            _todoList[id].Name = name;
            _taskLookupTable.Remove(key);
            _taskLookupTable.Add(name, id);
        }

        public bool ToggleStatus(int id)
        {
            ValidateId(id);
            _todoList[id].Completed = !_todoList[id].Completed;
            return _todoList[id].Completed;
        }

        public bool ToggleStatus(string name)
        {
            ValidateName(name);
            int id = GetIdFromName(name);
            return ToggleStatus(id);
        }

        public void RemoveTask(int id)
        {
            ValidateId(id);
            TodoTask task = _todoList[id];
            _todoList.Remove(id);
            _taskLookupTable.Remove(task.Name);
        }
        public void RemoveTask(string name)
        {
            ValidateName(name);
            RemoveTask(GetIdFromName(name));
        }

        public DateTime GetTaskCreatedDate(int id)
        {
            ValidateId(id);
            return _todoList[id].Created;
        }
        public List<TodoTask> TaskList => _todoList.Values.ToList();

        public List<TodoTask> GetSortedTaskList()
        {
            return TaskList.OrderBy(x => x.Name).ToList();
        }

        public List<TodoTask> GetSortedTaskList(bool asc)
        {
            return asc ? GetSortedTaskList() : TaskList.OrderBy(x => x.Name).Reverse().ToList();
        }

        public bool ContainsId(int id) { return  _todoList.ContainsKey(id); }
        public bool ContainsName(string name) { return  _taskLookupTable.ContainsKey(name); }

        private void ValidateId(int id)
        {
            if (!_todoList.ContainsKey(id)) throw new ArgumentException("The provided ID does not exist!");
        }

        private void ValidateName(string name)
        {
            if (!ContainsName(name)) throw new ArgumentException("The provided name does not exist");
        }

        private int GetIdFromName(string name)
        {
            return _taskLookupTable[name];
        }
    }
}
