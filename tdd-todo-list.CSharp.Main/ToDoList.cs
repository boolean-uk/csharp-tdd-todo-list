using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public Dictionary<string, Task> list = new Dictionary<string, Task>();

        public Task AddTask(string id, Task task)
        {
            list.Add(id, task);
            return task;
        }

        public Task ChangeTaskStatus(string id, bool v)
        {
            Task task = list[id];
            task.Completed = v;
            return task;
        }

        public List<Task> GetTasksByStatus(bool v)
        {
            List<Task> tasks = new List<Task>();
            foreach (var task in list.Values) {
                if(task.Completed == v)
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public List<Task> ListTasksAlphabeticalOrder(string v)
        {
            List<Task> result = list.Values.ToList();
            result.Sort((x, y) => string.Compare(x.Desc, y.Desc));

            if (v.ToUpper().Equals("DESCENDING"))
            {
               result.Reverse();
            }
            return result;
            
        }

        public List<Task> ListTasksByPriority(int v)
        {
            List<Task> values = list.Values.ToList();
            List<Task> result = new List<Task>();

            foreach (var task in values)
            {
                if(task.Priority == v)
                {
                    result.Add(task);
                }
            }
            return result;
        }

        public Task RemoveTask(string id)
        {
            Task task = list[id];
            list.Remove(id);
            return task;
        }

        public Task RenameTaskbyId(string id, string v)
        {
            Task task = list[id];
            task.Desc = v;
            return task;
        }

        public bool SearchTask(string id)
        {
            if(list.ContainsKey(id)) { return true; }
            else return false;
        }

        public List<Task> GetTasksByCategory(string c)
        {
            List<Task> tasks = new List<Task>();
            foreach (var task in list.Values)
            {
                if (task.Category.Equals(c))
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public DateTime getTaskCompletionTime(string id)
        {
            return list[id].Finished;
        }
    }
}
