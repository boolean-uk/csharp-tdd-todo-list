using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, Status> _list = new Dictionary<string, Status>();

        public Dictionary<string, Status> List { get { return _list; } }
       
        public bool AddTasks(string task)
        {
            throw new NotImplementedException();
        }

        public Status ChangeStatus(string task)
        {
            throw new NotImplementedException();
        }

        public bool OrderDescending(Dictionary<string, Status> list)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTask(string task)
        {
            throw new NotImplementedException();
        }

        public string SearchForTask(string task)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Status> ShowList()
        {
            throw new NotImplementedException();
        }
    }
}
