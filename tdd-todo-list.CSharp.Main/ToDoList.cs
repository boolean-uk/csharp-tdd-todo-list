using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{



    public class TodoList
    {
        private List<TodoTask> _tasks;
        public TodoList()
        {

        }

        public List<TodoTask> Tasks { get => _tasks; set => _tasks = value; }

        public bool AddTask(TodoTask t)
        {
            throw new NotImplementedException();
        }
        public bool RemoveTask(TodoTask t)
        {
            throw new NotImplementedException();
        }
        public List<TodoTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }
        public Status ChangeTaskStatus(TodoTask t, Status newstatus) 
        { 
            throw new NotImplementedException();
        }
        public List<TodoTask> GetCompleteTasks()
        {
            throw new NotImplementedException(); 
        }
        public List<TodoTask> GetIncompleteTasks() 
        {   
            throw new NotImplementedException();
        }
        public string FindTask(TodoTask t)
        {
            throw new NotImplementedException();
        }
        public List<TodoTask> GetSortedTasksAsc()
        {
            throw new NotImplementedException();
        }
        public List<TodoTask> GetSortedTasksDesc()
        {
            throw new NotImplementedException();
        }


        
    }
}
