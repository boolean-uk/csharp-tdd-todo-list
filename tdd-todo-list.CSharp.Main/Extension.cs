using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        Dictionary<int, string> _toDoList;
        //private Dictionary<int, TaskInfo> _toDoListTime;
        public int nextTaskId;





        //each task is associated with an integer ID(taskID), starting from 1 an dincremented with each task
        public TodoListExtension()
        {
            _toDoList = new Dictionary<int, string>();
            //_toDoListTime =new  Dictionary<int, TaskInfo>();
            nextTaskId = 1;
        }
        // add method uses the integer ID as the key in the toDoList dictionary
        public void addId(string task, string status)
        {
            _toDoList.Add(nextTaskId, task);
            nextTaskId++;
        }


        /*public class TaskInfo
        {
            public string TaskName { get; set; }
            public string Status { get; }
            public DateTime CreationTime { get; }

            public TaskInfo(string taskName, string status, DateTime creationTime)
            {
                TaskName = taskName;
                Status = status;
                CreationTime = creationTime;
            }
        }


    

        public void addTimeDate(TaskInfo taskInfo)
        {
            _toDoList.Add(nextTaskId, taskInfo);
            nextTaskId++;
        }


        public string getTaskByIdDateTime(int taskId)
        {
            if (_toDoListTime.TryGetValue(taskId, out TaskInfo taskInfo))
            {
                return taskInfo.TaskName;
            }

            return null; // Task not found
        }

        public DateTime getTaskCreationTime(int taskId)
        {
            if (_toDoListTime.TryGetValue(taskId, out TaskInfo taskInfo))
            {
                return taskInfo.CreationTime;
            }

            return DateTime.MinValue; // Task not found
        }

        public void updateTaskNameTime(int taskId, string newTaskName)
        {
            if (_toDoListTime.ContainsKey(taskId))
            {
                _toDoListTime[taskId].TaskName = newTaskName;
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
            }
        }
        */

        //getTaskByID takes and integer ID as an arguemtn and returns the matching task
        public string getTaskById(int taskId)
        {
            if (_toDoList.TryGetValue(taskId, out string task))
            {
                return task;
            }

            return null; // Task not found
        }




        //updateTaskName takes the task ID and a new name as input. Updates the task name if the ID is found.
        public void updateTaskName(int taskId, string newTaskName)
        {
            if (_toDoList.ContainsKey(taskId))
            {
                _toDoList[taskId] = newTaskName;
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
            }
        }



    }
}
