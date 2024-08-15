using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public TodoList() 
        {

        }

        List<string> taskList = new List<string>();

        public string taskname;

        public string add(string taskname)
        {
            return taskname; 
        }
    }
}
