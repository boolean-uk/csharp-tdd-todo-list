using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<UserTask> tasks = new List<UserTask>();
        public string add(UserTask taskname)
        {
            return taskname.taskname; 
        }
    }
}
