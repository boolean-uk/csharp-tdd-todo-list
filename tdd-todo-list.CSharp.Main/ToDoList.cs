using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public int taskCount { get { return _todoList.Count; } }

        private Dictionary<string, bool> _todoList { get; set; } = new Dictionary<string, bool>();
        public bool Add(string task)
        {
            //I assume a task is initially not completed
            _todoList.Add(task, false);
            return true;
        }

        public bool ChangeTask(string task)
        {
            if (_todoList.ContainsKey(task))
            {
                if (_todoList[task] == true)
                {
                    _todoList[task] = false;
                    return true;
                }
                _todoList[task] = true;
                return true;
            }
            return false;
        }

        public List<string> getCompletedTasks()
        {
            throw new NotImplementedException();
        }

        public List<string> showAllTasks(){ return _todoList.Keys.ToList(); }

    }
}
