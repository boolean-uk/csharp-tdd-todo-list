using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TodoTask> todoList { get; set; }

        public TodoList()
        {
            this.todoList = new List<TodoTask>();
        }

        public bool AddTask(TodoTask task)
        {
            return false;
        }

        public List<TodoTask> AllTasks()
        {
            return new List<TodoTask>();
        }

        public TodoTask FetchTask(string taskName)
        {
            return null;
        }

        public bool ChangeStatus(string taskName, Status newStatus)
        {
            return false;
        }

        public List<TodoTask> FetchTasksWithStatus(Status status)
        {
            return new List<TodoTask>();
        }

        public string DoesExist(string taskName)
        {
            return "Test";
        }

        public bool RemoveTask(string taskName)
        {
            return false;
        }

        public List<TodoTask> AllTasksSorted(string order)
        {
            return new List<TodoTask>();
        }

        public void PrintTaskList(List<TodoTask> tasks)
        {
        }
    }
}
