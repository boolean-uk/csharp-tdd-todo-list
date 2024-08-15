using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> todo = new Dictionary<string, bool>();
        public enum TodoTaskStatus
        {
            Complete,
            InComplete,
            All
        }

        public void AddTask(string name, bool status)
        {
            todo.Add(name, status); // adds tasks to todo dictionary
        }

        public bool SeeIfTaskExists(string expected)
        {
            if (todo.ContainsKey(expected))
            {
                return true;
            }
            return false;
        }

        public bool ToogleTaskStatus(string name)
        {
            todo[name] = !todo[name];
            return todo[name];
        }

        public string PrintTasks(TodoTaskStatus status)
        {
            string tasks = string.Empty;
            foreach (var task in todo)
            {
                if (status == TodoTaskStatus.InComplete && task.Value == false)
                {
                    tasks += task.Key + "\n";
                }
                else if (status == TodoTaskStatus.Complete && task.Value == true)
                {
                    tasks += task.Key + "\n";
                }
                else // all
                {
                    tasks += task.Key + "\n";
                }
            }
            return tasks;
        }

        public string Search(string name)
        {
            if(!todo.ContainsKey(name))
            {
                return "Task was not found!";
            }
            return "Task " + name + " exists!";
            
        }

        public bool RemoveTask(string name)
        {
            if(todo.ContainsKey(name))
            {
                todo.Remove(name);
                return true;
            }
            return false;
        }
    }
}
