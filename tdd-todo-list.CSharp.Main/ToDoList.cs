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
    }
}
