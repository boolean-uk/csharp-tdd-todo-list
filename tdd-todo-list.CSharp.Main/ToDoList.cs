using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> tasks = new Dictionary<string, bool>();
        public bool Add(string task)
        {
            if (tasks.ContainsKey(task))
            {
                return false;
            }
            tasks.Add(task, true);
            return true;
        }

        public string List()
        {
            throw new NotImplementedException();
        }
    }
}
