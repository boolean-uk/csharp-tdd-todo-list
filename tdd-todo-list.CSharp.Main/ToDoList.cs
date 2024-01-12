using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> items = new Dictionary<string, bool>();
        public bool Add(string task) 
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, bool> ListTasks() 
        {
            throw new NotImplementedException();
        }

        public bool SetTaskStatus(int index, bool completeStatus) 
        {
            throw new NotImplementedException();
        }
    }
}
