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
        private Dictionary<Guid, string> TaskListMapping;
        private Dictionary<Guid, DateTime> TaskListDateTimeMapping;

        public TodoListExtension()
        {
            TaskList = new Dictionary<string, string>();
            TaskListMapping = new Dictionary<Guid, string>();
            TaskListDateTimeMapping = new Dictionary<Guid, DateTime>();
        }

        public void AddTask(string task)
        {
            Guid id = Guid.NewGuid();
            TaskList.Add(task, "incomplete");
            TaskListMapping.Add(id, task);
            TaskListDateTimeMapping.Add(id, DateTime.Now);


        }


        public string RetrieveTaskByID(Guid id)
        {

            string task = TaskListMapping[id];
            return task;

        }

        public void ChangeTaskName(Guid id, string name)
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

        public void ChangeTaskStatusByID(Guid id, string status)
        {

            string task = TaskListMapping[id];

            TaskList[task] = status;

        }

        public string GetStatus(string task)
        {
            return TaskList[task];
        }


        public string DisplayDate(Guid id)
        {

            DateTime date = TaskListDateTimeMapping[id];
            string dater = $"{date}";

            return dater;
        }

        public Guid getId(string task)
        {
            foreach (Guid key in TaskListMapping.Keys)
            {
                if (task == TaskListMapping[key])
                {
                    return key;
                }
            }
            return Guid.Empty;
        }
    }
}
