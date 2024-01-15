using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public enum SortOrder
    {
        NotSorted,
        Ascending,
        Descending
    }
    public class TodoList
    {
        private List<TodoTask> _tasks;


        public TodoList()
        {
            _tasks = new List<TodoTask>();
        }

        public void AddTask(string description)
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(int index = -1)
        {
            throw new NotImplementedException();
        }

        public void CompleteTask(int index = -1)
        {
            throw new NotImplementedException();
        }

        public void IncompleteTask(int index = -1)
        {
            throw new NotImplementedException();
        }

        public List<TodoTask> GetAllTasks(SortOrder sortOrder = SortOrder.NotSorted)
        {
            throw new NotImplementedException();
        }

        public List<TodoTask> GetCompletedTasks(SortOrder sortOrder = SortOrder.NotSorted)
        {
            throw new NotImplementedException();
        }

        public List<TodoTask> GetIncompleteTasks(SortOrder sortOrder = SortOrder.NotSorted)
        {
            throw new NotImplementedException();
        }

        public List<TodoTask> GetTasksWithSubstring(string substr, SortOrder sortOrder = SortOrder.NotSorted)
        {
            throw new NotImplementedException();
        }

        public string SearchTasks(string substr, SortOrder sortOrder = SortOrder.NotSorted)
        {
            throw new NotImplementedException();
        }
    }
}
