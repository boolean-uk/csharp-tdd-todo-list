using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, TaskClass> _toDoList = new Dictionary<string, TaskClass>();
        private int _taskCount = 0;
        private List<string> _taskIDs = new List<string>();



        public void Add(string task)
        {
            _taskCount++;
            string taskID = _taskCount.ToString() + "T";
            TaskIDs.Add(taskID);
            TaskClass taskObject = new TaskClass(task);    
            _toDoList.Add(taskID, taskObject);
        }

        public string[] PrintAll()
        {
            if (_taskCount != 0)
            {
            string[] allTasks = new string[_taskCount];
            int counter = 0;

                foreach (string iD in _taskIDs) 
                {
                    string temp = _toDoList[iD].TaskHolder;
                    allTasks[counter] = temp ;
                    counter++;
                    
                }
            
            return allTasks;

            }

            string[] allTasks1 = new string[1] { "There is no tasks in the todo list" };
            return allTasks1;
        }

        public void ChangeStatus(string task)
        {
            foreach (TaskClass tempTask in _toDoList.Values)
            {
                if (tempTask.TaskHolder == task)
                {
                    tempTask.ChangeStatus();
                }
            }
        }

        public List<string> Show(bool status)
        {
           List<string> temp = new List<string>();
           foreach (TaskClass tempTask in _toDoList.Values)
            {
                if (tempTask.IsComplete == status)
                    temp.Add(tempTask.TaskHolder);
            }
           return temp;
        }

        public string Search(string searchParameter)
        {
            if (_taskCount != 0)
            {
                foreach (TaskClass task in _toDoList.Values)
                {
                    if (task.TaskHolder == searchParameter)
                        return task.TaskHolder;
                    else
                        return "Task is not found";
                }
            }
            return "Task is not found";
        }

        public bool Remove(string task)
        {
            throw new NotImplementedException();
        }


        /*
            

            public string Search(string task)
            {
                if (_toDoList.ContainsKey(task))
                {
                    return "Task is found";
                }
                else
                {
                    return "Task is not found";
                }
            }

            public bool Remove(string task)
            {
                if (_toDoList.ContainsKey(task))
                {
                    _toDoList.Remove(task);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public List<string> Sort(string order)
            {
                if (order == "Ascend")
                {
                    List<string> sortedTasks = _toDoList.Keys.ToList();
                    sortedTasks.Sort();
                    return sortedTasks;
                }
                else
                {
                    List<string> sortedTasks = _toDoList.Keys.ToList();
                    sortedTasks.Sort();
                    sortedTasks.Reverse();
                    return sortedTasks;
                }

            }
            */

        public Dictionary<string, TaskClass> ToDoDict { get => _toDoList; }
        public List<string> TaskIDs { get => _taskIDs; }
    }
}
