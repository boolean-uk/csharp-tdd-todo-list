using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _items = new Dictionary<string, bool>();
        public Dictionary<string, bool> Items { get { return _items; } }
        

        public List<string> Tasks()
        {
            return _items.Keys.ToList();
        }

        public void Add(string task)
        {
           if (!_items.ContainsKey(task))
            {
                _items.Add(task, false);
            }
        }

        public void Toggle(string task)
        {
            if (_items.ContainsKey(task)) { _items[task] = !_items[task]; }
        }

        public List<string> GetCompleted()
        {
            return _items.Keys.Where(task => _items[task]).ToList();
        }

        public List<string> GetUncompleted()
        {
            return _items.Keys.Where(task => !_items[task]).ToList();
        }

        public bool Search(string task)
        {
            return _items.ContainsKey(task);
        }

        public void Remove(string task)
        {
            if (_items.ContainsKey(task)) {
                _items.Remove(task);
            }
        }

        public List<string> AscendingList()
        {
            return _items.Keys.OrderBy(t => t).ToList();
        }

        public List<string> DescendingList()
        {
            return _items.Keys.OrderByDescending(t => t).ToList();
        }
    }
}
