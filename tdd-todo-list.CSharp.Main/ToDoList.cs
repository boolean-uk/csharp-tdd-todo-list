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
                
            }
            if (status == TodoTaskStatus.InComplete)
            {
                
            }
            else if (status == TodoTaskStatus.Complete)
            {
                
            }
            else
            {
                
            }
        }
    }
}
