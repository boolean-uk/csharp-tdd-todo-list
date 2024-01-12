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
            throw new NotImplementedException();
        }

        public List<string> GetIncompleatedTasks()
        {
            throw new NotImplementedException();
        }

        public string SearchForTask(int taskId)
        {
            throw new NotSupportedException();
        }


    }
}
