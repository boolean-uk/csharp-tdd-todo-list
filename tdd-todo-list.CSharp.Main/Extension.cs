using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        //List that contans arrays of strings, where every string represents a task
        private List<string[]> tasks = new List<string[]>();

        //Add new task with all attributes
        public void addTask(string taskName, string status) 
        {
            string[] task = new string[]
            {
                taskName, //TaskName
                Guid.NewGuid().ToString(), //ID
                DateTime.Now.ToString("yyyy-MM-dd HH:mm"), //TimeStamp
                status //Status
            };
            tasks.Add(task);
            
        }

        //getID of task
        public string getID(string taskName) 
        {
            string ID = "";
            foreach (var task in tasks) 
            {
                if (task[0] == taskName) 
                {
                    ID = task[1];
                }
            }
            return ID;
        }

        //Get task by provide ID
        public string[] getTaskByID(string ID) 
        {

            foreach (var task in tasks) 
            {
                if (task[1] == ID) 
                {
                    return task;
                }
            }
            return new string[] { "ID does not exist" };

        }

        //update Taskname by provide ID
        public void updateTaskNameByID(string ID, string taskName) 
        {
            foreach (var task in tasks)
            {
                if (task[1] == ID) 
                {
                    task[0] = taskName;
                }
            }
        }

        //update TaskStatus by provide ID
        public void updateTaskStatusByID (string ID, string status) 
        {
            foreach(var task in tasks) 
            {
                if (task[1] == ID) 
                {
                    task[3] = status;
                }
            }
        }

        //Show all tasks & timestamps related
        public string[] showTimeStamps() 
        {
            List<string> taskAndTimeStamps = new List<string>();

            foreach (var task in tasks) 
            {
                taskAndTimeStamps.Add(task[0] + ":" + task[2]);
            }


            return taskAndTimeStamps.ToArray();

        }
    }
}
