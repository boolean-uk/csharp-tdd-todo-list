using NUnit.Framework;
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
          new toDoTask(1, "cook", false, new DateTime(2024, 3, 18, 14, 30, 0)),
            new toDoTask(2, "work", true, new DateTime(2024, 3, 18, 14, 30, 0)),
            new toDoTask(3, "eat", true, new DateTime(2024, 3, 18, 14, 30, 0)),
            new toDoTask(4, "sleep", false, new DateTime(2024, 3, 18, 14, 30, 0)),
            new toDoTask(5, "read", false, new DateTime(2024, 3, 18, 14, 30, 0)),
            new toDoTask(6, "exercise", true, new DateTime(2024, 3, 18, 14, 30, 0)),
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

        public List<toDoTask> getAscending()
        {
            List<toDoTask> ascendingList = taskList.OrderBy(x => x.taskName).ToList();
            return ascendingList;
        }

        public List<toDoTask> getComplete()
        {
            List<toDoTask> completedList = taskList.Where(x =>x.taskComplete==true).ToList();
          
            return completedList;
        }

        public List<toDoTask> getDescending(List<toDoTask> taskList)
        {
            List<toDoTask> descendingList = taskList.OrderByDescending(x => x.taskName).ToList();
            return descendingList;
            
        }

        public List<toDoTask> getInComplete(List<toDoTask> taskList)
        {
            List<toDoTask> inCompleteList = taskList.Where(x => x.taskComplete == false).ToList();
            return inCompleteList;

        }

        public string findById(int id)
        {
            var task = taskList.FirstOrDefault(x => x.Id == id);
            return task?.taskName;
        }

        public void changeNameById(int id, string name)
        {
            foreach (var item in taskList)
            {
                if (item.Id == id)
                {
                    item.taskName = name;
                }
            }
        }

        public void changeStatusById(int id, bool newStatus)
        {
            foreach (var item in taskList)
            {
                if (item.Id == id)
                {
                    item.taskComplete = newStatus;
                }
            }
        }

        public DateTime getDateTime(string taskToCheck)
        {
           var task = taskList.FirstOrDefault(x => x.taskName==taskToCheck);
            return task.creationDate;
        }

        public void removeTask(string taskToRemove)
        {

            taskList.RemoveAll(item => item.taskName == taskToRemove);
        }

        public string checkExists(string taskName)
        {
            string feedback = "";
            foreach (var item in taskList)
            {
                
                if (item.taskName == taskName)
                {
                    feedback = "Task Exists";
                }
                else
                {
                    feedback = "Task Doesnt Exist";
                }
            }
            
            return feedback;


        }
    }
}
