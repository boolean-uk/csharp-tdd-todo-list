using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private List<TodoTask> _tasks = new List<TodoTask>();

        public TodoList(List<TodoTask> tasks)
        {
            _tasks = tasks;
        }

        public bool AddTask(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public bool ChangeStatus(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTask(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public string SearchTask(TodoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
