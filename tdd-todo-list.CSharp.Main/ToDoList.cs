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

        private List<toDoTask> _taskList = new List<toDoTask>() {

                new toDoTask("exercise", true),
                new toDoTask("cook", false),
                new toDoTask("work", true),
                new toDoTask("eat", true),
                new toDoTask("sleep", false),
                new toDoTask("read", false)

            };
        public List<toDoTask> taskList { get { return _taskList; } }

        public void addTask(toDoTask toDoTask)
        {
            
            _taskList.Add(toDoTask);

        }

        public void changeStatus(string taskName, bool status)
        {
            foreach (var item in taskList)
            {
                if (item.taskName == taskName)
                {
                    item.taskComplete= status;
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
    }
}
