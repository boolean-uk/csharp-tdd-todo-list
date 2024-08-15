using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _taskList = new Dictionary<string, bool>();
        public Dictionary<string, bool> TaskList { get { return this._taskList; } }

        public void Add(string task)
        {
            _taskList.Add(task, false);
        }

        public void ChangeStatus(string task, bool isComplete)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> GetCompleteTasks()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> GetList()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> GetListInAscendingOrder()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> GetListInDescendingOrder()
        {
            throw new NotImplementedException();
        }

        public void Remove(string task)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> SearchFor(string task)
        {
            throw new NotImplementedException();
        }
    }
}
