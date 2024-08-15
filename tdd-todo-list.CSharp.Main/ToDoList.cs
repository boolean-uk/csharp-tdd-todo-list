using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _list = new Dictionary<string, bool>();
        public Dictionary<string, bool> List {  get { return _list; } }

        public String addTask(string name)
        {
            throw new NotImplementedException();
        }


    }
}
