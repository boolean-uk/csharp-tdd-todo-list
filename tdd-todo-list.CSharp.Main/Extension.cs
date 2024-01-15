using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private Dictionary<string, Task> _items = new Dictionary<string, Task>();
        private Dictionary<int, Task> _ids = new Dictionary<int, Task>();
        private int _idCount = 1;
        public Dictionary<string, Task> Items { get { return _items; }  }
        public Dictionary<int, Task> Ids { get { return _ids; } }


        public List<string> Tasks()
        {
            return _items.Keys.ToList();
        }

        public void Add(string task)
        {
            if (!_items.ContainsKey(task))
            {
                Task t = new Task(_idCount, task);
                _items.Add(task, t);
                _ids.Add(_idCount, t);
                _idCount++;
            }
        }

        public void Toggle(string task)
        {
            if (_items.ContainsKey(task))
            {
                Task t = _items[task];
                t.Completed = !t.Completed;
            }
        }

        public void Toggle(int id)
        {
            if (_ids.ContainsKey(id))
            {
                Task t = _ids[id];
                t.Completed = !t.Completed;
            }
        }

        public List<string> GetCompleted()
        {
            return _items.Keys.Where(task => _items[task].Completed).ToList();
        }

        public List<string> GetUncompleted()
        {
            return _items.Keys.Where(task => !_items[task].Completed).ToList();
        }

        public bool Search(string task)
        {
            return _items.ContainsKey(task);
        }

        public void Remove(string task)
        {
            if (_items.ContainsKey(task))
            {
                _items.Remove(task);
                int taskId = _ids.Where(t => t.Value.Name == task).First().Key;
                _ids.Remove(taskId);
            }
        }

        public List<string> AscendingList()
        {
            return _items.Keys.Order().ToList();
        }

        public List<string> DescendingList()
        {
            return _items.Keys.OrderByDescending(t => t).ToList();
        }

        public string Get(int id)
        {
            if (_ids.ContainsKey(id)) return _ids[id].Name; else return "";
        }

        public void Update(int id, string newName)
        {
            if (_ids.ContainsKey(id))
            {
                Task t = _ids[id];
                t.Name = newName;
            }
        }

        public List<string> Origins()
        {
            return _items.Values.Select(t => $"{t.Name} - {t.CreatedAt}").ToList();
        }
    }
}
