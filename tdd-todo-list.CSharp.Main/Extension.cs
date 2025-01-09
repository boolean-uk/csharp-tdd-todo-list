using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private Dictionary<string, string> TaskList;
        private Dictionary<int, string> TaskListMapping;
        private Dictionary<int, DateTime> TaskListDateTimeMapping;
        public TodoListExtension()
        {
            TaskList = new Dictionary<string, string>();
            TaskListMapping = new Dictionary<int, string>();
            TaskListDateTimeMapping = new Dictionary<int, DateTime>();
        }

        public void AddTask(string task, int id)
        {
            if (TaskListMapping.ContainsKey(id))
            {
                throw new Exception("There is already a task with that ID number");
            }
            else
            {
                TaskList.Add(task, "incomplete");
                TaskListMapping.Add(id, task);
                TaskListDateTimeMapping.Add(id, DateTime.Now);
            }

        }


        public string RetrieveTaskByID(int id)
        {

            string task = TaskListMapping[id];
            return task;

        }

        public void ChangeTaskName(int id, string name)
        {

            string oldname = TaskListMapping[id];
            string oldstatus = TaskList[oldname];
            TaskList.Remove(oldname);
            TaskList.Add(name, oldstatus);
            TaskListMapping[id] = name;

        }

        public void DisplayTasks()
        {

            foreach (string task in TaskList.Keys)
            {
                Console.WriteLine($"{task} : {TaskList[task]}");

            }


        }
        public bool TaskExists(string task)
        {
            return TaskList.ContainsKey(task);
        }

        public void ChangeTaskStatusByID(int id, string status)
        {

            string task = TaskListMapping[id];

            if (TaskExists(TaskList[task]))
            {
                TaskList[task] = status;
            }

            else
            {
                throw new Exception("The task does not exist");
            }
        }

        public string GetStatus(string task)
        {
            return TaskList[task];
        }


        public string DisplayDate(int id)
        {

            DateTime date = TaskListDateTimeMapping[id];
            string dater = $"{date}";

            return dater;
        }
    }
}
