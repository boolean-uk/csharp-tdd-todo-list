using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> _tasks;

        public TodoList() { 
            _tasks = new Dictionary<string, bool>();
        }

        public Dictionary<string, bool> Tasks { get { return _tasks; } }

        public void Add(string name)
        {
            Tasks.Add(name, false);
        }

        public void ChangeStatus(string name)
        {
            if (Tasks.ContainsKey(name))
            {
                Tasks[name] = !Tasks[name];
            }
            else
            {
                throw new Exception("Task does not exist");
            }
        }

        public List<string> GetTasks(bool completed)
        {
            List<string> tasks = new List<string>();
            foreach ((string name, bool _) in Tasks.Where(task => task.Value == completed))
            {
                tasks.Add(name);
            }
            return tasks;
        }

        public Tuple<string, bool> Search(string name)
        {
            if(Tasks.ContainsKey(name))
            {
                return new Tuple<string, bool>(name, Tasks[name]);
            }
            else
            {
                throw new Exception("Task does not exist");
            }
        }

        public void Remove(string name)
        {
            if(Tasks.ContainsKey(name))
            {
                Tasks.Remove(name);
            }
            else
            {
                throw new Exception("Task does not exist");
            }
        }

        public IEnumerable<KeyValuePair<string, bool>> OrderAscending()
        {
            return Tasks.OrderBy(task => task.Key);
        }

        public IEnumerable<KeyValuePair<string, bool>> OrderDescending()
        {
            return Tasks.OrderByDescending(task => task.Key);
        }
    }
}
