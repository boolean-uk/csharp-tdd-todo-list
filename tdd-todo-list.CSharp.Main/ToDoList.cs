using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        
        public struct Task
        {
            public string taskTitle;
            public bool complete;
            public Task(string taskName,bool taskStatus)
            {
                taskTitle = taskName;
                complete = taskStatus;
               
            }

            
               
        }
        public Dictionary<int,Task> todoList = new Dictionary<int, Task>();


        public void AddTaskToList(Task task , int taskId)
        {
            
            todoList.Add(taskId ,task);
        }

        public List<string> ShowList() 
        {
            List<string> list = new List<string>();
            foreach (var task in todoList)
            {
                list.Add(task.Value.taskTitle);
            }
            return list;
        }

        public bool ChangeStatus(int taskId)
        {
            if(todoList.ContainsKey(taskId))
            {   
                Task task = todoList[taskId];
                if(task.complete == true) 
                {   
                    task.complete = false;
                    todoList[taskId] = task;
                }
                else
                {
                    task.complete = true;
                    todoList[taskId] = task;
                }
                
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<string> GetCompleatedTasks()
        {
            List<string> strings = new List<string>();
            foreach (var task in todoList)
            {
                if (task.Value.complete)
                {
                    strings.Add(task.Value.taskTitle);

                }

            }

            return strings; 
        }

        public List<string> GetIncompleatedTasks()
        {
            List<string> strings = new List<string>();
            foreach (var task in todoList)
            {
                if (!task.Value.complete)
                {
                    strings.Add(task.Value.taskTitle);

                }

            }

            return strings;
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
                return new string("TaskID not in todolist");
            }
        }

        public string RemoveTask(int taskID)
        {

            if (todoList.ContainsKey(taskID))
            {   
                Task temp = todoList[taskID];
                todoList.Remove(taskID);
                return new string($"Task: {temp.taskTitle}, was removed from todolist");
            }
            else
            {
                return new string("TaskID not in todolist");
            }
        }

        public List<string> SortAlphabeticallyAssending()
        {
            List<string> strings = new List<string> ();
            foreach (var task in todoList)
            {
                strings.Add (task.Value.taskTitle);
            }

            strings.Sort();
            return strings ;
        }

        public List<string> SortAlphabeticallyDescening()
        {
            List<string> strings = new List<string>();
            
            foreach (var task in todoList)
            {
                strings.Add(task.Value.taskTitle);
            }

            strings.Sort();

            strings.Reverse();
            return strings;
        }



    }
}
