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
        private Dictionary<string, bool> todoList = new Dictionary<string, bool>();

        public Dictionary<string, bool> GetTodoList()
        {
            return todoList;
        }
        public void Add(string task, bool status) 
        {
            todoList.Add(task, status);
        }

        public List<string> ListAllTasks()
        {
            return new List<string>(todoList.Keys); 
        }

        public bool ChangeStatus(string task, bool newStatus) 
        {
            if (todoList.ContainsKey(task) && todoList[task].Equals(!newStatus))
            {
                todoList[task] = newStatus;
                return true;
            }
            else return false;
        }

        public List<string> ListAllCompletedTasks()
        {
            List<string> completedTasks = new List<string>();

            foreach (var task in todoList)
            {
                if(task.Value)
                {
                    completedTasks.Add(task.Key);
                }
            }
            return completedTasks;            
        }        
        public List<string> ListAllIncompleteTasks()
        {
            List<string> incompleteTasks = new List<string>();

            foreach (var task in todoList)
            {
                if(!task.Value)
                {
                    incompleteTasks.Add(task.Key);
                }
            }
            return incompleteTasks;            
        }

        public bool SearchTask(string task)
        {
            if(todoList.ContainsKey(task))
            {
                return true; 
            }
            else
            {
                Console.WriteLine("Given task doesn't exist in to-do list");
                return false;
            }
        }

        public void RemoveTask(string task)
        {
            if (todoList.ContainsKey(task))
            {
                todoList.Remove(task);
            }
        }

        public void OrderTasksDescending()
        {
            todoList = todoList.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }
        public void OrderTasksAscending()
        {
            todoList = todoList.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

    }
}
