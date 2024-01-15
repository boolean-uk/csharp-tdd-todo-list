using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> _items = new Dictionary<string, bool>();
        public bool Add(string task)
        {
            return _items.TryAdd(task, false);
        }

        public Dictionary<string, bool> ListTasks()
        {
            return _items.ToDictionary(a => a.Key, a => a.Value );
        }

        public bool SetTaskStatus(string task, bool completeStatus)
        {
            KeyValuePair<string, bool> retrievedTask = _items.FirstOrDefault(t => t.Key == task, new KeyValuePair<string, bool>("Invalid", true));
            if (retrievedTask.Key == "Invalid") 
            {
                return false;
            }

            _items.Remove(retrievedTask.Key);
            if (_items.TryAdd(retrievedTask.Key, completeStatus))
            {
                return true;
            } else 
            {
                _items.Add(retrievedTask.Key, retrievedTask.Value );
                return false;
            }
        }

        public Dictionary<string, bool> GetCompleteTasks()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> GetIncompleteTasks()
        {
            throw new NotImplementedException();
        }

        public string FindTask(string text, out int index)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTask(string text) 
        {
            throw new NotImplementedException();
        }
    }

    public class TodoSorter() 
    {
        public static Dictionary<string, bool> SortAscending(Dictionary<string, bool> items) 
        {
            throw new NotImplementedException();
        }

        public static Dictionary<string, bool> SortDescending(Dictionary<string, bool> items)
        {
            throw new NotImplementedException();
        }
    }
}
