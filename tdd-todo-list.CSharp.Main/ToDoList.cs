using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public List<toDoTask> taskList { get { return taskList; } }

        public void addTask(toDoTask toDoTask)
        {
            
        }

        public List<toDoTask> getAll()
        {
            throw new NotImplementedException();
        }

        public List<toDoTask> getAscending(List<toDoTask> taskList)
        {
            throw new NotImplementedException();
        }

        public List<toDoTask> getComplete(List<toDoTask> taskList)
        {
            throw new NotImplementedException();
        }

        public List<toDoTask> getInComplete(List<toDoTask> taskList)
        {
            throw new NotImplementedException();
        }
    }
}
