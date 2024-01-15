using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        public Dictionary<int, Task> todoList = new Dictionary<int, Task>();
        public struct Task
        {
            public string taskTitle;
            public bool complete;
            public readonly string dateTime;
            private DateTime DateAndTimeCreated {  get; set; } 
            public Task(string taskName, bool taskStatus)
            {
                taskTitle = taskName;
                complete = taskStatus;
                DateAndTimeCreated = DateTime.Now;
                dateTime = DateAndTimeCreated.ToString();
            }
        }

        public void AddTaskToList(Task task, int taskId)
        {

            todoList.Add(taskId, task);
        }

        public string SearchForTask(int taskId)
        {
            if (todoList.ContainsKey(taskId))
            {
                string status = "complete";

                if (todoList[taskId].complete != true)
                {
                    status = "incomplete";
                }

                return new string($"Task: {todoList[taskId].taskTitle}, Status: {status}");
            }
            else
            {
                return new string("TaskID not found in todolist");
            }
        }


        public string EditTaskName(int taskID, string taskName)
        {
            if(todoList.ContainsKey(taskID)) 
            {
                Task tempTask = new Task();
                tempTask.taskTitle = taskName;
                tempTask.complete = todoList[taskID].complete;

                string oldTaskName = todoList[taskID].taskTitle; 
                todoList[taskID] = tempTask;

                return new string($"Task: {oldTaskName} was changed to: {todoList[taskID].taskTitle}");
               
            }
            else
            {
                return new string("TaskID not found in todolist");
            }

        }

        public string ChangeStatus(int taskID)
        {
            if (todoList.ContainsKey(taskID))
            {
                Task task = todoList[taskID];
                string status = "complete";
                string reverseStatus = "incomplete";
                if (task.complete == true)
                {
                    task.complete = false;
                    todoList[taskID] = task;
                    status = "incomplete";
                    reverseStatus = "complete"; 
                }
                else
                {
                    task.complete = true;
                    todoList[taskID] = task;
                }

                return new string($"Task: {todoList[taskID].taskTitle} Changed from {reverseStatus} to {status}");
            }
            else
            {
                return new string("TaskID not found in todolist");
            }
        }

        public string GetTimeCreated(int taskID)
        {
            if (todoList.ContainsKey(taskID))
            {

                return new string($"Task: {todoList[taskID].taskTitle} was created: {todoList[taskID].dateTime}");
            }
            else
            {
                return new string("TaskID not found in todolist");
            }
        } 

       
    }
}
