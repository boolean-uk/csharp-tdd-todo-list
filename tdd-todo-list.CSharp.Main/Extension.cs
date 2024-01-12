using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public struct Tasks
    {
        public string name;
        public bool completed;
        public int ID;
        public int date;
        public int time;
    }

    public class TodoListExtension
    {
        private List<Tasks> tasks = new List<Tasks>();

        public void AddTask(string taskName, bool completed, int ID, int date, int time)
        {
            Tasks temp = new Tasks();
            temp.name = taskName;
            temp.completed = completed;
            temp.ID = ID;
            temp.date = date;
            temp.time = time;

            tasks.Add(temp);
        }

        public string GetName(int ID)
        {
            string message = "Do not exist";

            for (int i = 0; i < tasks.Count(); i++)
            {
                if (tasks[i].ID == ID)
                    message = tasks[i].name;
            }

            return message;
        }

        public bool NewName(int ID, string newName)
        {
            bool changedName = false;

            for (int i = 0; i < tasks.Count(); i++)
            {
                if (tasks[i].ID == ID)
                {
                    tasks[i].name.Replace(tasks[i].name, newName);
                    changedName = true;
                }
                    
            }

            return changedName;
        }

        public bool ChangeStatus(int ID)
        {
            bool changedStatus = false;

            for (int i = 0; i < tasks.Count(); i++)
            {
                if (tasks[i].ID == ID)
                {
                    tasks[i].completed.ToString().Replace(tasks[i].completed.ToString(), (!tasks[i].completed).ToString());
                    changedStatus = true;
                }

            }

            return changedStatus;
        }

        public string GetDayTime(int ID)
        {
            string message = "Do not exist";

            for (int i = 0; i < tasks.Count(); i++)
            {
                if (tasks[i].ID == ID)
                {
                    message = tasks[i].date.ToString();
                    message += ", ";
                    message += tasks[i].time.ToString();
                }
            }

            return message;
        }
    }
}
