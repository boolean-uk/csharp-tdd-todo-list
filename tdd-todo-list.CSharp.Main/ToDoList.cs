using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary <string, string> ToDoList = new Dictionary<string, string> ();

        public bool AddTask(string task)
        {
            string newTaskStatus = "Incomplete";

            if (!ToDoList.ContainsKey(task)) 
            {
                ToDoList.Add(task, newTaskStatus);
                return true;
            }
            return false;
            
        }

        public Dictionary<string, string> ViewToDoList { get { return ToDoList; } }


    }
}
