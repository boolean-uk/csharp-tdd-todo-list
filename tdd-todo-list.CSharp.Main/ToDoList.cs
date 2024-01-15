using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> Todos = new Dictionary<string, bool>();
       

        public void AddTask(string task)
        {
            bool completed = false;
            
            if(!Todos.ContainsKey(task)) 
            {
                Todos.Add(task.ToLower(), completed);
            }

        }


        public int showTodoList()
        {
            int count = 0;
            
            foreach(string task in Todos.Keys) 
            {
                count ++;
                Console.WriteLine($"{task} is completed: {Todos[task]}");
            }

            return count;
        }
        public void changeTaskStatus(string task)
        {
            if (Todos.ContainsKey(task))
            {
                Todos[task] = true;
                
            }
        }

        public int showCompletedTasks()
        {
            int count = 0;
            foreach(var task in Todos)
            {
                if (task.Value == true) 
                {
                    count++;
                    Console.WriteLine($"{task.Key} is completed: {task.Value}");
                    
                }
               
            }
            return count;
        }

        public int showIncompletedTasks()
        {
            int count = 0;
            foreach (var task in Todos)
            {
                if (task.Value == false)
                {
                    count++;
                    Console.WriteLine($"{task.Key} is completed: {task.Value}");

                }

            }
            return count;
        }

       

        public string search(string task)
        {
            StringBuilder sb = new StringBuilder();
            if (!Todos.ContainsKey(task))
            {
                sb.Append("Task not in list");
                Console.WriteLine(sb);
                
            }
            return sb.ToString();
        }

        public bool RemoveTask(string task)
        {
            if(Todos.ContainsKey(task))
            {
                Todos.Remove(task);
                return true;
            }

            return false;
        }

        public string SortAlphaAsc()
        {
            var sortedDict = from entry in Todos orderby entry.Key ascending select entry;
            StringBuilder sb = new StringBuilder();

            foreach (var item in sortedDict)
            {
                sb.Append(item);
                Console.WriteLine(item.ToString());
            }

            return sb.ToString();
        }

        public string SortDecs()
        {
            var sortedDict = from entry in Todos orderby entry.Key descending select entry;
            StringBuilder sb = new StringBuilder();

            foreach (var item in sortedDict)
            {
                sb.Append(item);
                Console.WriteLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
