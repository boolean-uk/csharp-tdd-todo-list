using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private List<TodoTask> _tasks { get; set; } = new List<TodoTask>();

        public TodoList(List<TodoTask> tasks)
        {
            _tasks = tasks;
        }

        public bool AddTask(TodoTask task)
        {

            _tasks.Add(task);
            return true;
 
        }

            public void ChangeStatus(TodoTask task, bool completed)
            {
            task.Completed = completed;
            }

            public bool RemoveTask(TodoTask task)
            {
                if(!_tasks.Contains(task)) return false;
                _tasks.Remove(task);
                return true ;
            }

            public string SearchTask(TodoTask task)
            {
            if (_tasks.Contains(task)) return "Success";
            return "Not found";
            }
        
    }
}

