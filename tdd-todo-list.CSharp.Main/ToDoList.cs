using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Tasks> _tasks = new List<Tasks>();

        //public TodoList();

        public bool Add(Tasks task)
        {
            _tasks.Add(task);
            return false;
        }

        public bool ChangeStatus(string taskName)
        {
            return false;
        }

        public void SetTasks(List<Tasks> tasks)
        {
            _tasks = tasks;
        }

        public string FindTask(string taskName)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> GetCompleted()
        {
            return null;
        }

        public List<Tasks> GetIncompleted()
        {
            return null;
        }

        public List<Tasks> GetTodoList()
        {
            return null;
        }

        public void RemoveTask(string name)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> SortAscending()
        {
            throw new NotImplementedException();
        }

        public List<Tasks> SortDescending()
        {
            throw new NotImplementedException();
        }
    }
}
