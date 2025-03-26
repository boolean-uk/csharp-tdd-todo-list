using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> _todos = new Dictionary<string, bool>();
        public List<string> tasks = new List<string>();
       
        public TodoList() 
        {
            this._todos = new Dictionary<string, bool>();
        }

        public bool AddTaskToTodoList(string taskName, bool isComplete)
        {
            if(!_todos.ContainsKey(taskName))
            {
                _todos.Add(taskName, false);
                return true;
            }
            return false; 
        }

        // return a list of all tasks
        public Dictionary<string, bool> GetAllTasks() 
        {
            foreach (var task in _todos.Keys)
            {
                Console.WriteLine(task.ToString());
            }
            return _todos;
        }

        public bool ChangedStatus(string taskName, bool changedStatus) 
        {
            _todos[taskName] = changedStatus;
            if (changedStatus)
            {
                // prevents 
                Console.Write(taskName + " is changed to " + changedStatus);
            }
            return changedStatus;
        }

        // !TODO Does not work
        public List<string> GetCompletedTasks()
        {
            List<string> completedTasks = new List<string>();

            foreach (var task in _todos)
            {
                Console.WriteLine($"\n Task: {task.Key}, Completed: {task.Value}");
                if (task.Value) // Check if the task is completed (value is true)
                {
                    completedTasks.Add(task.Key); // Add the task name to the list of completed tasks
                }
            }

            return completedTasks;
        }  
        public List<string> GetIncompletedTasks()
        {
            List<string> incompletedTasks = new List<string>();

            foreach (var task in _todos)
            {
                Console.WriteLine($"\n Task: {task.Key}, Incompleted: {task.Value}");
                if (task.Value) // Check if the task is incompleted (value is false)
                {
                    incompletedTasks.Add(task.Key); // Add the task name to the list of incompleted tasks
                }
            }

            return incompletedTasks;
        }
    

        public bool SearchTask(string taskName)
        {
            if (_todos.ContainsKey(taskName))
            {
                return true;
            }
            else
            {
                // prints message when taskName is not found in List
                Console.WriteLine($"\n Task '{taskName}' not found.");
                return false;
            }
        }
        public bool DeleteTaskFromTodoList(string taskName)
        {
            if (_todos.ContainsKey(taskName))
            {
                _todos.Remove(taskName);
                Console.WriteLine($"\nTask: '{taskName}' is removed from todo list!");
                return true;
            }
            
            return false;
        }

        public List<string> SortTodoByAscending()
        {
            var ascTasks = _todos.OrderBy(task => task.Key).Select(task => task.Key).ToList();
            Console.WriteLine($"\n Tasks are ordered from A to D: ");
            foreach (var task in ascTasks)
            {
                Console.WriteLine(task);
            }
            return ascTasks;

        }
        
        public List<string> SortTodoByDescending()
        {
            var descTasks = _todos.OrderByDescending(task => task.Key).Select(task => task.Key).ToList();
            Console.WriteLine($"\nTasks are ordered from D to A: ");
            foreach (var task in descTasks)
            {
                Console.WriteLine(task);
            }
            return descTasks;
        }

    }
}