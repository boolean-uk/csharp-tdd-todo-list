using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public List<Task> tasks;

        public TodoListExtension()
        {
            this.tasks = new List<Task>();
        }

        public Task SearchById(int id)
        {
            return tasks.Find(x => x._id == id);
        }

        public bool setNameById(int id, string name)
        {
            var task = SearchById(id);
            if (task != null)
            {
                task._name = name;
                return true;
            }
            return false;
        }

        public bool setStatusById(int id, bool newStatus)
        {
            var task = SearchById(id);
            if (task != null)
            {
                task._status = newStatus;
                return true;
            }
            return false;
        }
    }

}
