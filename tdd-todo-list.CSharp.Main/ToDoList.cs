using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private List<toDoTask> _taskList;

        public List<toDoTask> taskList { get { return _taskList; } }

        public TodoList()
        {
            _taskList = new List<toDoTask>()
        {
            new toDoTask("cook", false),
            new toDoTask("work", true),
            new toDoTask("eat", true),
            new toDoTask("sleep", false),
            new toDoTask("read", false),
            new toDoTask("exercise", true),
        };
        }

        public void addTask(toDoTask toDoTask)
        {
            
            _taskList.Add(toDoTask);
            Console.WriteLine(toDoTask);

        }

        public void changeStatus(string name, bool status)
        {
            foreach (var item in taskList)
            {
                if (item.taskName == name)
                {
                    item.taskComplete = status;
                    break;
                }
            }
        }

        public List<toDoTask> getAll()
        {
            return taskList;
        }

        public List<toDoTask> getAscending(List<toDoTask> taskList)
        {
            List<toDoTask> ascendingList = taskList.OrderBy(x => x.taskName).ToList();
            return ascendingList;
        }

        public List<toDoTask> getComplete(List<toDoTask> taskList)
        {
            List<toDoTask> completedList = new List<toDoTask> ();
            foreach (var item in taskList)
            {
                if (item.taskComplete == true)
                {
                    completedList.Add(item);
                }
            }
            return completedList;
        }

        public List<toDoTask> getDescending(List<toDoTask> taskList)
        {
            List<toDoTask> descendingList = taskList.OrderByDescending(x => x.taskName).ToList();
            return descendingList;
            
        }

        public List<toDoTask> getInComplete(List<toDoTask> taskList)
        {
            List<toDoTask> inCompleteList = new List<toDoTask>();
            foreach (var item in taskList)
            {
                if (item.taskComplete == false)
                {
                    inCompleteList.Add(item);
                }
            }
            return inCompleteList;

        }

        public string findById(int id)
        {
            throw new NotImplementedException();
        }

        public void changeNameById(int id, string name)
        {
            throw new NotImplementedException();
        }

        public void changeStatusById(int testId, bool newStatus)
        {
            throw new NotImplementedException();
        }

        public DateTime getDateTime(string taskToCheck)
        {
            throw new NotImplementedException();
        }
    }
}
