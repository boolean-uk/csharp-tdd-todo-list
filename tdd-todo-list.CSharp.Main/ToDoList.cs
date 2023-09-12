using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> _tasks = new Dictionary<string, bool>();

        public bool add(string task)
        {
            return _tasks.TryAdd(task, false);
        }

        public Dictionary<string, bool> tasks()
        {
            return _tasks;
        }

        public bool changeStatus(string task)
        {
            if (_tasks.ContainsKey(task))
            {
                _tasks[task] = !_tasks[task];
                return true;
            }
            return false;
        }

        public Dictionary<string, bool> completeTasks()
        {
            return _tasks.Where(i => i.Value).ToDictionary(i => i.Key, i => i.Value);
        }

        public Dictionary<string, bool> incompleteTasks()
        {
            return _tasks.Where(i => i.Value == false).ToDictionary(i => i.Key, i => i.Value);
        }

        public string search(string task)
        {
            return _tasks.ContainsKey(task) ? task : "task not found";
        }


        public bool remove(string task)
        {
            if (_tasks.ContainsKey(task))
            {
                _tasks.Remove(task);
                return true;
            }
            return false;
        }

        public List<KeyValuePair<string, bool>> tasksInAscOrder()
        {
            return _tasks.OrderBy(task => task.Key).ToList();
        }

        public List<KeyValuePair<string, bool>> tasksInDescOrder()
        {
            return _tasks.OrderByDescending(task => task.Key).ToList();
        }

        public Dictionary<string, bool> Tasks { get { return _tasks; } }
    }
}
